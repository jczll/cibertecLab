﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace Chinook.UI.WebForm
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta al iniciar la aplicación
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //BundleTable.EnableOptimizations = true;
        }
        void Session_Start(object sender, EventArgs e)
        {
            //Para configurar datos del usuario 
        }
        void application_Error(object sender, EventArgs e)
        {

        }
    }
}