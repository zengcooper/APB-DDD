using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Rich.AbpStudy.EntityFrameworkCore;
using Rich.AbpStudy.Tests.TestDatas;

namespace Rich.AbpStudy.Tests
{
    public class AbpStudyTestBase : AbpIntegratedTestBase<AbpStudyTestModule>
    {
        public AbpStudyTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<AbpStudyDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<AbpStudyDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<AbpStudyDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AbpStudyDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<AbpStudyDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<AbpStudyDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<AbpStudyDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<AbpStudyDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
