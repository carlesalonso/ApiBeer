using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;


namespace api2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            GlobalConfiguration.Configure(WebApiConfig.
            GlobalConfiguration.Configuration.EnableSwagger(c => c.SingleApiVersion("v1", "SomosTechies API")).EnableSwaggerUi();
        }

    }
}