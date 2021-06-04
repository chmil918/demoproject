using DAL.EF;
using DAL.Entities;
using DAL.Repositories.Abstract;

namespace DAL.Repositories.Implementation
{
    public class ReagentRepository : BaseRepository<Reagent>, IReagentRepository
    {
        internal ReagentRepository(GeoEntContext context)
         : base(context)
        {
        }
    }
}
