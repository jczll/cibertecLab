using Chinook.DataAcces.Queries;
using Chinook.DataAccess.Interfaces;
using Chinook.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Repository
{
    public class TrackRepository : GenericRepository<Track>, ITrackRepository
    {
        public TrackRepository(DbContext pContext) : base(pContext)
        {

        }
        public IEnumerable<TracksVendidosQuery> GetTracksVendidos(string trackName)
        {
            var param1 = new SqlParameter();
            param1.ParameterName = "@trackName";
            if (String.IsNullOrWhiteSpace(trackName))
                param1.Value = DBNull.Value;
            else
                param1.Value = trackName;

            return this.context.Database.SqlQuery<TracksVendidosQuery>("usp_GetTracks @trackName", param1).ToList();
        }
    }
}
