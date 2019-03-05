using CRMnAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace CRMnAppMVC.Controllers
{
    public class OperatiuniController : Controller
    {
        // GET: Operatiuni
        public ActionResult TabelOperatiuni(int? page, string searchName, string searchPers, string searchEmail)
        {
            CRM_DBHP_Context db = new CRM_DBHP_Context();
            var qResult = (from cp in db.Clienti_Profil
                           join cc in db.Clienti_Contact on cp.ID_PRE_Client equals cc.ID_PRE_Client
                           select new ClientiGrid
                           {
                               ID_PRE_Client = cp.ID_PRE_Client,
                               Nume_Client = cp.Nume_Client,
                               Tara = cp.Tara,
                               Domeniu = cp.Domeniu,
                               Email = cc.Email,
                               Telefon = cc.Telefon,
                               Persoana_Decizie = cc.Persoana_Decizie,
                               Data_Intro = cp.Data_Intro
                           });
            var filterResult = qResult.Where(r => (r.Nume_Client.StartsWith(searchName) || r.Nume_Client.Contains(searchName) || searchName == null)
            && (r.Persoana_Decizie.StartsWith(searchPers) || r.Persoana_Decizie.Contains(searchPers) || searchPers == null)
            && (r.Email.StartsWith(searchEmail) || r.Email.Contains(searchEmail) || searchEmail == null));

            return View(filterResult.ToList().ToPagedList(page ?? 1, 10));
        }

        public ActionResult DashboardClient(int? id)
        {
            CRM_DBHP_Context dbVw = new CRM_DBHP_Context();

            IEnumerable<VwDashboardClient> dashboardClientSet = dbVw.VwDashboardClients.Where(c => c.ID_PRE_Client_Profil == id).ToList();
            return View(dashboardClientSet);
        }

        [HttpGet]
        public ActionResult EditProfil(int id)
        {
            CRM_DBHP_Context db = new CRM_DBHP_Context();
            Clienti_Profil clientProfil = db.Clienti_Profil.Single(c => c.ID_PRE_Client == id);
            
            return View(clientProfil);
        }

        [HttpPost]
        [ActionName("EditProfil")]
        public ActionResult EditProfilSave(int id, string Tip_Client_PF_PJ, string Nume_Client, string Cod_Client, string Tara,
            string Domeniu, string Cod_Domeniu, decimal? CA_Ultimul_An, int? Nr_Angajati, string Sursa_Info_Client, string Sursa_Info_Client_Alt, string ID_USER)
        {
            CRM_DBHP_Context dbSp = new CRM_DBHP_Context();
            if (ModelState.IsValid)
            {
                dbSp.spUpdateClienti_Profil(id, Tip_Client_PF_PJ, Nume_Client, Cod_Client, Tara,
                Domeniu, Cod_Domeniu, (int)CA_Ultimul_An, Nr_Angajati, Sursa_Info_Client, Sursa_Info_Client_Alt, ID_USER, DateTime.Now);

                return RedirectToAction("DashboardClient", new { id = id });
            }
            else return View();
        }

        [HttpGet]
        public ActionResult AdaugaProfil() /*Create_Profil_Method*/
        {
             return View();
        }

        [HttpPost]
        [ActionName("AdaugaProfil")]
        public ActionResult AdaugaProfilSave( string Tip_Client_PF_PJ, string Nume_Client, string Cod_Client, string Tara, string Domeniu,
        string Cod_Domeniu, decimal? CA_Ultimul_An, int? Nr_Angajati, string Sursa_Info_Client, string Sursa_Info_Client_Alt, 
        string ID_USER, DateTime? Data_Intro, string Data_Modif)
        {
            CRM_DBHP_Context dbSp = new CRM_DBHP_Context();
            if (ModelState.IsValid)
            {
                dbSp.spAddClienti_Profil( Tip_Client_PF_PJ, Nume_Client, Cod_Client, Tara, Domeniu, Cod_Domeniu, (int)CA_Ultimul_An,
                Nr_Angajati, Sursa_Info_Client, Sursa_Info_Client_Alt, ID_USER, DateTime.Now, DateTime.Now);

                return RedirectToAction("TabelOperatiuni");
            }
            else return View();
        }

        [HttpGet]
        public ActionResult EditContact(int id)
        {
            CRM_DBHP_Context db = new CRM_DBHP_Context();
            Clienti_Contact clientContact = db.Clienti_Contact.Single(c => c.ID_PRE_Client == id);
            
           return View(clientContact);
        }

        [HttpPost]
        [ActionName("EditContact")]
        public ActionResult EditContactSave(int id, string Persoana_Decizie, string Telefon, string Regiune_Reper, 
            string Adresa_Text, string Cod_Postal, string Email, string Web_Site, string Adresa_Numar, string Adresa_Strada, 
            string Adresa_Oras, string Adresa_Unitate_Regionala, string Adresa_SubUnitate_Regionala, string Persoana_Decizie_Nume, 
            string Persoana_Decizie_Prenume, string Persoana_Decizie_Nume_Alt, string Persoana_Decizie_Prenume_Alt, string Persoana_Decizie_Sex, 
            string Persoana_Decizie_Functie, string Telefon_Alt, string Email_Alt, string ID_USER,  DateTime? Data_Modif)
        {
            CRM_DBHP_Context dbSp = new CRM_DBHP_Context();
            if (ModelState.IsValid)
            {
                dbSp.spUpdateClienti_Contact(id, Persoana_Decizie, Telefon, Regiune_Reper, Adresa_Text, Cod_Postal, Email, Web_Site, 
                    Adresa_Numar, Adresa_Strada, Adresa_Oras, Adresa_Unitate_Regionala, Adresa_SubUnitate_Regionala, Persoana_Decizie_Nume, 
                    Persoana_Decizie_Prenume, Persoana_Decizie_Nume_Alt, Persoana_Decizie_Prenume_Alt, Persoana_Decizie_Sex, Persoana_Decizie_Functie, 
                    Telefon_Alt, Email_Alt, ID_USER, Data_Modif);

                return RedirectToAction("DashboardClient",new {id=id});
            }
            else return View();
        }

        [HttpGet]
        public ActionResult EditInterlocutor(int id)
        {
            CRM_DBHP_Context db = new CRM_DBHP_Context();
            Clienti_Interlocutor clientInterlocutor =
                db.Clienti_Interlocutor.First(c => c.ID_PRE_Client == id);

            return View(clientInterlocutor);
        }

        //public ActionResult DetaliiProfil(int id)
        //{
        //    CRM_DBHP_Context db = new CRM_DBHP_Context();
        //    Clienti_Profil clientProfil = db.Clienti_Profil.Single(c => c.ID_PRE_Client == id);

        //    return View(clientProfil);
        //}

    }
}