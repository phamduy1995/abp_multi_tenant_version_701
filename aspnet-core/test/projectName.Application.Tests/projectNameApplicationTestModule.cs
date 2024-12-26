using Volo.Abp.Modularity;

namespace projectName;

[DependsOn(
    typeof(projectNameApplicationModule),
    typeof(projectNameDomainTestModule)
    )]
public class projectNameApplicationTestModule : AbpModule
{

}
