using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using WebProje.Models.DataContext;
using WebProje.Models.Model;

namespace WebProje.Controllers
{
    public class HakkimizdaController : Controller
    {
        UmutParkDBContext db = new UmutParkDBContext();
        // GET: Hakkimizda
        public ActionResult Index()
        {
            var h = db.Hakkimizda.ToList();
            return View(h);
        }
        public ActionResult Edit(int id)
        {
            var h = db.Hakkimizda.Where(x => x.HakkimizdaId == id).FirstOrDefault();
            return View(h);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateInput(false)]   
        public ActionResult Edit(int id, Hakkimizda h, HttpPostedFileBase ResimURL)
        {
            if(ModelState.IsValid) 
            {
                var hakkimizda = db.Hakkimizda.Where(x => x.HakkimizdaId == id).SingleOrDefault();
                if (ResimURL != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(hakkimizda.ResimURL)))//Kayıtlı logo var mı yok mu kontrol etmek için.
                    {
                        System.IO.File.Delete(Server.MapPath(hakkimizda.ResimURL));
                    }
                    WebImage img = new WebImage(ResimURL.InputStream);
                    FileInfo imginfo = new FileInfo(ResimURL.FileName);

                    string imgname = ResimURL.FileName + imginfo.Extension;
                    img.Resize(800, 450);
                    img.Save("~/Uploads/Hakkimizda/" + imgname);

                    hakkimizda.ResimURL = "/Uploads/Hakkimizda/" + imgname;
                }
                hakkimizda.Aciklama = h.Aciklama;
                db.SaveChanges();
                return RedirectToAction("Index");
            }            
            return View(h);
        }
    }
}