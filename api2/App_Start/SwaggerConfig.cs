using System.Web.Http;
using WebActivatorEx;
using api2;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace api2
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "apiBeer")
                    .Description("Una demo d'API")
                    .TermsOfService("Feel free to use")
                    .Contact(cc => cc
                        .Name("Carlos Alonso")
                        .Email("carlos.martinez@mataro.epiaedu.cat"))
                    .License(lc => lc
                         .Name("Some license")
                         .Url("https://creativecommons.org/licenses/by-nc-sa/4.0/deed.es_ES"));


                }).EnableSwaggerUi();

                                        
        }
    }
}
