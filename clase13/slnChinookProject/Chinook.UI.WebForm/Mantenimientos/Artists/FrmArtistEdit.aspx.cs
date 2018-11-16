using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm.Mantenimientos.Artists
{
    public partial class FrmArtistEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
               GetArtist();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            var service = new MantenimientoServices.MantenimientosServicesClient();
            if (string.IsNullOrWhiteSpace(HFId.Value))  //Nuevo
            {
                service.AddArtist(
                    new MantenimientoServices.Artist()
                    {
                        Name = TxtNombre.Text
                    }
                );
            }
            else //Edicion
            {
                service.EditArtist(
                    new MantenimientoServices.Artist()
                    {
                        ArtistId =Convert.ToInt32(HFId.Value),Name=TxtNombre.Text
                    });
            }
            Response.Redirect("FrmConsultarArtista");
        }
        private void GetArtist()
        {
            if (String.IsNullOrWhiteSpace(Request.QueryString["id"]))
            {
                return;
            }
            else
            {
                //Recuperando los parametros de la url mediante el objeto request
                var id = Convert.ToInt32(Request.QueryString["id"]);
                var cliente = new MantenimientoServices.MantenimientosServicesClient();
                //Obteniendo la informacion Completa del Artista
                var artist = cliente.GetArtistById(id);
                TxtNombre.Text = artist.Name;
                HFId.Value = artist.ArtistId.ToString();
            }
        }
    }
}