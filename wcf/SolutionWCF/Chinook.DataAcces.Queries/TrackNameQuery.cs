using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAcces.Queries
{
    public class TrackNameQuery
    {
        public int TrackId { get; set; }
        public string Album_title { get; set; }
        public string Artist_name { get; set; }
        public string Track_name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
