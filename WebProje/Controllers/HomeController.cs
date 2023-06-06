using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProje.Models.DataContext;

namespace WebProje.Controllers
{
    public class HomeController : Controller
    {
        private UmutParkDBContext db = new UmutParkDBContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Hizmetler = db.Hizmet.ToList().OrderBy(x => x.HizmetId);
            return View();
        }

        public ActionResult SliderPartial()
        {
            return View(db.Slider.ToList().OrderByDescending(x => x.SliderId));
        }

        public ActionResult HizmetPartial()
        {
            return View(db.Hizmet.ToList().OrderBy(x => x.HizmetId));
        }

        public ActionResult Hakkimizda()
        {
            return View(db.Hakkimizda.SingleOrDefault());
        }

        public ActionResult Hizmetlerimiz()
        {
            return View(db.Hizmet.ToList().OrderBy(x => x.HizmetId));
        }

        public ActionResult Iletisim()
        {
            return View(db.Iletisim.SingleOrDefault());
        }

        public ActionResult FooterPartial()
        {
            ViewBag.Hizmetler = db.Hizmet.ToList().OrderBy(x => x.HizmetId);
            ViewBag.Iletisim = db.Iletisim.SingleOrDefault();
            return PartialView();
        }

    }
}