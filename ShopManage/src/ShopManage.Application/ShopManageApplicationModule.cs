using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ShopManage.Authorization;

namespace ShopManage
{
    [DependsOn(
        typeof(ShopManageCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ShopManageApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ShopManageAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ShopManageApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
