using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CRMnAppMVC.Models;

namespace CRMnAppMVC
{
    [MetadataType(typeof(Activitati_Curente_Metadata))]
    public partial class Activitati_Curente : IActivitate_AddVw
    {
        public Activitati_Curente()
        {
            Data_Scadenta = GlobaleCRM.DataDeAzi;
            Data_Alocare = GlobaleCRM.DataDeAzi;
            Data_Intro = GlobaleCRM.DataDeAzi;
            Data_Modif = DateTime.Now;
            Id_User = "100";
            Activitate_Activa = true;
            Stare_Activitate = "Programata";
            Cod_Stare_Activitate = 1;
        }

    }
   
    public partial class Activitati_Curente_Metadata
    {
        [Range(1, 5)]
        public Nullable<byte> Prioritate_Activitate { get; set; }
        [Range(8,20)]
        public Nullable<byte> Ora_Activitate { get; set; }
    }
}