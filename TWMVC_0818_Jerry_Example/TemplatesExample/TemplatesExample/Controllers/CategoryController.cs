using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplatesExample.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryService _categoryService = new CategoryService();

        public ActionResult Index()
        {
            return View(_categoryService.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {
            _categoryService.Create(category);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_categoryService.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            var source = _categoryService.Get(id);
			
            if (TryUpdateModel(source, new string[] { "Name" , "Enabled" }))
            {
                _categoryService.Update(source);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var model = _categoryService.Get(id);
            if (model != null)
            {
                _categoryService.Delete(model);
            }
            return RedirectToAction("Index");
        }
    }
}
