using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMnAppMVC
{
    interface IActivitate_AddVw
    {
         int Id { get; set; }
         string Nume_Activitate { get; set; }
         string Detalii_Tip_Activitate { get; set; }
         string Subiect_Activitate { get; set; }
         System.DateTime Data_Scadenta { get; set; }
         Nullable<byte> Ora_Activitate { get; set; }
         Nullable<byte> Durata_Activitate { get; set; }
         Nullable<decimal> Grad_Realizare { get; set; }
         Nullable<byte> Prioritate_Activitate { get; set; }
         string Stare_Activitate { get; set; }
         string Comentariu_Activitate { get; set; }
    }
}
