using Rich.AbpStudy.Configuration;
using Rich.AbpStudy.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Rich.AbpStudy.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class AbpStudyDbContextFactory : IDesignTimeDbContextFactory<AbpStudyDbContext>
    {
        public AbpStudyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpStudyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(AbpStudyConsts.ConnectionStringName)
            );

            return new AbpStudyDbContext(builder.Options);
        }
    }
}