using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Rich.AbpStudy.AggregatesModel.TaskAggregate;

namespace Rich.AbpStudy.EntityFrameworkCore
{
    public class AbpStudyDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Task> Tasks { get; set; }
        public AbpStudyDbContext(DbContextOptions<AbpStudyDbContext> options) 
            : base(options)
        {

        }
    }
}
