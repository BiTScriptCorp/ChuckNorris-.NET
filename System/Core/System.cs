using ChuckNorris.System.Core.Config;

namespace ChuckNorris.System.Core
{
    public class System
    {
        private WebApplication _App;
        private WebApplicationBuilder _Builder;


        public System(WebApplicationBuilder builder, WebApplication app)
        {
            _App = app;
            _Builder = builder;
        }


        public void Run()
        {
            try
            {
                Services.AddServices(_App);
                Services.ConfigureRoutes();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
