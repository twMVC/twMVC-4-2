using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplatesExplainProject.Controllers
{
    public class HomeController : Controller
    {
        public ExampleModel Model
        {
            get
            {
                var model = new ExampleModel()
                {
                    Enabled = true,
                    Email = "test@gmail.com.tw",
                    Url = "http://mvc.tw/",
                    Html = "<b>TW MVC</b>",
                    Password = "1234",
                    Time = DateTime.Now,
                    Currency = 12000.32M
                };
                return model;
            }
        }

        public ActionResult Index()
        {
            return View(this.Model);
        }

        public ActionResult DisplayAllModel()
        {
            return View(this.Model);
        }

        public ActionResult EditorAllModel()
        {
            return View(this.Model);
        }
    }
}
