using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMnAppMVC.Models
{
    public static class GlobaleCRM
    {
        public static readonly DateTime DataDeAzi = DateTime.Now.Date;
        public static readonly string[] sirStariDeReprogramat = { "Neprogramata", "Neefectuata"};
        public static readonly string[] sirStariActive = { "Programata", "Efectuata","Reprogramata","Amanata","Asteptare" };
        public static readonly string[] sirStariInactive = { "Suspendata", "Finalizata" };

        public static bool DateEgale(DateTime? d1, DateTime? d2)
        {
            bool result = false;

            DateTime _d1 = d1 ?? default(DateTime);
            DateTime _d2 = d2 ?? default(DateTime);

            if (_d1.Year == _d2.Year && _d1.Month == _d2.Month && _d1.Day == _d2.Day)
                result = true;

            return result;
        }

        public static readonly Dictionary<string, string> DexZileleSaptamanii
        = new Dictionary<string, string>
        {
        {"Monday","Luni"},
        {"Tuesday","Marti"},
        {"Wednesday","Miercuri"},
        {"Thursday","Joi"},
        {"Friday","Vineri"},
        {"Saturday","Sambata"},
        {"Sunday","Duminica"}
        };

        public static string ZileleSaptamanii(string dayName)
        {
            string result = null;
            if (DexZileleSaptamanii.TryGetValue(dayName, out result))
                return result;
            else
                return null;
        }

    }
}