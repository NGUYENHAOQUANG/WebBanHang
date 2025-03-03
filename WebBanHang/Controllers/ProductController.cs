using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Partical_ItemsByCateID(int CateID)
        {
            var items = db.Products.Where(x=> x.IsHome).Take(12).ToList();  
            return PartialView(items);  
        }
    }
}