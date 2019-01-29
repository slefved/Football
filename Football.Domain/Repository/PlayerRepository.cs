using Football.Domain.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Data.SqlClient;
using System;
using Football.Domain.Helper;

namespace Football.Domain.Repository
{
    public class PlayerRepository : BaseRepository<Player>
    {
        public IEnumerable<Player> GetByName(string p_strName)
        {
            return base.DbSet.Where(a => a.Name.ToLower().Contains(p_strName.ToLower()));
        }
    }
}
