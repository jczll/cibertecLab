﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository AlbumRepository { get; }
        IArtistRepository ArtistRepository { get; }
        IInvoiceRepository InvoiceRepository { get; }
        ITrackRepository TrackRepository { get; }
        IUsersRepository UsersRepository { get; }
        int Complete();
    }
}
