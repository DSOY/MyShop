using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopManage.Dto
{
    /// <summary>
    /// 分页
    /// </summary>
    public class PagedAndSortedInputDto : IPagedResultRequest,ISortedResultRequest
    {
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        [Range(1, 500)]
        public int MaxResultCount { get; set; }
        
        public string Sorting { get; set; }
    }
}
