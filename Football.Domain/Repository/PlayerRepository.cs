using Football.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Football.Domain.Repository
{
    public class PlayerRepository : BaseRepository<Player>
    {
        public IEnumerable<Player> GetByName(string p_strName)
        {
            return base.DbSet.Where(a => a.Name.Contains(p_strName));
        }
        //tet
    }
}
