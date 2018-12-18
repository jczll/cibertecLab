using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFormTemple
{
    public class Global : HttpApplication
    {
        log4net.ILog logger = log4net.LogManager.GetLogger("Application Error");

        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //Toma la Configuracion del webConfig de la seccion log4net
            log4net.Config.XmlConfigurator.Configure();
            //BundleTable.EnableOptimizations = true;

        }
        void Session_Start(object sender, EventArgs e)
        {
            logger.Info("Inicion de Session, nuevo usuario");
            //Para configurar datos del usuario 
            if (Application["Contador"] != null)
            {
                Application["Contador"] = Convert.ToInt32(Application["Contador"]) + 1;
            }
            else
            {
                Application["Contador"] = 1;
            }
        }
        void Session_End(object sender, EventArgs e)
        {
            logger.Info("Inicion de Session, nuevo usuario");
            //Para configurar datos del usuario 
            if (Application["Contador"] != null)
            {
                Application["Contador"] = Convert.ToInt32(Application["Contador"]) - 1;
            }
            else
            {
                Application["Contador"] = 1;
            }
        }
        void application_Error(object sender, EventArgs e)
        {
            var objError = Server.GetLastError().GetBaseException();
            logger.Error(objError);
        }
    }
}