using SaglikUrunleri.BLL.Repository;
using SaglikUrunleri.DAL.Context;
using SaglikUrunleri.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SaglikUrunleri.PL.MVC.Controllers
{
    public class HomeController : BaseController
    {
                 
        Repository<Urun> repoU = new Repository<Urun>(new SaglikContext());
        
        public ActionResult Index(int? katid,int? altid)
        {           
            ViewBag.KatID = katid;
            ViewBag.AltKatID = altid;
            return View();
        }
        public ActionResult UrunlerBy(int? katid,int? altid)
        {
            List<Urun> liste = new List<Urun>();

            if(altid.HasValue)
            {
                liste = repoU.GetAll(x => x.altkategoriID == altid).ToList();
            }
            else
            {
                if(katid.HasValue)
                {
                    liste = repoU.GetAll(x => x.kategoriID == katid).ToList();
                }
                else
                {
                    liste = repoU.GetAll().ToList();
                }
            }
            return PartialView(liste);
        }

        public ActionResult UrunDetay(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Urun u = repoU.GetById(id.Value);

            if(u==null)
            {
                return HttpNotFound();
            }

            return View(u);
        }
    }
}