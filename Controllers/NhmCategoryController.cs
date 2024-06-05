using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Web.Mvc;
using NhmLesson06CF.Models;


namespace NhmLesson06CF.Controllers
{
    public class NhmCategoryController : Controller
    {
        private static NhmBookstore nhmDb;
        public NhmCategoryController()
        {
            nhmDb = new NhmBookstore();
        }
        public ActionResult NhmIndex()
        {
            /*
             * Khoi tao DbContext
             * Ef se tim thong tin ket noi trong file machinee.config cua .net framework tren nay
             * va sau do tao csdl
             * */
            NhmBookstore nhmDb = new NhmBookstore();
            var nhmCategories = nhmDb.NhmCategories.ToList();
            return View(nhmCategories);
        }
        public ActionResult NhmCreate()
        {
            var nhmcategory = new NhmCategory();
            return View(nhmcategory);
        }
        [HttpPost]
        public ActionResult NhmCreate(NhmCategory nhmCategory)
        {
            nhmDb.NhmCategories.Add(nhmCategory);
            nhmDb.SaveChanges();

            return RedirectToAction("NhmIndex");
        }
    }
}