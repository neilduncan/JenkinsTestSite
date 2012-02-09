using System.Web.Mvc;

namespace JenkinsTestSite.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        public int MethodToTest()
        {
            return 1;
        }
    }
}
