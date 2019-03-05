using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRMnAppMVC.Models
{
    public class ClientiGrid
    //creata prin preluare din Mode1- generat automat de EntityFramework
    // s-a creat ca reuniune Clienti_Profil cu Clienti_Contact -- are problema ca repeta cod --dar 
    // dar ClientiGrid s-a creat pentru testare LINQ  in Home/Index() -- se pot selecta campuri din ambele proprietati/ tabele
    //in locul acestei clase se putea face o interfata IClientiProfil 
    {
        [Key] 
        public int ID_PRE_Client { get; set; }
        public string Tip_Client_PF_PJ { get; set; }
        public string Nume_Client { get; set; }
        public string Cod_Client { get; set; }
        public string Tara { get; set; }
        public string Domeniu { get; set; }
        public string Cod_Domeniu { get; set; }
        public Nullable<decimal> CA_Ultimul_An { get; set; }
        public Nullable<int> Nr_Angajati { get; set; }
        public string Sursa_Info_Client { get; set; }
        public string Sursa_Info_Client_Alt { get; set; }
        public string ID_USER { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/ MM/ yyyy}")]
        public Nullable<System.DateTime> Data_Intro { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:dd/ MM/ yyyy}")]
        public Nullable<System.DateTime> Data_Modif { get; set; }

        public string Persoana_Decizie { get; set; }
        public string Telefon { get; set; }
        public string Regiune_Reper { get; set; }
        public string Adresa_Text { get; set; }
        public string Cod_Postal { get; set; }
        public string Email { get; set; }
        public string Web_Site { get; set; }
        public string Adresa_Numar { get; set; }
        public string Adresa_Strada { get; set; }
        public string Adresa_Oras { get; set; }
        public string Adresa_Unitate_Regionala { get; set; }
        public string Adresa_SubUnitate_Regionala { get; set; }
        public string Persoana_Decizie_Nume { get; set; }
        public string Persoana_Decizie_Prenume { get; set; }
        public string Persoana_Decizie_Nume_Alt { get; set; }
        public string Persoana_Decizie_Prenume_Alt { get; set; }
        public string Persoana_Decizie_Sex { get; set; }
        public string Persoana_Decizie_Functie { get; set; }
        public string Telefon_Alt { get; set; }
        public string Email_Alt { get; set; }
    }
}