﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CRM_DBHP_Context : DbContext
    {
        public CRM_DBHP_Context()
            : base("name=CRM_DBHP_Context")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Audit_CRUD> Audit_CRUD { get; set; }
        public virtual DbSet<Clienti_Contact> Clienti_Contact { get; set; }
        public virtual DbSet<Clienti_Interlocutor> Clienti_Interlocutor { get; set; }
        public virtual DbSet<Clienti_Profil> Clienti_Profil { get; set; }
        public virtual DbSet<VwDashboardClient> VwDashboardClients { get; set; }
    
        public virtual int spAddClienti_Contact(Nullable<int> iDparam, string persoana_Decizie, string telefon, string regiune_Reper, string adresa_Text, string cod_Postal, string email, string web_Site, string adresa_Numar, string adresa_Strada, string adresa_Oras, string adresa_Unitate_Regionala, string adresa_SubUnitate_Regionala, string persoana_Decizie_Numenvar, string persoana_Decizie_Prenume, string persoana_Decizie_Nume_Alt, string persoana_Decizie_Prenume_Alt, string persoana_Decizie_Sex, string persoana_Decizie_Functie, string telefon_Alt, string email_Alt, string iD_USER, Nullable<System.DateTime> data_Intro, Nullable<System.DateTime> data_Modif)
        {
            var iDparamParameter = iDparam.HasValue ?
                new ObjectParameter("IDparam", iDparam) :
                new ObjectParameter("IDparam", typeof(int));
    
            var persoana_DecizieParameter = persoana_Decizie != null ?
                new ObjectParameter("Persoana_Decizie", persoana_Decizie) :
                new ObjectParameter("Persoana_Decizie", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var regiune_ReperParameter = regiune_Reper != null ?
                new ObjectParameter("Regiune_Reper", regiune_Reper) :
                new ObjectParameter("Regiune_Reper", typeof(string));
    
            var adresa_TextParameter = adresa_Text != null ?
                new ObjectParameter("Adresa_Text", adresa_Text) :
                new ObjectParameter("Adresa_Text", typeof(string));
    
            var cod_PostalParameter = cod_Postal != null ?
                new ObjectParameter("Cod_Postal", cod_Postal) :
                new ObjectParameter("Cod_Postal", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var web_SiteParameter = web_Site != null ?
                new ObjectParameter("Web_Site", web_Site) :
                new ObjectParameter("Web_Site", typeof(string));
    
            var adresa_NumarParameter = adresa_Numar != null ?
                new ObjectParameter("Adresa_Numar", adresa_Numar) :
                new ObjectParameter("Adresa_Numar", typeof(string));
    
            var adresa_StradaParameter = adresa_Strada != null ?
                new ObjectParameter("Adresa_Strada", adresa_Strada) :
                new ObjectParameter("Adresa_Strada", typeof(string));
    
            var adresa_OrasParameter = adresa_Oras != null ?
                new ObjectParameter("Adresa_Oras", adresa_Oras) :
                new ObjectParameter("Adresa_Oras", typeof(string));
    
            var adresa_Unitate_RegionalaParameter = adresa_Unitate_Regionala != null ?
                new ObjectParameter("Adresa_Unitate_Regionala", adresa_Unitate_Regionala) :
                new ObjectParameter("Adresa_Unitate_Regionala", typeof(string));
    
            var adresa_SubUnitate_RegionalaParameter = adresa_SubUnitate_Regionala != null ?
                new ObjectParameter("Adresa_SubUnitate_Regionala", adresa_SubUnitate_Regionala) :
                new ObjectParameter("Adresa_SubUnitate_Regionala", typeof(string));
    
            var persoana_Decizie_NumenvarParameter = persoana_Decizie_Numenvar != null ?
                new ObjectParameter("Persoana_Decizie_Numenvar", persoana_Decizie_Numenvar) :
                new ObjectParameter("Persoana_Decizie_Numenvar", typeof(string));
    
            var persoana_Decizie_PrenumeParameter = persoana_Decizie_Prenume != null ?
                new ObjectParameter("Persoana_Decizie_Prenume", persoana_Decizie_Prenume) :
                new ObjectParameter("Persoana_Decizie_Prenume", typeof(string));
    
            var persoana_Decizie_Nume_AltParameter = persoana_Decizie_Nume_Alt != null ?
                new ObjectParameter("Persoana_Decizie_Nume_Alt", persoana_Decizie_Nume_Alt) :
                new ObjectParameter("Persoana_Decizie_Nume_Alt", typeof(string));
    
            var persoana_Decizie_Prenume_AltParameter = persoana_Decizie_Prenume_Alt != null ?
                new ObjectParameter("Persoana_Decizie_Prenume_Alt", persoana_Decizie_Prenume_Alt) :
                new ObjectParameter("Persoana_Decizie_Prenume_Alt", typeof(string));
    
            var persoana_Decizie_SexParameter = persoana_Decizie_Sex != null ?
                new ObjectParameter("Persoana_Decizie_Sex", persoana_Decizie_Sex) :
                new ObjectParameter("Persoana_Decizie_Sex", typeof(string));
    
            var persoana_Decizie_FunctieParameter = persoana_Decizie_Functie != null ?
                new ObjectParameter("Persoana_Decizie_Functie", persoana_Decizie_Functie) :
                new ObjectParameter("Persoana_Decizie_Functie", typeof(string));
    
            var telefon_AltParameter = telefon_Alt != null ?
                new ObjectParameter("Telefon_Alt", telefon_Alt) :
                new ObjectParameter("Telefon_Alt", typeof(string));
    
            var email_AltParameter = email_Alt != null ?
                new ObjectParameter("Email_Alt", email_Alt) :
                new ObjectParameter("Email_Alt", typeof(string));
    
            var iD_USERParameter = iD_USER != null ?
                new ObjectParameter("ID_USER", iD_USER) :
                new ObjectParameter("ID_USER", typeof(string));
    
            var data_IntroParameter = data_Intro.HasValue ?
                new ObjectParameter("Data_Intro", data_Intro) :
                new ObjectParameter("Data_Intro", typeof(System.DateTime));
    
            var data_ModifParameter = data_Modif.HasValue ?
                new ObjectParameter("Data_Modif", data_Modif) :
                new ObjectParameter("Data_Modif", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddClienti_Contact", iDparamParameter, persoana_DecizieParameter, telefonParameter, regiune_ReperParameter, adresa_TextParameter, cod_PostalParameter, emailParameter, web_SiteParameter, adresa_NumarParameter, adresa_StradaParameter, adresa_OrasParameter, adresa_Unitate_RegionalaParameter, adresa_SubUnitate_RegionalaParameter, persoana_Decizie_NumenvarParameter, persoana_Decizie_PrenumeParameter, persoana_Decizie_Nume_AltParameter, persoana_Decizie_Prenume_AltParameter, persoana_Decizie_SexParameter, persoana_Decizie_FunctieParameter, telefon_AltParameter, email_AltParameter, iD_USERParameter, data_IntroParameter, data_ModifParameter);
        }
    
        public virtual int spAddClienti_Interlocutor(Nullable<int> iD_PRE_Client, Nullable<System.DateTime> data_Discutie, string obs_Tipuri_Produse_Cautate, string obs_Furnizori_Actuali_Client, string obs_Dureri_Client, string obs_Alte_Observatii, Nullable<int> durata_Discutie_Minute, Nullable<int> iD_Discutie, string tip_Discutie, string tip_STADIU_DISCUTIE, string iD_USER, Nullable<System.DateTime> data_Intro, Nullable<System.DateTime> data_Modif)
        {
            var iD_PRE_ClientParameter = iD_PRE_Client.HasValue ?
                new ObjectParameter("ID_PRE_Client", iD_PRE_Client) :
                new ObjectParameter("ID_PRE_Client", typeof(int));
    
            var data_DiscutieParameter = data_Discutie.HasValue ?
                new ObjectParameter("Data_Discutie", data_Discutie) :
                new ObjectParameter("Data_Discutie", typeof(System.DateTime));
    
            var obs_Tipuri_Produse_CautateParameter = obs_Tipuri_Produse_Cautate != null ?
                new ObjectParameter("Obs_Tipuri_Produse_Cautate", obs_Tipuri_Produse_Cautate) :
                new ObjectParameter("Obs_Tipuri_Produse_Cautate", typeof(string));
    
            var obs_Furnizori_Actuali_ClientParameter = obs_Furnizori_Actuali_Client != null ?
                new ObjectParameter("Obs_Furnizori_Actuali_Client", obs_Furnizori_Actuali_Client) :
                new ObjectParameter("Obs_Furnizori_Actuali_Client", typeof(string));
    
            var obs_Dureri_ClientParameter = obs_Dureri_Client != null ?
                new ObjectParameter("Obs_Dureri_Client", obs_Dureri_Client) :
                new ObjectParameter("Obs_Dureri_Client", typeof(string));
    
            var obs_Alte_ObservatiiParameter = obs_Alte_Observatii != null ?
                new ObjectParameter("Obs_Alte_Observatii", obs_Alte_Observatii) :
                new ObjectParameter("Obs_Alte_Observatii", typeof(string));
    
            var durata_Discutie_MinuteParameter = durata_Discutie_Minute.HasValue ?
                new ObjectParameter("Durata_Discutie_Minute", durata_Discutie_Minute) :
                new ObjectParameter("Durata_Discutie_Minute", typeof(int));
    
            var iD_DiscutieParameter = iD_Discutie.HasValue ?
                new ObjectParameter("ID_Discutie", iD_Discutie) :
                new ObjectParameter("ID_Discutie", typeof(int));
    
            var tip_DiscutieParameter = tip_Discutie != null ?
                new ObjectParameter("Tip_Discutie", tip_Discutie) :
                new ObjectParameter("Tip_Discutie", typeof(string));
    
            var tip_STADIU_DISCUTIEParameter = tip_STADIU_DISCUTIE != null ?
                new ObjectParameter("Tip_STADIU_DISCUTIE", tip_STADIU_DISCUTIE) :
                new ObjectParameter("Tip_STADIU_DISCUTIE", typeof(string));
    
            var iD_USERParameter = iD_USER != null ?
                new ObjectParameter("ID_USER", iD_USER) :
                new ObjectParameter("ID_USER", typeof(string));
    
            var data_IntroParameter = data_Intro.HasValue ?
                new ObjectParameter("Data_Intro", data_Intro) :
                new ObjectParameter("Data_Intro", typeof(System.DateTime));
    
            var data_ModifParameter = data_Modif.HasValue ?
                new ObjectParameter("Data_Modif", data_Modif) :
                new ObjectParameter("Data_Modif", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddClienti_Interlocutor", iD_PRE_ClientParameter, data_DiscutieParameter, obs_Tipuri_Produse_CautateParameter, obs_Furnizori_Actuali_ClientParameter, obs_Dureri_ClientParameter, obs_Alte_ObservatiiParameter, durata_Discutie_MinuteParameter, iD_DiscutieParameter, tip_DiscutieParameter, tip_STADIU_DISCUTIEParameter, iD_USERParameter, data_IntroParameter, data_ModifParameter);
        }
    
        public virtual int spAddClienti_Profil(string tip_Client_PF_PJ, string nume_Client, string cod_Client, string tara, string domeniu, string cod_Domeniu, Nullable<int> cA_Ultimul_An, Nullable<int> nr_Angajati, string sursa_Info_Client, string sursa_Info_Client_Alt, string iD_USER, Nullable<System.DateTime> data_Intro, Nullable<System.DateTime> data_Modif)
        {
            var tip_Client_PF_PJParameter = tip_Client_PF_PJ != null ?
                new ObjectParameter("Tip_Client_PF_PJ", tip_Client_PF_PJ) :
                new ObjectParameter("Tip_Client_PF_PJ", typeof(string));
    
            var nume_ClientParameter = nume_Client != null ?
                new ObjectParameter("Nume_Client", nume_Client) :
                new ObjectParameter("Nume_Client", typeof(string));
    
            var cod_ClientParameter = cod_Client != null ?
                new ObjectParameter("Cod_Client", cod_Client) :
                new ObjectParameter("Cod_Client", typeof(string));
    
            var taraParameter = tara != null ?
                new ObjectParameter("Tara", tara) :
                new ObjectParameter("Tara", typeof(string));
    
            var domeniuParameter = domeniu != null ?
                new ObjectParameter("Domeniu", domeniu) :
                new ObjectParameter("Domeniu", typeof(string));
    
            var cod_DomeniuParameter = cod_Domeniu != null ?
                new ObjectParameter("Cod_Domeniu", cod_Domeniu) :
                new ObjectParameter("Cod_Domeniu", typeof(string));
    
            var cA_Ultimul_AnParameter = cA_Ultimul_An.HasValue ?
                new ObjectParameter("CA_Ultimul_An", cA_Ultimul_An) :
                new ObjectParameter("CA_Ultimul_An", typeof(int));
    
            var nr_AngajatiParameter = nr_Angajati.HasValue ?
                new ObjectParameter("Nr_Angajati", nr_Angajati) :
                new ObjectParameter("Nr_Angajati", typeof(int));
    
            var sursa_Info_ClientParameter = sursa_Info_Client != null ?
                new ObjectParameter("Sursa_Info_Client", sursa_Info_Client) :
                new ObjectParameter("Sursa_Info_Client", typeof(string));
    
            var sursa_Info_Client_AltParameter = sursa_Info_Client_Alt != null ?
                new ObjectParameter("Sursa_Info_Client_Alt", sursa_Info_Client_Alt) :
                new ObjectParameter("Sursa_Info_Client_Alt", typeof(string));
    
            var iD_USERParameter = iD_USER != null ?
                new ObjectParameter("ID_USER", iD_USER) :
                new ObjectParameter("ID_USER", typeof(string));
    
            var data_IntroParameter = data_Intro.HasValue ?
                new ObjectParameter("Data_Intro", data_Intro) :
                new ObjectParameter("Data_Intro", typeof(System.DateTime));
    
            var data_ModifParameter = data_Modif.HasValue ?
                new ObjectParameter("Data_Modif", data_Modif) :
                new ObjectParameter("Data_Modif", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddClienti_Profil", tip_Client_PF_PJParameter, nume_ClientParameter, cod_ClientParameter, taraParameter, domeniuParameter, cod_DomeniuParameter, cA_Ultimul_AnParameter, nr_AngajatiParameter, sursa_Info_ClientParameter, sursa_Info_Client_AltParameter, iD_USERParameter, data_IntroParameter, data_ModifParameter);
        }
    
        public virtual int spDeleteClientWithID(Nullable<int> iDparam)
        {
            var iDparamParameter = iDparam.HasValue ?
                new ObjectParameter("IDparam", iDparam) :
                new ObjectParameter("IDparam", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDeleteClientWithID", iDparamParameter);
        }
    
        public virtual int spUpdateClienti_Contact(Nullable<int> iDparam, string persoana_Decizie, string telefon, string regiune_Reper, string adresa_Text, string cod_Postal, string email, string web_Site, string adresa_Numar, string adresa_Strada, string adresa_Oras, string adresa_Unitate_Regionala, string adresa_SubUnitate_Regionala, string persoana_Decizie_Nume, string persoana_Decizie_Prenume, string persoana_Decizie_Nume_Alt, string persoana_Decizie_Prenume_Alt, string persoana_Decizie_Sex, string persoana_Decizie_Functie, string telefon_Alt, string email_Alt, string iD_USER, Nullable<System.DateTime> data_Modif)
        {
            var iDparamParameter = iDparam.HasValue ?
                new ObjectParameter("IDparam", iDparam) :
                new ObjectParameter("IDparam", typeof(int));
    
            var persoana_DecizieParameter = persoana_Decizie != null ?
                new ObjectParameter("Persoana_Decizie", persoana_Decizie) :
                new ObjectParameter("Persoana_Decizie", typeof(string));
    
            var telefonParameter = telefon != null ?
                new ObjectParameter("Telefon", telefon) :
                new ObjectParameter("Telefon", typeof(string));
    
            var regiune_ReperParameter = regiune_Reper != null ?
                new ObjectParameter("Regiune_Reper", regiune_Reper) :
                new ObjectParameter("Regiune_Reper", typeof(string));
    
            var adresa_TextParameter = adresa_Text != null ?
                new ObjectParameter("Adresa_Text", adresa_Text) :
                new ObjectParameter("Adresa_Text", typeof(string));
    
            var cod_PostalParameter = cod_Postal != null ?
                new ObjectParameter("Cod_Postal", cod_Postal) :
                new ObjectParameter("Cod_Postal", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var web_SiteParameter = web_Site != null ?
                new ObjectParameter("Web_Site", web_Site) :
                new ObjectParameter("Web_Site", typeof(string));
    
            var adresa_NumarParameter = adresa_Numar != null ?
                new ObjectParameter("Adresa_Numar", adresa_Numar) :
                new ObjectParameter("Adresa_Numar", typeof(string));
    
            var adresa_StradaParameter = adresa_Strada != null ?
                new ObjectParameter("Adresa_Strada", adresa_Strada) :
                new ObjectParameter("Adresa_Strada", typeof(string));
    
            var adresa_OrasParameter = adresa_Oras != null ?
                new ObjectParameter("Adresa_Oras", adresa_Oras) :
                new ObjectParameter("Adresa_Oras", typeof(string));
    
            var adresa_Unitate_RegionalaParameter = adresa_Unitate_Regionala != null ?
                new ObjectParameter("Adresa_Unitate_Regionala", adresa_Unitate_Regionala) :
                new ObjectParameter("Adresa_Unitate_Regionala", typeof(string));
    
            var adresa_SubUnitate_RegionalaParameter = adresa_SubUnitate_Regionala != null ?
                new ObjectParameter("Adresa_SubUnitate_Regionala", adresa_SubUnitate_Regionala) :
                new ObjectParameter("Adresa_SubUnitate_Regionala", typeof(string));
    
            var persoana_Decizie_NumeParameter = persoana_Decizie_Nume != null ?
                new ObjectParameter("Persoana_Decizie_Nume", persoana_Decizie_Nume) :
                new ObjectParameter("Persoana_Decizie_Nume", typeof(string));
    
            var persoana_Decizie_PrenumeParameter = persoana_Decizie_Prenume != null ?
                new ObjectParameter("Persoana_Decizie_Prenume", persoana_Decizie_Prenume) :
                new ObjectParameter("Persoana_Decizie_Prenume", typeof(string));
    
            var persoana_Decizie_Nume_AltParameter = persoana_Decizie_Nume_Alt != null ?
                new ObjectParameter("Persoana_Decizie_Nume_Alt", persoana_Decizie_Nume_Alt) :
                new ObjectParameter("Persoana_Decizie_Nume_Alt", typeof(string));
    
            var persoana_Decizie_Prenume_AltParameter = persoana_Decizie_Prenume_Alt != null ?
                new ObjectParameter("Persoana_Decizie_Prenume_Alt", persoana_Decizie_Prenume_Alt) :
                new ObjectParameter("Persoana_Decizie_Prenume_Alt", typeof(string));
    
            var persoana_Decizie_SexParameter = persoana_Decizie_Sex != null ?
                new ObjectParameter("Persoana_Decizie_Sex", persoana_Decizie_Sex) :
                new ObjectParameter("Persoana_Decizie_Sex", typeof(string));
    
            var persoana_Decizie_FunctieParameter = persoana_Decizie_Functie != null ?
                new ObjectParameter("Persoana_Decizie_Functie", persoana_Decizie_Functie) :
                new ObjectParameter("Persoana_Decizie_Functie", typeof(string));
    
            var telefon_AltParameter = telefon_Alt != null ?
                new ObjectParameter("Telefon_Alt", telefon_Alt) :
                new ObjectParameter("Telefon_Alt", typeof(string));
    
            var email_AltParameter = email_Alt != null ?
                new ObjectParameter("Email_Alt", email_Alt) :
                new ObjectParameter("Email_Alt", typeof(string));
    
            var iD_USERParameter = iD_USER != null ?
                new ObjectParameter("ID_USER", iD_USER) :
                new ObjectParameter("ID_USER", typeof(string));
    
            var data_ModifParameter = data_Modif.HasValue ?
                new ObjectParameter("Data_Modif", data_Modif) :
                new ObjectParameter("Data_Modif", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateClienti_Contact", iDparamParameter, persoana_DecizieParameter, telefonParameter, regiune_ReperParameter, adresa_TextParameter, cod_PostalParameter, emailParameter, web_SiteParameter, adresa_NumarParameter, adresa_StradaParameter, adresa_OrasParameter, adresa_Unitate_RegionalaParameter, adresa_SubUnitate_RegionalaParameter, persoana_Decizie_NumeParameter, persoana_Decizie_PrenumeParameter, persoana_Decizie_Nume_AltParameter, persoana_Decizie_Prenume_AltParameter, persoana_Decizie_SexParameter, persoana_Decizie_FunctieParameter, telefon_AltParameter, email_AltParameter, iD_USERParameter, data_ModifParameter);
        }
    
        public virtual int spUpdateClienti_Interlocutor(Nullable<int> iDparam, Nullable<System.DateTime> data_Discutie, string obs_Tipuri_Produse_Cautate, string obs_Furnizori_Actuali_Client, string obs_Dureri_Client, string obs_Alte_Observatii, Nullable<int> durata_Discutie_Minute, Nullable<int> iD_Discutie, string tip_Discutie, string tip_STADIU_DISCUTIE, string iD_USER, Nullable<System.DateTime> data_Modif)
        {
            var iDparamParameter = iDparam.HasValue ?
                new ObjectParameter("IDparam", iDparam) :
                new ObjectParameter("IDparam", typeof(int));
    
            var data_DiscutieParameter = data_Discutie.HasValue ?
                new ObjectParameter("Data_Discutie", data_Discutie) :
                new ObjectParameter("Data_Discutie", typeof(System.DateTime));
    
            var obs_Tipuri_Produse_CautateParameter = obs_Tipuri_Produse_Cautate != null ?
                new ObjectParameter("Obs_Tipuri_Produse_Cautate", obs_Tipuri_Produse_Cautate) :
                new ObjectParameter("Obs_Tipuri_Produse_Cautate", typeof(string));
    
            var obs_Furnizori_Actuali_ClientParameter = obs_Furnizori_Actuali_Client != null ?
                new ObjectParameter("Obs_Furnizori_Actuali_Client", obs_Furnizori_Actuali_Client) :
                new ObjectParameter("Obs_Furnizori_Actuali_Client", typeof(string));
    
            var obs_Dureri_ClientParameter = obs_Dureri_Client != null ?
                new ObjectParameter("Obs_Dureri_Client", obs_Dureri_Client) :
                new ObjectParameter("Obs_Dureri_Client", typeof(string));
    
            var obs_Alte_ObservatiiParameter = obs_Alte_Observatii != null ?
                new ObjectParameter("Obs_Alte_Observatii", obs_Alte_Observatii) :
                new ObjectParameter("Obs_Alte_Observatii", typeof(string));
    
            var durata_Discutie_MinuteParameter = durata_Discutie_Minute.HasValue ?
                new ObjectParameter("Durata_Discutie_Minute", durata_Discutie_Minute) :
                new ObjectParameter("Durata_Discutie_Minute", typeof(int));
    
            var iD_DiscutieParameter = iD_Discutie.HasValue ?
                new ObjectParameter("ID_Discutie", iD_Discutie) :
                new ObjectParameter("ID_Discutie", typeof(int));
    
            var tip_DiscutieParameter = tip_Discutie != null ?
                new ObjectParameter("Tip_Discutie", tip_Discutie) :
                new ObjectParameter("Tip_Discutie", typeof(string));
    
            var tip_STADIU_DISCUTIEParameter = tip_STADIU_DISCUTIE != null ?
                new ObjectParameter("Tip_STADIU_DISCUTIE", tip_STADIU_DISCUTIE) :
                new ObjectParameter("Tip_STADIU_DISCUTIE", typeof(string));
    
            var iD_USERParameter = iD_USER != null ?
                new ObjectParameter("ID_USER", iD_USER) :
                new ObjectParameter("ID_USER", typeof(string));
    
            var data_ModifParameter = data_Modif.HasValue ?
                new ObjectParameter("Data_Modif", data_Modif) :
                new ObjectParameter("Data_Modif", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateClienti_Interlocutor", iDparamParameter, data_DiscutieParameter, obs_Tipuri_Produse_CautateParameter, obs_Furnizori_Actuali_ClientParameter, obs_Dureri_ClientParameter, obs_Alte_ObservatiiParameter, durata_Discutie_MinuteParameter, iD_DiscutieParameter, tip_DiscutieParameter, tip_STADIU_DISCUTIEParameter, iD_USERParameter, data_ModifParameter);
        }
    
        public virtual int spUpdateClienti_Profil(Nullable<int> iDparam, string tip_Client_PF_PJ, string nume_Client, string cod_Client, string tara, string domeniu, string cod_Domeniu, Nullable<int> cA_Ultimul_An, Nullable<int> nr_Angajati, string sursa_Info_Client, string sursa_Info_Client_Alt, string iD_USER, Nullable<System.DateTime> data_Modif)
        {
            var iDparamParameter = iDparam.HasValue ?
                new ObjectParameter("IDparam", iDparam) :
                new ObjectParameter("IDparam", typeof(int));
    
            var tip_Client_PF_PJParameter = tip_Client_PF_PJ != null ?
                new ObjectParameter("Tip_Client_PF_PJ", tip_Client_PF_PJ) :
                new ObjectParameter("Tip_Client_PF_PJ", typeof(string));
    
            var nume_ClientParameter = nume_Client != null ?
                new ObjectParameter("Nume_Client", nume_Client) :
                new ObjectParameter("Nume_Client", typeof(string));
    
            var cod_ClientParameter = cod_Client != null ?
                new ObjectParameter("Cod_Client", cod_Client) :
                new ObjectParameter("Cod_Client", typeof(string));
    
            var taraParameter = tara != null ?
                new ObjectParameter("Tara", tara) :
                new ObjectParameter("Tara", typeof(string));
    
            var domeniuParameter = domeniu != null ?
                new ObjectParameter("Domeniu", domeniu) :
                new ObjectParameter("Domeniu", typeof(string));
    
            var cod_DomeniuParameter = cod_Domeniu != null ?
                new ObjectParameter("Cod_Domeniu", cod_Domeniu) :
                new ObjectParameter("Cod_Domeniu", typeof(string));
    
            var cA_Ultimul_AnParameter = cA_Ultimul_An.HasValue ?
                new ObjectParameter("CA_Ultimul_An", cA_Ultimul_An) :
                new ObjectParameter("CA_Ultimul_An", typeof(int));
    
            var nr_AngajatiParameter = nr_Angajati.HasValue ?
                new ObjectParameter("Nr_Angajati", nr_Angajati) :
                new ObjectParameter("Nr_Angajati", typeof(int));
    
            var sursa_Info_ClientParameter = sursa_Info_Client != null ?
                new ObjectParameter("Sursa_Info_Client", sursa_Info_Client) :
                new ObjectParameter("Sursa_Info_Client", typeof(string));
    
            var sursa_Info_Client_AltParameter = sursa_Info_Client_Alt != null ?
                new ObjectParameter("Sursa_Info_Client_Alt", sursa_Info_Client_Alt) :
                new ObjectParameter("Sursa_Info_Client_Alt", typeof(string));
    
            var iD_USERParameter = iD_USER != null ?
                new ObjectParameter("ID_USER", iD_USER) :
                new ObjectParameter("ID_USER", typeof(string));
    
            var data_ModifParameter = data_Modif.HasValue ?
                new ObjectParameter("Data_Modif", data_Modif) :
                new ObjectParameter("Data_Modif", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateClienti_Profil", iDparamParameter, tip_Client_PF_PJParameter, nume_ClientParameter, cod_ClientParameter, taraParameter, domeniuParameter, cod_DomeniuParameter, cA_Ultimul_AnParameter, nr_AngajatiParameter, sursa_Info_ClientParameter, sursa_Info_Client_AltParameter, iD_USERParameter, data_ModifParameter);
        }

        public System.Data.Entity.DbSet<CRMnAppMVC.Models.CrmPonderiProspecte> CrmPonderis { get; set; }

        public System.Data.Entity.DbSet<CRMnAppMVC.Models.ActiuneCRM> ActiuneCRMs { get; set; }
    }
}
