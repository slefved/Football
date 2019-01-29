using Football.Domain.Entity;
using System.Collections.Generic;
using System.Data.Entity;

namespace Football.Domain.Repository
{
    public class BaseRepository<T> where T : class
    {
        FootballEntities footballEntities = new FootballEntities();
        protected DbSet<T> DbSet { get; set; }

        public BaseRepository()
        {
            DbSet = footballEntities.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet;
        }
        public T Get(int p_iID)
        {
            return DbSet.Find(p_iID);
        }
    }
}
