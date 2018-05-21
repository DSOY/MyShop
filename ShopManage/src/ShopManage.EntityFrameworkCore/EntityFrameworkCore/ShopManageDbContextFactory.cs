using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ShopManage.Configuration;
using ShopManage.Web;

namespace ShopManage.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ShopManageDbContextFactory : IDesignTimeDbContextFactory<ShopManageDbContext>
    {
        public ShopManageDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ShopManageDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ShopManageDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ShopManageConsts.ConnectionStringName));

            return new ShopManageDbContext(builder.Options);
        }
    }
}
