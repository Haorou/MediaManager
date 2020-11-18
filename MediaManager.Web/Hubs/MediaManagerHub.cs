using MediaManager.Entity;
using MediaManager.Web.Helper;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaManager.Web.Hubs
{
    public class MediaManagerHub : Hub
    {
        public async Task SendData(Film film)
        {
            var data = film.ToHtml();
            await Clients.All.SendAsync("ReceiveData", data);
        }
    }
}
