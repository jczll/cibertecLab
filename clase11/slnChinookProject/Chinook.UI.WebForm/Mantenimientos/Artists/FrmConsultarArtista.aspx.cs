using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm
{
    public partial class FrmConsultarArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
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

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmArtistEdit.aspx");
        }
    }
}