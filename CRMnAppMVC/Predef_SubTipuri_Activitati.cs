//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRMnAppMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Predef_SubTipuri_Activitati
    {
        public int Id_SubAct { get; set; }
        public Nullable<int> Id_Act { get; set; }
        public string Nume_SubAct { get; set; }
    
        public virtual Predef_Tipuri_Activitati Predef_Tipuri_Activitati { get; set; }
    }
}
