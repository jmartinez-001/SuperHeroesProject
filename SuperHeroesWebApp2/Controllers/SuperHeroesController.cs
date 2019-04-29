using SuperHeroesWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroesWebApp2.Controllers
{
    public class SuperHeroesController : Controller
    {
        ApplicationDbContext context;

        public SuperHeroesController()
        {
            context = new ApplicationDbContext();
        }
        // GET: SuperHeroes
        public ActionResult Index()
        {
            SuperHero superhero = new SuperHero();
            return View(superhero);
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHeroes/Create
        [HttpPost]
        public ActionResult Create(SuperHero superHero)
        {
            try
            {
                // TODO: Add insert logic here
                context.SuperHeroes.Add(superHero);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHero superHero = new SuperHero();
            return View(superHero);
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superhero)
        {
            try
            {
                // TODO: Add update logic here

                SuperHero editSuperHero = context.SuperHeroes.Where(s => s.Id == id).FirstOrDefault();
                editSuperHero.Name = superhero.Name;
                editSuperHero.AlterEgo = superhero.AlterEgo;
                editSuperHero.PrimaryAbility = superhero.PrimaryAbility;
                editSuperHero.SecondaryAbility = superhero.SecondaryAbility;
                editSuperHero.CatchPhrase = superhero.CatchPhrase;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHero super)
        {
            try
            {
                // TODO: Add delete logic here
                context.SuperHeroes.Remove(context.SuperHeroes.Where(h => h.Id == super.Id).FirstOrDefault());
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
