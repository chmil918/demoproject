using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories.Implementation
{
    public class WorkerRepository : BaseRepository<Worker>, IWorkerRepository
    {
        internal WorkerRepository(GeoEntContext context) : base(context)
        {
        }
    }
}
