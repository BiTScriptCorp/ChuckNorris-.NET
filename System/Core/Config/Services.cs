using ChuckNorris.System.Appliation.Configs;
using ChuckNorris.System.Core.Router;

namespace ChuckNorris.System.Core.Config
{
    public class Services
    {
        private static IServiceCollection _Collection = new ServiceCollection();
        private static IServiceProvider? _Provider;


        public static void AddServices(WebApplication app)
        {
            Services._Collection.AddSingleton<Router.Router>();
            Services._Collection.AddSingleton<WebApplication>(app);
            Services._Collection.AddSingleton<IRoutesCollection>(new RoutesConfig());

            Services._Provider = Services._Collection.BuildServiceProvider();
        }

        public static void ConfigureRoutes()
        {
            var router = Services._Provider?.GetService<Router.Router>();
            var routesCollection = Services._Provider?.GetRequiredService<IRoutesCollection>();

            if (router == null || routesCollection == null)
            {
                throw new Exception("Error: unable to get router instances");
            }

            routesCollection.Configure(router);
        }
    }
}
