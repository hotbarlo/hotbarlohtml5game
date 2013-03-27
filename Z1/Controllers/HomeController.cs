using System;
using System.Web.Mvc;
using DotLiquid;

namespace Z1.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            string text = "";
            text = " {% Loop 10 %}";
            Template template = Template.Parse(text);
            return template.Render(); // => "3"
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
