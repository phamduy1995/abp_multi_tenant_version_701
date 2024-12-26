using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace projectName;

[Dependency(ReplaceServices = true)]
public class projectNameBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "projectName";
}
