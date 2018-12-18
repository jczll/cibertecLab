using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormTemple.Models;

namespace WebFormTemple
{
    public partial class Carrito1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                AgregarCarrito();
            }
        }
        private void AgregarCarrito()
        {
            var id = Convert.ToInt32(Request.QueryString["id"]);
            var wcfCliente = new MantenimientoServices.MantenimientosServicesClient();

            var track = wcfCliente.GetTrackById(id);

            var CarritoItem = new CarritoItems();

            CarritoItem.TrackId = track.TrackId;
            CarritoItem.TrackName = track.Name;
            CarritoItem.UnitPrice = track.UnitPrice;
            CarritoItem.Bytes = track.Bytes;
            CarritoItem.Milliseconds = track.Milliseconds;
            CarritoItem.Quantity = 1;

            var carrito = new List<CarritoItems>();

            if (Session["Tracks"] != null)
            {
                carrito = Session["tracks"] as List<CarritoItems>;
                //Revisando de el Item no se repita
                var trackFound = carrito.Find(item => item.TrackId == id);

                if (trackFound != null)
                {
                    carrito.Remove(trackFound);
                    CarritoItem.Quantity = trackFound.Quantity + 1;
                }
            }
            CarritoItem.Total = CarritoItem.Quantity * CarritoItem.UnitPrice;
            carrito.Add(CarritoItem);
            //Actualizando Session
            Session["tracks"] = carrito;
            GrdCarrito.DataSource = carrito;
            GrdCarrito.DataBind();
        }
    }
}