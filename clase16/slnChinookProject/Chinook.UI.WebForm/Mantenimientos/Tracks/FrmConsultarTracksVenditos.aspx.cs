using Chinook.UI.WebForm.MantenimientoServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm.Mantenimientos.Tracks
{
    public partial class FrmConsultarTracksVenditos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                Consultar();
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Session["TracksVendidosQuery"] = null;
            Consultar();
        }
        private void Consultar()
        {
            dynamic data = null;
            if (Session["TracksVendidosQuery"] == null)
            {
                var service = new MantenimientoServices.MantenimientosServicesClient();
                data = service.GetTrackVendidos(txtFiltroByName.Text);
                Session["TracksVendidosQuery"] = data;
            }
            else
            {
                data = Session["TracksVendidosQuery"] as TracksVendidosQuery[];
            }
            GrdListado.DataSource = data;
            GrdListado.DataBind();
        }

        protected void GrdListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdListado.PageIndex = e.NewPageIndex;
            Consultar();
        }
    }
}