using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ShopManage.Controllers;

namespace ShopManage.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ShopManageControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
