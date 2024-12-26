using projectName.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace projectName.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(projectNameEntityFrameworkCoreModule),
    typeof(projectNameApplicationContractsModule)
    )]
public class projectNameDbMigratorModule : AbpModule
{

}
