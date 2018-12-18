using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTemple.Usuarios
{
    public partial class Ingreso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        private void Ingresar()
        {
            if (ValidaUsuario())
            {
                FormsAuthenticationTicket tkt;
                string cookieStr;
                HttpCookie httpCookie;
                tkt = new FormsAuthenticationTicket(
                          1,
                          TxtLogin.Text.Trim(),
                          DateTime.Now,
                          DateTime.Now.AddMinutes(10),
                          false,
                          ""
                          );
                cookieStr = FormsAuthentication.Encrypt(tkt);
                httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, cookieStr);

                Response.Cookies.Add(httpCookie);
                Response.Redirect("~/default.aspx", true);
            }
        }
        private bool ValidaUsuario()
        {
            var wcfClient = new MantenimientoServices.MantenimientosServicesClient();
            var user = wcfClient.GetUserByLogin(TxtLogin.Text.Trim(), TxtPassword.Text.Trim());
            return user != null;
        }
    }
}