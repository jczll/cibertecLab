using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormTemple.Usuarios
{
    public class PageBase : System.Web.UI.Page
    {
        protected void IsAutenticate()
        {
            //V8erificando si el usuario esta autenticado a la aplicacion
            if (!HttpContext.Current.User.Identity.IsAuthenticated)
            {
                RedirectToLogin();
            }
        }
        private void RedirectToLogin()
        {
            Response.Redirect("~/Usuarios/ingreso_usuarios.aspx");
        }
    }
}