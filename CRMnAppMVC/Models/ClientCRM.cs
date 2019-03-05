using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRMnAppMVC.Models
{
    public class ClientCRM : VwDashboardClient // aduce date despre un Client tip CRM deriva  din SQL View VwDashboardClient -din clasa ei model
    {
        public static string GetFieldValue(string fieldName, int? id, string className)
        {
            string fieldValue = null;

            if (className == "Clienti_Profil")
            {
                CRM_DBHP_Context db = new CRM_DBHP_Context();
                Clienti_Profil client = db.Clienti_Profil.First(c => c.ID_PRE_Client == id);

                if (fieldName == "Nume_Client")
                {
                    fieldValue = client.Nume_Client;
                };
            }

            return fieldValue;
        }

        public static string GetFieldValue(string fieldName, int? id)
        {
            // classname=VwDashboardClient
            string fieldValue = null;

            CRM_DBHP_Context db = new CRM_DBHP_Context();
            VwDashboardClient client = db.VwDashboardClients.First(c => c.ID_PRE_Client_Profil == id);

            if (fieldName == "Nume_Client")
            {
                fieldValue = client.Nume_Client;
            };

            if (fieldName == "Tip_STADIU_DISCUTIE")
            {
                if(client.ID_PRE_Client_Interlocutor !=null && client.Tip_STADIU_DISCUTIE!=null)
                fieldValue = client.Tip_STADIU_DISCUTIE;
                else fieldValue="";
            };

            return fieldValue;
        }
    }
}