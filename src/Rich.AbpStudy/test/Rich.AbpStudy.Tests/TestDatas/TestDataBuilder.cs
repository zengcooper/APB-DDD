using Rich.AbpStudy.EntityFrameworkCore;

namespace Rich.AbpStudy.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly AbpStudyDbContext _context;

        public TestDataBuilder(AbpStudyDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}