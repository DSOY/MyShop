using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Microsoft.AspNetCore.Mvc;
using ShopManage.Controllers;
using ShopManage.Shop.Product;
using ShopManage.Shop.Product.Dtos;
using ShopManage.Web.Models.Product;

namespace ShopManage.Web.Mvc.Controllers
{
    public class ProductController : ShopManageControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public async Task<IActionResult> Index(GetProductInput input)
        {
            var dto = await _productAppService.GetPagedProductAsync(input);

            return View(dto);
        }

        public async Task<ActionResult> EditProductModal(int productId)
        {
            var input = new NullableIdDto() { Id=productId};
            var productDto = await _productAppService.GetProductByIdAsync(input);
            return View("_EditProductModal", productDto);
        }
    }
}