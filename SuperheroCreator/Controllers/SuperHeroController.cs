using SuperheroCreator.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SuperheroCreator.Controllers
{
    //https://localhost:44338/SuperHero/Index
    public class SuperHeroController : Controller
    {
        ApplicationDbContext db;
        public SuperHeroController()
        {
            db = new ApplicationDbContext();
        }

        // GET: SuperHero
        public ActionResult Index()
        {
            return View(db.SuperHeroes.ToList());
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero superhero = db.SuperHeroes.Find(Id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            return View(superhero);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: SuperHero/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.SuperHeroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero superhero = db.SuperHeroes.Find(Id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            return View(superhero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,heroName,alterEgo,primaryAbility,secondaryAbility,catchphrase")] Superhero superhero)
        {
            if (ModelState.IsValid)
            {
                // TODO: Add update logic here
                db.Entry(superhero).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
                return View(superhero);
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Superhero superhero = db.SuperHeroes.Find(Id);
            if (superhero == null)
            {
                return HttpNotFound();
            }
            return View(superhero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            try
            {
                // TODO: Add delete logic here
                Superhero superhero = db.SuperHeroes.Find(Id);
                db.SuperHeroes.Remove(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
