using SaglikUrunleri.BLL.Repository;
using SaglikUrunleri.DAL.Context;
using SaglikUrunleri.Entity.Entity;
using SaglikUrunleri.PL.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaglikUrunleri.PL.MVC.Controllers
{
    public class SepetController : BaseController
    {
        Repository<Urun> repoU = new Repository<Urun>(new SaglikContext());
        // GET: Sepet
        public ActionResult Index()
        {
            List<cSepet> sepet = cSepet.SepetAl();
            return View(sepet);
        }
    }
}