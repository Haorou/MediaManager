using MediaManager.Bll;
using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaManager.Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxNom.Text))
                {
                    labelInformation.Text = "Le nom du film n'est pas renseigné";
                }
                else if (string.IsNullOrEmpty(textBoxDuree.Text))
                {
                    labelInformation.Text = "La durée du film n'est pas renseignée";
                }
                else if (string.IsNullOrEmpty(richTextSynopsis.Text))
                {
                    labelInformation.Text = "Le synopsis du film n'est pas renseigné";
                }
                else if (string.IsNullOrEmpty(dateTimePickerSortie.Text))
                {
                    labelInformation.Text = "La date du film n'est pas renseigné";
                }
                else
                {
                    labelInformation.Text = "Enregistrement en cours";
                    var film = new Film
                    {
                        Nom = textBoxNom.Text,
                        DureeEnMinute = Convert.ToInt32(textBoxDuree.Text),
                        DateSortie = dateTimePickerSortie.Value,
                        Synopsis = richTextSynopsis.Text
                    };
                    FilmBll.Save(film);
                    labelInformation.Text = "Enregistrement terminé";

                }
            }
            catch (Exception ex)
            {
                labelInformation.Text = $"Erreur : {ex.Message}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
