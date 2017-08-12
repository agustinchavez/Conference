using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Optimization;
using Conference.Models; 

namespace Conference
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer<ConferenceContext>(new ConferenceContextInitializer());

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
