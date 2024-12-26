using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using projectName.Data;
using Volo.Abp.DependencyInjection;

namespace projectName.EntityFrameworkCore;

public class EntityFrameworkCoreprojectNameDbSchemaMigrator
    : IprojectNameDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreprojectNameDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the projectNameDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<projectNameDbContext>()
            .Database
            .MigrateAsync();
    }
}
