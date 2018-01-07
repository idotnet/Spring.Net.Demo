using Spring.Context;
using Spring.Context.Support;
using System.Web.Mvc;

namespace Spring.Net.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IUserInfo lister = (IUserInfo)ctx.GetObject("UserInfo");
            ViewBag.Msg = lister.ShowMsg();
            return View();
        }

        public ActionResult NewIndex()
        {
            IApplicationContext ctx = ContextRegistry.GetContext();
            IUserInfo lister = (IUserInfo)ctx.GetObject("NewUserInfo");
            ViewBag.Msg = lister.ShowMsg();
            return View();
        }

        public ActionResult TestLog()
        {
            int result = 0;
            int x = 1, y = 0;
            result = x / y;
            return View();
        }
    }
}