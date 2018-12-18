using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormTemple.Models
{
    public class CarritoItems
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public int? Bytes { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}