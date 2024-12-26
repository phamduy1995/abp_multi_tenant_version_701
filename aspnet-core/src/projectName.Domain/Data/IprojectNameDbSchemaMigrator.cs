using System.Threading.Tasks;

namespace projectName.Data;

public interface IprojectNameDbSchemaMigrator
{
    Task MigrateAsync();
}
