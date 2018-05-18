using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShopManage.Configuration;

namespace ShopManage.Web.Host.Startup
{
    [DependsOn(
       typeof(ShopManageWebCoreModule))]
    public class ShopManageWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ShopManageWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ShopManageWebHostModule).GetAssembly());
        }
    }
}
