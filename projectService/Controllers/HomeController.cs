using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projectService.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 主页面，主要用于登陆页面的显示
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}