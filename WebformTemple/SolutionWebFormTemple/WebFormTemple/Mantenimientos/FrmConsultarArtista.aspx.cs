using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormTemple.MantenimientoServices;
using WebFormTemple.Usuarios;

namespace Chinook.UI.WebForm.Mantenimientos
{    
    public partial class FrmConsultarArtista : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            base.IsAutenticate();
            if (!Page.IsPostBack)
                Consultar();
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(7000);
            Cache.Remove("ArtistCache");
            //Session["Artists"] = null;
            Consultar();
        }
        private void Consultar()
        {
            var service = new WebFormTemple.MantenimientoServices.MantenimientosServicesClient();
            Artist[] data;
            if(Cache["ArtistCache"]==null)
            {
                data = service.GetArtistByName(txtFiltroByName.Text);
                Cache.Insert("ArtistCache", data, null, DateTime.Now.AddSeconds(30), System.Web.Caching.Cache.NoSlidingExpiration);
            }
            else
            {
                data = Cache["ArtistCache"] as Artist[];
            }
            //dynamic data = null;
            //if (Session["Artists"] == null)
            //{
            //    var service = new WebFormTemple.MantenimientoServices.MantenimientosServicesClient();
            //    data = service.GetArtistByName(txtFiltroByName.Text);
            //    Session["Artists"] = data;
            //}
            //else
            //{
            //    data = Session["Artists"] as Artist[];
            //}
            GrdListado.DataSource = data;
            GrdListado.DataBind();
        }

        protected void BtnNuevo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmEditarArtista.aspx");
        }

        protected void GrdListado_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GrdListado.PageIndex = e.NewPageIndex;
            Consultar();
        }
    }
}