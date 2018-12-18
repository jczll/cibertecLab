using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAcces.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository AlbumRepository { get; }
        IArtistRepository ArtistRepository { get; }
        IInvoiceRepository InvoiceRepository { get; }
        int Complete();
    }
}
