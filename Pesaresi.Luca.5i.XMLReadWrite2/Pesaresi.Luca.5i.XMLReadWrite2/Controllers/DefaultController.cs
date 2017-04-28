using Pesaresi.Luca._5i.XMLReadWrite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;

namespace Pesaresi.Luca._5i.XMLReadWrite2.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        private Persone p { get; set; }
        public ActionResult Index()
        {
            string nomeFile = HostingEnvironment.MapPath(@"~/App_Data/dati.xml");
            p = new Persone(nomeFile);
            p.Salva();
            return View(p);
        }
    }
}