using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Web;
using CRMnAppMVC;

namespace CRMnAppMVC.Models
{
    public enum TipActiuneCRM
    {
        AP, // Activitati Prospectare
        AO, // Activitati Ofertare
        AC, // Activitati Curente
        Dlg // Activitati Delegate
    }
    public class ActiuneCRM: Ac_GridFields
    {
        [Key]
        public long? Id { get; set; }
        [DisplayName("Actiune /Pas Urmator")]
        public TipActiuneCRM TipActiune { get; set; }
        [DisplayName("Nume Actiune")]
        public string NumeActiune { get; set; }
        [DisplayName("Subiect Actiune")]
        public string SubiectActiune { get; set; }
        [DisplayName("Prioritate")]
        public int? PrioritateActiune { get; set; }
        [DisplayName("Ora")]
        public int? OraActiune { get; set; }
        [DisplayName("Timp")]
        public int? DurataActiune { get; set; }
        [DisplayName("Comentarii")]
        public string ComentariuActiune { get; set; }
        [DisplayName("Stare")]
        public string MesajActiune{ get; set; }

        public ActiuneCRM ConversieActivitateInActiune(Activitati_Curente a, string mesajActiune=null)
        {
            ActiuneCRM actiune = new ActiuneCRM()
            {
                Id = a.Id,
                NumeActiune = string.Concat(a.Nume_Activitate ?? Ac_GridFields.NoDataText, "--", a.Detalii_Tip_Activitate ?? ""),
                SubiectActiune = a.Subiect_Activitate ?? Ac_GridFields.NoDataText,
                PrioritateActiune = a.Prioritate_Activitate ?? 1,
                OraActiune = a.Ora_Activitate,
                DurataActiune = a.Durata_Activitate,
                ComentariuActiune = a.Comentariu_Activitate,
                MesajActiune = mesajActiune ?? "Actiune " + a.Stare_Activitate
            };
            
            return actiune;
        }

        public static List<ActiuneCRM> ConversieActivitatiInActiuni(List<Activitati_Curente> listaActivitati, string mesajText = null)
        {
            List<ActiuneCRM> listaActiuni = new List<ActiuneCRM>();
            ActiuneCRM actiune = new ActiuneCRM();
            foreach (var activitate in listaActivitati)
            {
                actiune = actiune.ConversieActivitateInActiune(activitate, mesajText);
                listaActiuni.Add(actiune);
            }
            return listaActiuni;
        }
    }
}