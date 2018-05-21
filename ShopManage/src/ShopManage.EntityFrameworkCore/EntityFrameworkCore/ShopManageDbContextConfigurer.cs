using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ShopManage.EntityFrameworkCore
{
    public static class ShopManageDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ShopManageDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ShopManageDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
