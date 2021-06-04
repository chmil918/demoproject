using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories.Implementation
{
    public class TestRepository : BaseRepository<Test>, ITestRepository
    {
        internal TestRepository(GeoEntContext context) : base(context)
        {
        }
    }
}
