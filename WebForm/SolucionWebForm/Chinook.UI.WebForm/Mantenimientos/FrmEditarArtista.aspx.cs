using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chinook.UI.WebForm.Mantenimientos
{
    public partial class FrmEditarArtista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            var service = new MantenimientoServices.MantenimientosServicesClient();
            service.AddArtist(
                new MantenimientoServices.Artist()
                {
                    Name = TxtNombre.Text
                }
            );
            Response.Redirect("FrmConsultarArtista");
        }
    }
}