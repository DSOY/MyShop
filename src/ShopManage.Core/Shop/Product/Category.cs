using Abp.Domain.Entities;

namespace ShopManage.Shop.Product
{
    public class Category : Entity<int>
    {
        public int ParentId { get; set; }
        public string Name { get; set; }

        public string Path { get; set; }
    }
}
