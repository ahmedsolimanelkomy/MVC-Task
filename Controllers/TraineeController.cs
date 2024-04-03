using Day_2.Models;
using Day_2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_2.Controllers
{
    public class TraineeController : Controller
    {
        ITIContext context;
        TraineeRepository TraineesRepo;
        public TraineeController()
        {
            context = new ITIContext();
            TraineesRepo = new TraineeRepository(context);
        }
        // GET: TraineeController
        public ActionResult Index()
        {
            List<Trainee> Trainees = TraineesRepo.GetAll().ToList();
            return View("Index", Trainees);
        }

        // GET: TraineeController/Details/5
        public ActionResult Details(int id)
        {
            Trainee Trainee = TraineesRepo.GetById(id);
            return View("Details", Trainee);
        }

        // GET: TraineeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TraineeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TraineeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TraineeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TraineeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
