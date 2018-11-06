﻿    using Chinook.Entities.Base;
using Chinook.Entities.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Chinook.Service.wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMantenimientosServices
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        IEnumerable<Artist> GetArtistByName(string artistName);

        [OperationContract]
        IEnumerable<Album> GetAll();

        [OperationContract]
        IEnumerable<Album> GetById(int AlbumId);

        [OperationContract]
        IEnumerable<AlbunesVendidosQuery> GetAlbunesVendidos();

        [OperationContract]
        bool AddArtist(Artist artist);


        // TODO: agregue aquí sus operaciones de servicio
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
