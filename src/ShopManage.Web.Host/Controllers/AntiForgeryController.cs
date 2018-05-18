using Microsoft.AspNetCore.Antiforgery;
using ShopManage.Controllers;

namespace ShopManage.Web.Host.Controllers
{
    public class AntiForgeryController : ShopManageControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
