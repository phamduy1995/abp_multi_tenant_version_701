using projectName.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace projectName.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class projectNameController : AbpControllerBase
{
    protected projectNameController()
    {
        LocalizationResource = typeof(projectNameResource);
    }
}
