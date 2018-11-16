using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm.Ventas
{
    public partial class Busqueda : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Consultar();
            }
        }
        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            throw new Exception("error para pruebas");
        }
        private void Consultar()
        {
            var service = new MantenimientoServices.MantenimientosServicesClient();
            var data = service.GetTrackVendidos(txtFiltroByName.Text.Trim());

            dlTracks.DataSource = data;
            dlTracks.DataBind();
        }
    }
}