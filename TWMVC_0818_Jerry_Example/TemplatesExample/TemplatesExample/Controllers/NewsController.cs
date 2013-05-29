using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplatesExample.Controllers
{
    public class NewsController : Controller
    {
        private NewsService _newsService = new NewsService();

        public ActionResult Index()
        {
            return View(_newsService.GetAll());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(News news)
        {
            _newsService.Create(news);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_newsService.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, News news)
        {
            var source = _newsService.Get(id);
			
            if (TryUpdateModel(source, new string[] { "Title" , "Content" , "Enabled" }))
            {
                _newsService.Update(source);
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var model = _newsService.Get(id);
            if (model != null)
            {
                _newsService.Delete(model);
            }
            return RedirectToAction("Index");
        }
    }
}
