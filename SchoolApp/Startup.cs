using App.Auth.Provider;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
//using Owin2.Providers;
using SchoolApp;
using SchoolApp.DependencyResolution;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

[assembly: OwinStartup(typeof(SchoolApp.Startup))]
namespace SchoolApp
{
    public class Startup
    {

        /*First of all we need to install the following NuGet package manger, so open package manager console and type:*/
        public void Configuration(IAppBuilder app)
        {
            //GlobalConfiguration.Configuration.UseStructureMap(IoC.Initialize());
            HttpConfiguration config = new HttpConfiguration();

            ConfigureOAuth(app);

            WebApiConfig.Register(config);
            /*Allowing all cors here for API to access*/
            app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);


            //StructureMap Container
            IContainer container = IoC.Initialize();

            //Register for MVC
            //DependencyResolver.SetResolver(new StructureMapDependencyResolver(container));

            //Register for Web API
            var resolver = new StructureMapWebApiDependencyResolver(container);
            //GlobalConfiguration.Configuration.DependencyResolver = new StructureMapWebApiDependencyResolver(container);
            config.DependencyResolver = resolver;

        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            /*
             * Here we’ve created new instance from class “OAuthAuthorizationServerOptions” and set its option as the below:

                The path for generating tokens will be as :”http://localhost:port/token”. We’ll see how we will issue HTTP POST request to generate token in the next steps.
                We’ve specified the expiry for token to be 24 hours, so if the user tried to use the same token for authentication after 24 hours from the issue time, his request will be rejected and HTTP status code 401 is returned.
                We’ve specified the implementation on how to validate the credentials for users asking for tokens in custom class named “SimpleAuthorizationServerProvider”.
             * */

            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(1),
                Provider = new AuthorizationServerProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}