using CRMnAppMVC.Models;
using CRMnAppMVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRMnAppMVC.Controllers
{

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CRM_DBHP_Context db = new CRM_DBHP_Context();
            var result = (from cp in db.Clienti_Profil
                          join cc in db.Clienti_Contact on cp.ID_PRE_Client equals cc.ID_PRE_Client
                          select new ClientiGrid
                          {
                              Nume_Client = cp.Nume_Client,
                              Tara = cp.Tara,
                              Domeniu = cp.Domeniu,
                              CA_Ultimul_An = cp.CA_Ultimul_An,
                              Nr_Angajati = cp.Nr_Angajati
                          }).ToList();
            return View(result);
        }

        //public ActionResult Operatiuni()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        public ActionResult RapoarteProspecte()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ManualUtilizare()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}