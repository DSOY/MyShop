using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopManage.Shop.Product
{
    /// <summary>
    /// 商品表实体
    /// </summary>
    [Table("AbpProduct")]
    public class Product:FullAuditedEntity
    {
        /// <summary>
        /// 租户
        /// </summary>
        [Required]
        public int TenantID { get; set; }

        /// <summary>
        /// 商品编码
        /// </summary>
        [MaxLength(64)]
        public string Code { get; set; }

        /// <summary>
        /// 条码
        /// </summary>
        [MaxLength(64)]
        public string Barcode { get; set; }

        /// <summary>
        /// 当前价格
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// 原价
        /// </summary>
        [Required]
        public decimal OldPrice { get; set; }

        /// <summary>
        /// 简称
        /// </summary>
        [MaxLength(80)]
        public string ShortName { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        [Required]
        [MaxLength(120)]
        public string Name { get; set; }

        /// <summary>
        /// 规格
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Size { get; set; }

        /// <summary>
        /// 简短说明
        /// </summary>
        [MaxLength(256)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// 详细说明
        /// </summary>
        [MaxLength(512)]
        public string FullDescription { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        [MaxLength(500)]
        public string Picture { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Required]
        public ProductStatus Status { get; set; }

        /// <summary>
        /// 品类
        /// </summary>
        [Required]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        /// <summary>
        /// 是否为精品
        /// </summary>
        public int IsBest { get; set; }

        /// <summary>
        /// 是否为新品
        /// </summary>
        public int IsNew { get; set; }
        
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        
        /// <summary>
        /// 创建人
        /// </summary>
        public int Creator { get; set; }
        
        /// <summary>
        /// 评论次数
        /// </summary>
        public int CommentTimes { get; set; }

        /// <summary>
        /// 已售数量
        /// </summary>
        public int SoldNum { get; set; }
    }
}
