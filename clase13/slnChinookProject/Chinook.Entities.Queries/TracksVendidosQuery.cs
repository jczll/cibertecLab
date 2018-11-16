using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Entities.Queries
{
    [DataContract]
    public class TracksVendidosQuery
    {
        [DataMember]
        public int TrackId { get; set; }
        [DataMember]
        public string TrackName { get; set; }
        [DataMember]
        public int AlbumId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int ArtistId { get; set; }
        [DataMember]
        public string ArtistName { get; set; }
        [DataMember]
        public int MediaTypeId { get; set; }
        [DataMember]
        public string MediaTypeName { get; set; }
        [DataMember]
        public string Composer { get; set; }
        [DataMember]
        public int Milliseconds { get; set; }
        [DataMember]
        public int Bytes { get; set; }
        [DataMember]
        public decimal UnitPrice { get; set; }
    }
}
