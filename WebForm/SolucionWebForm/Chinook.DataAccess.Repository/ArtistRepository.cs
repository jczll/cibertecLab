using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinook.Entities.Queries;
using Chinook.Entities.Base;
using Chinook.DataAccess.Interfaces;

namespace Chinook.DataAccess.Repository
{
    public class ArtistRepository : GenericRepository<Artist>, IArtistRepository
    {
        public ArtistRepository(DbContext pContext) : base(pContext)
        {

        }
        public IEnumerable<Artist> GetListByName(string name)
        {
            return ((Model1)context).Artist.Where(item => item.Name.Contains(name)).ToList();
        }

        public IEnumerable<Artist> GetListByNameStore(string name)
        {
            return context.Database.SqlQuery<Artist>("usp_GetlistByName @Name", new SqlParameter("@name", name)).ToList();
        }
    }
}
