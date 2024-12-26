using System;
using System.Collections.Generic;
using System.Text;
using projectName.Localization;
using Volo.Abp.Application.Services;

namespace projectName;

/* Inherit your application services from this class.
 */
public abstract class projectNameAppService : ApplicationService
{
    protected projectNameAppService()
    {
        LocalizationResource = typeof(projectNameResource);
    }
}
