using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebBanHang.Models;

namespace WebBanHang.Controllers
{
    public class MenuController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuTop()
        {
            var items = db.categories.OrderBy(x=>x.Position).ToList();  
            return PartialView("_MenuTop",items); // tái sử dụng code chỉ cần gọi ra ở các trang khác hiển thị menu đầu trang
        }

        public ActionResult MenuProductCategory()
        {
            var items = db.ProductCategoris.ToList();
            return PartialView("_MenuProductCategory",items); // tái sử dụng được code hiển thị menu sản phẩm danh mục 
;       }

        public ActionResult MenuArrivals()
        {
            var items = db.ProductCategoris.ToList();
            return PartialView("_MenuArrivals", items); // tái sử dụng được code hiển thị menu sản phẩm danh mục 
            ;
        }
    }
}