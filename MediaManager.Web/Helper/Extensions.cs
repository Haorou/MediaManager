using MediaManager.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager.Web.Helper
{
    public static class Extensions
    {
        public static string ToHtml(this Film element)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<div class='row'>");
            sb.Append("<div class='col-lg-12>'");
            sb.Append("<div class='row'>");
            sb.Append("<div class='col-lg-6'>");
            sb.AppendFormat("<h1>{0}</h1>",element.Nom);
            sb.AppendFormat("<h5>Date de sortie :{0} Durée : {1}</h5>", element.DateSortie?.Year, element.DureeEnMinute);
            sb.Append("</div>");
            sb.Append("<div class='col-lg-6'>");
            sb.Append("<h5>Synopsis</h5>");
            sb.AppendFormat("<span>{0}</span>", element.Synopsis);
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("</div>");
            sb.Append("<hr/>");
            return sb.ToString();
        }
    }
}
