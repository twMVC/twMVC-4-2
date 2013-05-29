using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplatesExample.Controllers
{
    public class ProductController : Controller
    {
        private ProductService _productService = new ProductService();

        public ActionResult Index()
        {
            return View(_productService.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            _productService.Create(product);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_productService.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            var source = _productService.Get(id);
			
            if (TryUpdateModel(source, new string[] { "Name" , "Price" , "Description" , "Enabled" , "Image" , "CategoryId" }))
            {
                _productService.Update(source);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var model = _productService.Get(id);
            if (model != null)
            {
                _productService.Delete(model);
            }
            return RedirectToAction("Index");
        }
    }
}
