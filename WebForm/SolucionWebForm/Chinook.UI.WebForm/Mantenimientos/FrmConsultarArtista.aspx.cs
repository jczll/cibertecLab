using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm.Mantenimientos
{
    public partial class FrmConsultarArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Consultar();
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void Consultar()
        {
            var service = new MantenimientoServices.MantenimientosServicesClient();
            var data = service.GetArtistByName(txtFiltroByName.Text);
            GrdListado.DataSource = data;
            GrdListado.DataBind();
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEditarArtista.aspx");
        }
    }
}