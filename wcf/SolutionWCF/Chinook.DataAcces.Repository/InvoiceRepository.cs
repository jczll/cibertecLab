using Chinook.DataAcces.Interface;
using Chinook.DataAcces.Queries;
using Chinook.Entities.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAcces.Repository
{
    public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(DbContext pContext) : base(pContext)
        {

        }
        public IEnumerable<CustomerAddresQuery> GetCustosmerId_Invoice(int CustomerId)
        {
            return context.Database.SqlQuery<CustomerAddresQuery>("sp_buscarCustomerId_Invoice @CustomerId", new SqlParameter("@CustomerId", CustomerId)).ToList();
        }

        public IEnumerable<TrackNameQuery> GetTrackName(string TrackName)
        {
            return context.Database.SqlQuery<TrackNameQuery>("sp_BuscarTrackName @TrackName", new SqlParameter("@TrackName", TrackName)).ToList();
        }
    }
}
