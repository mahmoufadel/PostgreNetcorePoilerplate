using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ElectricitytDemo.Controllers;

namespace ElectricitytDemo.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ElectricitytDemoControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
