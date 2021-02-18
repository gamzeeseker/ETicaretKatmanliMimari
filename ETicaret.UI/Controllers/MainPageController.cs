using ETicaret.BLL;
using ETicaret.BLL.Concrete;
using ETicaret.BLL.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ETicaret.UI.Controllers
{
    public class MainPageController : Controller
    {
        UserManager userManager = new UserManager();
        MVVM mvvm = new MVVM();

        public ActionResult Index()
        {
            CreateDb createDb = new CreateDb();
            mvvm.ListUser = userManager.List();

            return View(mvvm);
        }
        public ActionResult Delete(int id)
        {
            userManager.Delete(id);
            return RedirectToAction("Index");
        }
    }
}