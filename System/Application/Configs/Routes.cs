using ChuckNorris.System.Application.Controllers;
using ChuckNorris.System.Core.Router;

namespace ChuckNorris.System.Appliation.Configs
{
    public class RoutesConfig : IRoutesCollection
    {
        public void Configure(Router router)
        {
            router.Get("/{id:int}", new Welcome());
        }
    }
}