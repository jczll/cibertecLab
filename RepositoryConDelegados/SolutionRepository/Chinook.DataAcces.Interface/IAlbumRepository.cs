using Chinook.DataAcces.Queries;
using Chinook.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAcces.Interface
{
    public interface IAlbumRepository: IGeneryRepository<Album>
    {
        IEnumerable<AlbunesVendidosQuery> GetAlbunesVendidos();
    }
}
