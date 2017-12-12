using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rhondas_Place_.Models;

namespace Rhondas_Place_.Controllers
{
    public class StoreController : Controller
    {
        RhondasPlaceStoreEntities storeDB = new RhondasPlaceStoreEntities();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            //var candlecategories = new List<CandleCategory>
            //{
            //    new CandleCategory { Name = "Classic"},
            //    new CandleCategory { Name = "Jelly"},
            //    new CandleCategory { Name = "Classic Emblem"}
            //};
            var candlecategories = storeDB.CandleCategory.ToList();
            return View(candlecategories);

        }
        //
        // GET: /Store/Browse?candlecategory=Jar Candles
        public ActionResult Browse(string candlecategory)
        {
            // Retrieve Candle Category and its Associated Candle from database
            var candlecategoryModel = storeDB.CandleCategory.Include("Candles").Single(c => c.Name == candlecategory);
            return View(candlecategoryModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id)
        {
            var candle = storeDB.Candle.Find(id);
            return View(candle);
        }

        //
        // GET: /Store/CategoryMenu
        [ChildActionOnly]
        public ActionResult CandleCategoryMenu()
        {
            var genres = storeDB.CandleCategory.ToList();
            return PartialView(genres);
        }
    }
}