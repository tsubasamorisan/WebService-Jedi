using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationJedi.Models;
using WebApplicationJedi.ServiceReference;

namespace WebApplicationJedi.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                List<TournoiViewModel> list = new List<TournoiViewModel>();
                List<JediViewModel> part = new List<JediViewModel>();

                using (ServiceReference.ServiceClient service = new ServiceReference.ServiceClient())
                {
                    foreach (var t in service.getTournois())
                    {
                        list.Add(new TournoiViewModel(t));
                    }
                    foreach (var t in service.getJedis())
                    {
                        part.Add(new JediViewModel(t));
                    }
                }

                return View(new TournoiCollection(list, part));
            }
            else
            {
                return RedirectToAction("Login", "Account", "Home");
            }
        }

        // POST: Game/play
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(FormCollection collection)
        {
            TournoiWS ts = null;
            string nom = collection.Get(1);
            using (ServiceReference.ServiceClient service = new ServiceReference.ServiceClient())
            {
                TournoiWS tn = service.getTournois().Where(x => x.Nom == nom).First();
                ts = service.playTournoi(tn);
            }
            TournoiViewModel mod = new TournoiViewModel(ts);

            using (ServiceReference.ServiceClient service = new ServiceReference.ServiceClient())
            {
                int butin = service.getPoints(User.Identity.GetUserName());
                mod.Mise = Int32.Parse(collection.Get("Mise"));
                mod.Mise = (mod.Mise < 0 ? 0 : mod.Mise > butin ? butin : mod.Mise);
                mod.Jedi = collection.Get("Jedi");
                bool gagne = mod.Jedi == mod.Matches.list.Where(x => x.Phase == EPhaseTournoiWS.Finale).First().JediVainqueur.Nom;
                mod.Gain = (gagne ? mod.Mise * 2 + 1 : 0);
                var userId = User.Identity.GetUserId();

                mod.Total = service.getPoints(User.Identity.GetUserName());
                mod.Total += (gagne ? mod.Gain : -mod.Mise);
                mod.Total = mod.Total < 0 ? 0 : mod.Total;
                service.setPoints(User.Identity.GetUserName(), mod.Total);
            }

            return View("Details", mod);
        }

        public ActionResult TournoiSelected(string tournoi)
        {
            JediCollection jedis = null;
            MatchCollection matches = null;
            using (ServiceReference.ServiceClient service = new ServiceReference.ServiceClient())
            {
                List<MatchViewModel> tmpList = new List<MatchViewModel>();
                List<JediViewModel> tmpList2 = new List<JediViewModel>();
                foreach (MatchWS mat in ((TournoiWS)service.getTournois().Select(x => x.Nom == tournoi)).Matches)
                {
                    tmpList.Add(new MatchViewModel(mat));
                    if (mat.Jedi1 != null)
                        tmpList2.Add(new JediViewModel(mat.Jedi1));
                    if (mat.Jedi2 != null)
                        tmpList2.Add(new JediViewModel(mat.Jedi2));
                }
                matches = new MatchCollection(tmpList);
                jedis = new JediCollection(tmpList2);
            }
            return Json(jedis, JsonRequestBehavior.AllowGet);
        }

        // GET: Game/Details/5
        [ValidateAntiForgeryToken]
        public ActionResult Details(TournoiViewModel tws)
        {
            return View(tws);
        }

        // GET: Game/Create
        private ActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        [HttpPost]
        private ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Edit/5
        private ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Game/Edit/5
        [HttpPost]
        private ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Game/Delete/5
        private ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Game/Delete/5
        [HttpPost]
        private ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
