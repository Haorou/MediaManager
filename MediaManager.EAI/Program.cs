using MediaManager.Bll;
using MediaManager.Entity;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MediaManager.EAI
{
    class Program
    {
        public const bool SignalR = true;
        private const string FolderXmlPath = "D:/Projets/XML";
        private static Queue<string> IncomingFileQueue = new Queue<string>();

        static void Main(string[] args)
        {
            StartXmlFileWatcher();
            TreatmentXml().Start();
        }

        private static void StartXmlFileWatcher()
        {
            try
            {
                FileSystemWatcher watcher = new FileSystemWatcher
                {
                    Path = $"{FolderXmlPath}/IN/",
                    NotifyFilter = NotifyFilters.Size,
                    Filter = "*.xml"
                };
                watcher.Changed += Watcher_Changed;
                watcher.EnableRaisingEvents = true;
            }
            catch
            {
                Console.WriteLine("File Watcher Error");
            }
        }

        private static void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            IncomingFileQueue.Enqueue(e.FullPath);
        }

        private static async Task TreatmentXml()
        {
            while(true)
            {
                try
                {
                    while(IncomingFileQueue.Any())
                    {
                        var file = IncomingFileQueue.Dequeue();

                        Console.WriteLine($"Changed : {file}");
                        string xml = String.Join("\r\n", File.ReadAllLines(file));
                        TreatXml(xml);
                        if(File.Exists(file))
                        {
                            File.Delete(file);
                        }
                    }
                }
                catch(IOException ex)
                {
                    Console.WriteLine($"Sleep : {ex.Message}");
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{ex.Message}");
                }
            }
        }

        private static async void TreatXml(string xml)
        {
            try
            {
                XDocument xmlDoc = XDocument.Parse(xml);
                XmlSerializer s = new XmlSerializer(typeof(movie));
                var filmFromXml = (movie)s.Deserialize(xmlDoc.CreateReader());
                var film = filmFromXml.ToFilmEntity();
                Save(film);
                Console.WriteLine("film enregistré");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static async void Save(Film film)
        {
            FilmBll.Save(film);
            if (SignalR) { StartSignalR(film); }
        }

        private static async void StartSignalR(Film film)
        {
            HubConnection connectionSignalR;
            connectionSignalR = new HubConnectionBuilder().WithUrl("https://localhost:44355/MediaManagerHub").Build();
            connectionSignalR.Closed += async (error) =>
            {
                await connectionSignalR.StartAsync();
            };
            await connectionSignalR.StartAsync();
            await connectionSignalR.InvokeAsync("SendData", film);
        }
    }
}
