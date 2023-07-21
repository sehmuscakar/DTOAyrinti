using Business.Abstract;
using DataAccesss.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DTOMantik.Controllers
{
    public class UniversityController : Controller
    {
        private readonly IUniversityManager _universityManager;

        public UniversityController(IUniversityManager universityManager)
        {
            this._universityManager = universityManager;
        }

        public ActionResult Index()
        {
         var data=  _universityManager.GetList();
            return View(data);
        }

        // GET: UniversityController/Details/5
        public ActionResult IndexDto()
        {
            var data = _universityManager.GetUniversityListManager();
            return View(data);
        }

        // GET: UniversityController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UniversityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(University university)
        {
            try
            { 
                _universityManager.Add(university);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UniversityController/Edit/5
        public ActionResult Edit(int id)
        {
            var data=_universityManager.GetById(id);
            return View(data);
        }

        // POST: UniversityController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, University university)
        {
            try
            {
                _universityManager.Update(university);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UniversityController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = _universityManager.GetById(id);
            return View(data);
        }

        // POST: UniversityController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, University university)
        {
            try
            {
                _universityManager.Remove(university);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
