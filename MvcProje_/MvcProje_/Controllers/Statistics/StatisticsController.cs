using BussinesLayer.Abstract;
using BussinesLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje_.Controllers.Statistics
{
    public class StatisticsController : Controller 
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        // GET: Statistics
        public ActionResult Index()
        {

            ViewBag.v1 = cm.GetList().Count();
            ViewBag.v2 = hm.GetList().Count();
            ViewBag.v3 = wm.GetList().Count();
            
            return View();
        }
        
    }
}