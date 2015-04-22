using System.Web;
using System.Web.Http;
using WebSocketServer.Core;

namespace WebSocketServer
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}