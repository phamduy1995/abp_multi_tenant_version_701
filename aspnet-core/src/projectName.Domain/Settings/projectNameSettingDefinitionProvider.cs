using Volo.Abp.Settings;

namespace projectName.Settings;

public class projectNameSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(projectNameSettings.MySetting1));
    }
}
