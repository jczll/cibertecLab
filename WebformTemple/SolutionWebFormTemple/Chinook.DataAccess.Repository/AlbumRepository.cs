using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinook.DataAccess.Interfaces;
using Chinook.Entities.Queries;
using Chinook.Entities.Base;

namespace Chinook.DataAccess.Repository
{
    public class AlbumRepository : GenericRepository<Album>, IAlbumRepository
    {
        public AlbumRepository(DbContext pContext) : base(pContext)
        {

        }
        public IEnumerable<AlbunesVendidosQuery> GetAlbunesVendidos()
        {
            return this.context.Database.SqlQuery<AlbunesVendidosQuery>("usp_getAlbunesVendidos").ToList();
        }
    }
}
