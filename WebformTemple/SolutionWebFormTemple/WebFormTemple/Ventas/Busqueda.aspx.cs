using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormTemple.MantenimientoServices;
using WebFormTemple.Usuarios;

namespace WebFormTemple.Ventas
{
    public partial class Busqueda : PageBase
    {
        log4net.ILog logger = log4net.LogManager.GetLogger("Application Error");

        protected void Page_Load(object sender, EventArgs e)
        {
            base.IsAutenticate();
            if (!Page.IsPostBack)
            {
                Consultar();
            }
        }

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultar();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        private void Consultar()
        {
            var service = new MantenimientoServices.MantenimientosServicesClient();
            TracksVendidosQuery[] data;
            if (Cache["TrackCache"] == null)
            {
                data = service.GetTrackVendidos(txtFiltroByName.Text.Trim());
                Cache.Insert("TrackCache", data, null, DateTime.Now.AddSeconds(30),
                System.Web.Caching.Cache.NoSlidingExpiration);

            }
            else
            {
                data = Cache["TrackCache"] as TracksVendidosQuery[];
            }
            dlTracks.DataSource = data;
            dlTracks.DataBind();
        }
    }
}