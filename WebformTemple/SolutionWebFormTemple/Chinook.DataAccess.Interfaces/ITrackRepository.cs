using Chinook.DataAcces.Queries;
using Chinook.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Interfaces
{
    public interface ITrackRepository: IGeneryRepository<Track>
    {
        IEnumerable<TracksVendidosQuery> BuscarAlumnoMatriculado(string TrackName);
    }
}
