using Abp.Runtime.Validation;
using ShopManage.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopManage.Shop.Product.Dtos
{
    public class GetProductInput : PagedAndSortedInputDto, IShouldNormalize
    {
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "CreationTime";
            } 
        }
    }
}
