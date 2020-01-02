using SuperheroCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroCreator.Controllers
{
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
            return View();
        }

        // GET: SuperHero/Details/5
        public ActionResult Details(int Id)
        {
            return View(Id);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: SuperHero/Create
        [HttpPost]
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
        public ActionResult Edit(int Id)
        {
            return View(Id);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int Id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                db.SuperHeroes.
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int Id)
        {
            return View();
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int Id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
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
