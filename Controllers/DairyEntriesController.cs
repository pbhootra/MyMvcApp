using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyApplication3.Data;
using MyApplication3.Models;

namespace MyApplication3.Controllers
{
    public class DairyEntriesController : Controller
    {
        private readonly ApplicationDBContext _dbContext;

        public DairyEntriesController(ApplicationDBContext db)
        {
            _dbContext = db;
        }

        public IActionResult Index()
        {
            //Retrive or read data from table DairyEntries from database
            List<DairyEntry> objDairyEntries = _dbContext.DairyEntries.ToList();

            return View(objDairyEntries);
        }
        public IActionResult Create()
        { return View();
        }
        [HttpPost]
        public IActionResult Create(DairyEntry obj)
        {

            //server side validation : 

            if((  obj.Title.Length >  3))
            {
                ModelState.AddModelError("Title", "Title is too short");
            }

            if (ModelState.IsValid)  //check if serverside validation allow
            {
                _dbContext.DairyEntries.Add(obj); //add new entry in database
                _dbContext.SaveChanges();
           
                return RedirectToAction("Index", "DairyEntries");
            }
            else { return View(obj);
            }

                
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) { return NotFound(); }

            DairyEntry? DairyEntry = _dbContext.DairyEntries.Find(id);

            if (DairyEntry == null) { return NotFound(); }

             return View(DairyEntry);
        }

        [HttpPost]
        public IActionResult Edit(DairyEntry obj)
        {

            //server side validation : 

            if ((obj.Title.Length > 3))
            {
                ModelState.AddModelError("Title", "Title is too short");
            }

            if (ModelState.IsValid)  //check if serverside validation allow
            {
                _dbContext.DairyEntries.Update(obj); //Udate entry in database
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "DairyEntries");
            }
            else
            {
                return View(obj);
            }


        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null) { return NotFound(); }

            DairyEntry? DairyEntry = _dbContext.DairyEntries.Find(id);

            if (DairyEntry == null) { return NotFound(); }

            return View(DairyEntry);
        }

        [HttpPost]
        public IActionResult Delete(DairyEntry obj)
        {
           
            if (ModelState.IsValid)  //check if serverside validation allow
            {
                _dbContext.DairyEntries.Remove(obj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index", "DairyEntries");
            }
            else
            {
                return View(obj);
            }


        }


    }
}
