using projectName.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace projectName;

[DependsOn(
    typeof(projectNameEntityFrameworkCoreTestModule)
    )]
public class projectNameDomainTestModule : AbpModule
{

}
