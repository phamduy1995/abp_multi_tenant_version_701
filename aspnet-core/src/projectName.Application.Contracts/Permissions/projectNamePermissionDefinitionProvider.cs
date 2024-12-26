using projectName.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace projectName.Permissions;

public class projectNamePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(projectNamePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(projectNamePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<projectNameResource>(name);
    }
}
