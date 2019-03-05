using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRMnAppMVC.Models;
using CRMnAppMVC;
using System.Collections;
using CRMnAppMVC.Repositories;

namespace CRMnAppMVC.Controllers
{
    public class AgendaController : Controller
    {
        public ActionResult AgendaZilei()
        {
        // initializare variabile :Repositoty type-- Repo_Activitati, Repo_Prospectare
        CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();
        Repo_Activitati repoA = new Repo_Activitati(ctxt);
        Repo_Prospectare repoP = new Repo_Prospectare(ctxt);

        // Activitati ce NECESITA REPROGRAMARE !
        List<Activitati_Curente> activitatiDeReprogramat = new List<Activitati_Curente>();
        activitatiDeReprogramat = repoA.GetAllWhere(a => a.Data_Scadenta == GlobaleCRM.DataDeAzi && a.Activitate_Activa == true
        && GlobaleCRM.sirStariDeReprogramat.Contains(a.Stare_Activitate)).ToList();
        List<ActiuneCRM> actiuni_activitatiDeReprogramat = ActiuneCRM.ConversieActivitatiInActiuni(activitatiDeReprogramat, "Reprogrameaza!");

        // Activitati curente specifice Zilei Curente
        List<Activitati_Curente> activitatiCurente = new List<Activitati_Curente>();
        activitatiCurente = repoA.GetAllWhere(a => a.Data_Scadenta == GlobaleCRM.DataDeAzi && a.Activitate_Activa==true
        && GlobaleCRM.sirStariActive.Contains(a.Stare_Activitate)).ToList();
        List<ActiuneCRM> actiuni_activitatiCurente = ActiuneCRM.ConversieActivitatiInActiuni(activitatiCurente);

            // Prospecte ce NECESITA REPROGRAMARE !
            var prospecteDeReprogramat = (from a in ctxt.VwDashboardProspects
                                        where a.Stare_Pas == "Neefectuata" && a.Pas_Activ == true

                                        select new ActiuneCRM
                                        {
                                            Id = a.Id_Vw,
                                            TipActiune = TipActiuneCRM.AP,
                                            NumeActiune = a.Nume_Pas ?? Ac_GridFields.NoDataText,  
                                            SubiectActiune = a.Nume_Prospect ?? Ac_GridFields.NoDataText,
                                            PrioritateActiune = a.Prioritate_Pas ?? 1,
                                            OraActiune = a.Ora_Pas,
                                            DurataActiune = a.Durata_Pas,
                                            ComentariuActiune = a.Comentariu_Obstacol_Pas,
                                            MesajActiune = "Reprogrameaza!"
                                        }).ToList();
            // Activitati Prospectare Programate Curente
            var prospecteCurente = (from a in ctxt.VwDashboardProspects
                                    where a.Data_Scadenta_Pas == GlobaleCRM.DataDeAzi && a.Pas_Activ == true
                                          && a.Stare_Pas != "Finalizata" && a.Stare_Pas != "Suspendata" && a.Stare_Pas != "Nealocata"

                                    select new ActiuneCRM
                                    {
                                        Id = a.Id_Vw,
                                        TipActiune = TipActiuneCRM.AP,
                                        NumeActiune = a.Nume_Pas ?? Ac_GridFields.NoDataText,
                                        SubiectActiune = a.Nume_Prospect ?? Ac_GridFields.NoDataText,
                                        PrioritateActiune = a.Prioritate_Pas ?? 1,
                                        OraActiune = a.Ora_Pas,
                                        DurataActiune = a.Durata_Pas,
                                        ComentariuActiune = a.Comentariu_Obstacol_Pas,
                                        MesajActiune = "Actiune " + a.Stare_Pas
                                    }).ToList();

            // comasare colectii activitati cu prospecte
            var actiuniDeReprogramat = prospecteDeReprogramat.Union(actiuni_activitatiDeReprogramat);
            var actiuniCurente = actiuni_activitatiCurente.Union(prospecteCurente);
            // daca nu sunt actiuni neefectuate De Reprogramat  se randeaza actiunile curente ale zilei
            var actiunileZilei = actiuniDeReprogramat.Any() ? actiuniDeReprogramat : actiuniCurente;
            // se ordoneaza invers dupa prioritate
            var actiunileZileiOrdonate = actiunileZilei.OrderByDescending(a => a.PrioritateActiune);

            return View(actiunileZileiOrdonate);
        }

        public ActionResult AgendaArhivaActiuni()
        {
            CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();
            Repo_Activitati repoA = new Repo_Activitati(ctxt);

            // Activitati de arhiva --au stare"Finalizata" sau "Suspendata"
            List<Activitati_Curente> activitatiArhiva = new List<Activitati_Curente>();
            activitatiArhiva = repoA.GetAllWhere(a => GlobaleCRM.sirStariInactive.Contains(a.Stare_Activitate)).ToList();
            List<ActiuneCRM> actiuni_activitatiArhiva = ActiuneCRM.ConversieActivitatiInActiuni(activitatiArhiva);

            var actiuniArhivaOrdonate = actiuni_activitatiArhiva.OrderByDescending(a => a.PrioritateActiune);

            return View(actiuniArhivaOrdonate);
        }


        public ActionResult AgendaIntrateNoi()
        {
            CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();
            var actiuniNoi = (from a in ctxt.Activitati_Curente
                              orderby a.Prioritate_Activitate descending
                              where a.Data_Alocare.Year == DateTime.Now.Year && a.Data_Alocare.Month == DateTime.Now.Month
                                  && a.Data_Alocare.Day == DateTime.Now.Day
                              select new ActiuneCRM
                              {
                                  Id = a.Id,
                                  TipActiune = TipActiuneCRM.AC,
                                  NumeActiune = a.Nume_Activitate,
                                  SubiectActiune = a.Subiect_Activitate,
                                  PrioritateActiune = a.Prioritate_Activitate,
                                  OraActiune = a.Ora_Activitate,
                                  DurataActiune = a.Durata_Activitate,
                                  ComentariuActiune = a.Comentariu_Activitate,
                                  MesajActiune = "Actiune " + a.Stare_Activitate
                              }).ToList();

            return View(actiuniNoi);
        }


        [HttpGet]
        public ActionResult AdaugaActivitate()
        {
            CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();
            ViewBag.Nume_Activitate = new SelectList(ctxt.Predef_Tipuri_Activitati, "Nume_Act", "Nume_Act");
            ViewBag.Durata_Activitate = new SelectList(ctxt.Predef_Durate_Activitati, "Durata_Activitate", "Durata_Activitate");
            return View(new Activitati_Curente());
        }

        public ActionResult GetSubActivitatiPartVw(string numeActivitate)
        {
            CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();
            int? idActivitateSelectata = ctxt.Predef_Tipuri_Activitati.First(a => a.Nume_Act == numeActivitate).Id_Act;

            List<Predef_SubTipuri_Activitati> listaSubActivitati = ctxt.Predef_SubTipuri_Activitati.
            Where(a => a.Id_Act == idActivitateSelectata).ToList();
            ViewBag.Detalii_Tip_Activitate = new SelectList(listaSubActivitati, "Nume_SubAct", "Nume_SubAct");
     
            return PartialView("_PartVwGetSubActivitati", listaSubActivitati);
        }


        [HttpPost]
        [ActionName("AdaugaActivitate")]
        public ActionResult AdaugaActivitateSave(Activitati_Curente formModel)
        {
            CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();
            //Activitati_Curente activitate = new Activitati_Curente();
            //UpdateModel<IActivitate_AddVw>(activitate);

            if (ModelState.IsValid)
            {
                ctxt.Activitati_Curente.Add(formModel);
                ctxt.SaveChanges();

                return RedirectToAction("AgendaZilei");
            }
            else return View(new Activitati_Curente());
        }

        [HttpGet]
        public ActionResult EditeazaActiune(int? id)
        {
            string panel = Request.QueryString["panel"];

            if (panel == TipActiuneCRM.AC.ToString())
            {
                CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();

                var actiuneCurenta = ctxt.Activitati_Curente.First(c => c.Id == id);
                return View(actiuneCurenta);
            }
            return View();
        }

        [HttpPost]
        [ActionName("EditeazaActiune")]
        public ActionResult EditeazaActiuneSave(int id, DateTime Data_Scadenta,
            byte? Ora_Activitate, byte? Durata_Activitate, string Id_User)
        {
            CRM_Prospectare_Context ctxt = new CRM_Prospectare_Context();
      
            string userId = Request.Url.Segments[1].Substring(0,3); // in convetia de URL = userID/controller/action
              // panel contine tipul de actiune AC-actiune curenta --APr-Actiune Prospectare

            if (ModelState.IsValid)
            {
                ctxt.spEditeazaDataScadentaActivitate(id, Data_Scadenta, Ora_Activitate, Durata_Activitate, userId);

                return RedirectToAction("AgendaZilei");
            }
            else return View();

        }




    }

}