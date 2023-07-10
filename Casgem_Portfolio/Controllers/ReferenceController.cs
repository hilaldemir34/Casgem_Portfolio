using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ReferenceController : Controller
    {
        // GET: Reference
        CasgemPortfolioEntities1 db = new CasgemPortfolioEntities1(); 
        public ActionResult Index()
        {
            var value = db.TblReference.ToList();
            return View(value);
        }
      
        public ActionResult DeleteReference(int id)
        {
            var value = db.TblReference.Find(id);
            db.TblReference.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult AddReference()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddReference(TblReference p)
        {
            db.TblReference.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateReference(int id)
        {
            var value = db.TblReference.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateReference(TblReference p)
        {
            var value = db.TblReference.Find(p.ReferenceID);
            value.NameSurname = p.NameSurname;
            value.Mail = p.Mail;
            value.Phone = p.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}