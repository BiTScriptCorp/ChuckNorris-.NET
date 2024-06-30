using ChuckNorris.System.Core.Controller;
using ChuckNorris.System.Core.Router;

namespace ChuckNorris.System.Application.Controllers
{
    public class Welcome : IController
    {
        public Task Invoke(HttpContext context, IRouteParams routeParams)
        {
            return context.Response.WriteAsync(
                $"UserID: {routeParams.GetParam<int>("id")}"
            );
        }
    }
}
