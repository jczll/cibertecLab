﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Chinook.DataAccess.Repository;
using Chinook.DataAccess.Interfaces;
using Chinook.Entities.Base;
using System.Data.Entity;
using Chinook.DataAcces.Queries;

namespace Chinook.Service.wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class MantenimientosServices : IMantenimientosServices
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly DbContext dbContext;

        public MantenimientosServices()
        {
            dbContext = new Model1();
            unitOfWork = new UnitOfWork(dbContext);
        }

        public bool AddArtist(Artist artist)
        {
            unitOfWork.ArtistRepository.Add(artist);
            unitOfWork.Complete();
            return true;
        }

        public bool EditArtist(Artist artist)
        {
            unitOfWork.ArtistRepository.Update(artist);
            unitOfWork.Complete();
            return true;
        }

        public Artist GetArtistById(int id)
        {            var artist = unitOfWork.ArtistRepository.GetById(id);
            return artist;

        }

        public IEnumerable<Artist> GetArtistByName(string artistName)
        {
            return unitOfWork.ArtistRepository.GetListByName(artistName);
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public Track GetTrackById(int id)
        {
            var track = unitOfWork.TrackRepository.GetById(id);
            return track;
        }

        public IEnumerable<TracksVendidosQuery> GetTrackVendidos(string trackName)
        {
            var data = unitOfWork.TrackRepository.GetTracksVendidos(trackName).Take(100);
            return data;
        }

        public Users GetUserByLogin(string login, string password)
        {
            return unitOfWork.UsersRepository.GetUserByLogin(login, password);
        }
    }
}
