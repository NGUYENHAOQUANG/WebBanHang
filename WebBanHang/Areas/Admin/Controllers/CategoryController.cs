using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebBanHang.Models;
using WebBanHang.Models.EF;

namespace WebBanHang.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        // GET: Admin/Categoryb
        public ActionResult Index()
        {
            var items = db.categories;
            return View(items);
        }

        public ActionResult Add()
        {
            var maxPosition = db.categories.Max(c => (int?)c.Position) ?? 0;
            ViewBag.NextPosition = maxPosition + 1;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category model)
        {
            if (ModelState.IsValid)
            {
                model.CreateDate = DateTime.Now;
                model.ModifierDate = DateTime.Now;
                  
                
                model.Alias = WebBanHang.Models.Common.Filter.FilterChar(model.Title);
                db.categories.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var item = db.categories.Find(id);
            return View(item);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category model)
        {
            if(ModelState.IsValid)
            {
                db.categories.Attach(model);
                model.ModifierDate = DateTime.Now;
                model.Alias = WebBanHang.Models.Common.Filter.FilterChar(model.Title);
                db.Entry(model).Property(x => x.Title).IsModified = true;
                db.Entry(model).Property(x=> x.Description).IsModified = true;
                db.Entry(model).Property(x => x.Alias).IsModified = true;
                db.Entry(model).Property(x => x.SeoDecription).IsModified = true;
                db.Entry(model).Property(x => x.SeoKeyWords).IsModified = true;
                db.Entry(model).Property(x => x.SeoTtile).IsModified = true;
                db.Entry(model).Property(x => x.Position).IsModified = true;
                db.Entry(model).Property(x => x.ModifierDate).IsModified = true;
                db.Entry(model).Property(x => x.ModifiedBy).IsModified = true;
                db.SaveChanges();   

                return  RedirectToAction("Index");  
            }
            return View(model);
        }

        public ActionResult Delete(int id)
         {
             var item = db.categories.Find(id);

             if(item != null)
             {
                 db.categories.Remove(item); 
                 db.SaveChanges();    

             }    
             return RedirectToAction("Index");   

         }
        

        /*public ActionResult Delete(int id)
        {
            var item = db.categories.Find(id);
            if (item != null)
            {
                db.categories.Remove(item);
                db.SaveChanges();
                return Json(new { success= true });

            }

            return Json(new { success = false });

        }*/
    }
}