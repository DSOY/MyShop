using System;
using System.Collections.Generic;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using Microsoft.EntityFrameworkCore;
using ShopManage.Shop.Product.Dtos;

namespace ShopManage.Shop.Product
{
    public class ProductAppService : ShopManageAppServiceBase, IProductAppService
    {
        //注入
        private readonly IRepository<Product> _productRepository;
        
        public ProductAppService(IRepository<Product> productRepository)
        {
            _productRepository= productRepository;
        }
        
        public async Task CreateOrUpdateProductAsync(CreateOrUpdateProductInput input)
        {
            if (input.ProductEditDto.Id.HasValue)
            {
                await UpdateProductAsync(input.ProductEditDto);
            }
            else
            {
                await CreateProductAsync(input.ProductEditDto);
            }
        }

        public async Task DeteleProductAsync(EntityDto input)
        {
            var entity = _productRepository.GetAsync(input.Id);
            if (entity == null)
            {
                throw new UserFriendlyException("商品不存在，删除失败");
            }

            await _productRepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<ProductListDto>> GetPagedProductAsync(GetProductInput input)
        {

            //var roles = await _productRepository.GetAllListAsync();
            //return new PagedResultDto<ProductListDto>(1,ObjectMapper.Map<List<ProductListDto>>(roles));
            var query = _productRepository.GetAll();
            var productCount = await query.CountAsync();
            var product = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();
            var dtos = product.MapTo<List<ProductListDto>>();

            return new PagedResultDto<ProductListDto>(productCount, dtos);
        }
        
        public async Task<ProductListDto> GetProductByIdAsync(NullableIdDto input)
        {
            var entity = await _productRepository.GetAsync(input.Id.Value);
            return entity.MapTo<ProductListDto>();
        }

        protected async Task UpdateProductAsync(ProductEditDto input)
        {
            var entity = await _productRepository.GetAsync(input.Id.Value);
            await _productRepository.UpdateAsync(input.MapTo(entity));
        }

        protected async Task CreateProductAsync(ProductEditDto input)
        {
            var model = input.MapTo<Product>();
            await _productRepository.InsertAsync(model);
        }
    }
}
