using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMnAppMVC.Models
{
    public class CrmPonderiProspecte
    {
        public int IdCategory { get; set; }
        public string Category { get; set; }
        public int TotalItems { get; set; }

        public CrmPonderiProspecte(int idCategory, string category, int totalItems)
        {
            IdCategory = idCategory;
            Category = category;
            TotalItems = totalItems;
        }

        public static Dictionary<int, CrmPonderiProspecte> CrmPonderiProspectare()
        {
            var ponderiProspectare = new Dictionary<int, CrmPonderiProspecte>()
            {
            { 1, new CrmPonderiProspecte ( 1, "Total",1000) },
            { 2, new CrmPonderiProspecte ( 2, "Contact",400) },
            { 3, new CrmPonderiProspecte ( 3, "Prospect",300) },
            { 4, new CrmPonderiProspecte ( 4, "Interloc",200) },
            { 5, new CrmPonderiProspecte ( 5, "Client",100) },
            };
        return ponderiProspectare;
        }
        public static int CrmTotalProspecte()// returneaza nr total de clienti prospectati
        {
            int totalProspecte=1000;

            return totalProspecte;
        }

        public static int CrmCategoryLines(string category) // returneaza nr de linii chart -- la 50% --returnneaza 10 linii
        {
            int itemLines = 0;
            int totalProspecte = CrmTotalProspecte();
            var ponderiProspectare = CrmPonderiProspectare();
            CrmPonderiProspecte item = null;

            foreach (KeyValuePair<int, CrmPonderiProspecte> kvpItem in ponderiProspectare)
            {
                item = kvpItem.Value;
                if (item.Category == category)
                {
                    itemLines = (int)((20 * item.TotalItems / totalProspecte));
                }
            }
            return itemLines;
        }

    }
}