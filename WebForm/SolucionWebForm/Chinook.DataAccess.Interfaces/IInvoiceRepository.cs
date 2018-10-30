using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chinook.Entities.Queries;
using Chinook.Entities.Base;

namespace Chinook.DataAccess.Interfaces
{
    public interface IInvoiceRepository : IGeneryRepository<Invoice>
    {
        IEnumerable<CustomerAddresQuery> GetCustosmerId_Invoice(int CustomerId);
        IEnumerable<TrackNameQuery> GetTrackName(string TrackName);
    }
}
