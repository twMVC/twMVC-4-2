using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TemplatesExample.Controllers
{
    public class BaseController : Controller
    {
        [HttpPost]
        public ActionResult UploadImage(HttpPostedFileBase file)
        {
            var path = "/images/upload/" + file.FileName;
            file.SaveAs(Server.MapPath("~" + path));
            return Content(path);
        }
    }
}

