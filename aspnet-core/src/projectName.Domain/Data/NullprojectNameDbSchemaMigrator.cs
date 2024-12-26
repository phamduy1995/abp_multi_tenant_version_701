using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace projectName.Data;

/* This is used if database provider does't define
 * IprojectNameDbSchemaMigrator implementation.
 */
public class NullprojectNameDbSchemaMigrator : IprojectNameDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
