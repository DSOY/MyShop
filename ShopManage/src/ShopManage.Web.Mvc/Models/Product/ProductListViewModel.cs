using ShopManage.Roles.Dto;
using ShopManage.Shop.Product.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopManage.Web.Models.Product
{
    public class ProductListViewModel
    {
        public IReadOnlyList<ProductListDto> Product { get; set; }
    }
}
