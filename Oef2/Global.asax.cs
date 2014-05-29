using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Oef2
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Application["Counter"] = 0;

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Session_Start()
        {
            Application["Counter"] = (int)Application["Counter"] + 1;
        }

        protected void Session_End()
        {

            Application["Counter"] = (int)Application["Counter"] - 1;
        }
    }
}
