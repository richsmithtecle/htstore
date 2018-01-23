using Project.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Web.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return View();
        }

        // Get Store/DetailView
        public ActionResult DetailView(int id)
        {
            StoreSqlDAL dal = new StoreSqlDAL();
            var product = dal.GetProduct(id);
            return View("DetailView", product);
        }

        //Get/Store/Products_TV
        public ActionResult Products_TV()
        {
            StoreSqlDAL DAL = new StoreSqlDAL();
            var Televisions = DAL.GetAllTVs();
            return View("Products_TV", Televisions);
        }

        public ActionResult List()
        {
            StoreSqlDAL DAL = new StoreSqlDAL();
            var TVs = DAL.GetAllProducts();
            return View("List", TVs); 
        }

        //Get/Store/GetAllProducts
        public ActionResult GetAllProducts()
        {
            StoreSqlDAL DAL = new StoreSqlDAL();
            var TVs = DAL.GetAllProducts();
            return View("GetAllProducts", TVs);
        }

        //Get/Store/Audio
        public ActionResult Products_Audio()
        {
            StoreSqlDAL DAL = new StoreSqlDAL();
            var AudioComps = DAL.GetAllAudio();
            return View("Products_Audio", AudioComps);
        }

        //Get/Store/Products_Furniture
        public ActionResult Products_Furniture()
        {
            StoreSqlDAL DAL = new StoreSqlDAL();
            var Furniture = DAL.GetAllFurniture();
            return View("Products_Furniture", Furniture);
        }

        //Get/Store/Products_Sonos
        public ActionResult Products_Sonos()
        {
            StoreSqlDAL DAL = new StoreSqlDAL();
            var Sonos = DAL.GetAllSonos();
            return View("Products_Sonos", Sonos);
        }
    }
}