using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WandaPlusTv.Application.Contracts;
using WandaPlusTv.Domain;

namespace WandaPlusTv.WebAdmin.Controllers
{
    public class GenreController : Controller
    {
        private IAdministrationLogic logic;
        public GenreController(IAdministrationLogic administrationLogic)
        {
            logic = administrationLogic;
        }
        // GET: Genre
        public ActionResult Index()
        {
            List<Genre> model = new List<Genre>();
            model = logic.UnitOfWork.Genres.GetAll();
            return View(model);
        }

        // GET: Genre/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: Genre/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {            
            try
            {
                if(ModelState.IsValid)
                {
                    Genre genre = new Genre { Name =  collection["Name"]};
                    logic.UnitOfWork.Genres.Create(genre);
                }
                else
                {
                    return View(collection);
                }
                
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(collection);
            }
        }

        // GET: Genre/Edit/5
        public ActionResult Edit(int id)
        {
            Genre model = logic.UnitOfWork.Genres.Get(id);
            return View(model);
        }

        // POST: Genre/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                Genre model = logic.UnitOfWork.Genres.Get(id);
                model.Name = collection["Name"].ToString();
                logic.UnitOfWork.Genres.Update(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                Genre genre = new Genre { Id = id, Name = collection["Name"] };
                return View(genre);
            }
        }

        // GET: Genre/Delete/5
        public ActionResult Delete(int id)
        {
            Genre model = logic.UnitOfWork.Genres.Get(id);
            return View(model);
        }

        // POST: Genre/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Genre genreToDelete = logic.UnitOfWork.Genres.Get(id);
                logic.UnitOfWork.Genres.Delete(genreToDelete);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}