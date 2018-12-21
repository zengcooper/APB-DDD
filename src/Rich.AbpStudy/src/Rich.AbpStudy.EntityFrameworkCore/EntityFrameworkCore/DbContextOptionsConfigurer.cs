using Microsoft.EntityFrameworkCore;

namespace Rich.AbpStudy.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<AbpStudyDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for AbpStudyDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
