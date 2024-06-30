using ChuckNorris.System.Core.Router;

namespace ChuckNorris.System.Core.Controller
{
    public interface IController
    {
        Task Invoke(HttpContext context, IRouteParams routeParams);
    }
}
