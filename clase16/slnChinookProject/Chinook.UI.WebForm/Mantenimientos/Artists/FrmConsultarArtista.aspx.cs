using Chinook.UI.WebForm.MantenimientoServices;
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
            Session["Artists"] = null;
            Consultar();
        }
        private void Consultar()
        {
            dynamic data = null;
            if(Session["Artists"]==null)
            {
                var service = new MantenimientoServices.MantenimientosServicesClient();
                data = service.GetArtistByName(txtFiltroByName.Text);
                Session["Artists"] = data;
            }
            else
            {
                data = Session["Artists"] as Artist[];
            }
            GrdListado.DataSource = data;
            GrdListado.DataBind();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmArtistEdit.aspx");
        }

        protected void GrdListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdListado.PageIndex = e.NewPageIndex;
            Consultar();
        }
    }
}