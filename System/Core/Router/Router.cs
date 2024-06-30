using ChuckNorris.System.Core.Controller;

namespace ChuckNorris.System.Core.Router
{
    public class Router : IRouter
    {
        private readonly WebApplication _App;


        public Router(WebApplication app)
        {
            this._App = app;
        }


        public void Get(string path, IController controller)
        {
            this._App?.MapGet(path, Router.GetControllerInvoker(controller));
        }

        public void Put(string path, IController controller)
        {
            this._App?.MapPut(path, Router.GetControllerInvoker(controller));
        }

        public void Post(string path, IController controller)
        {
            this._App?.MapPost(path, Router.GetControllerInvoker(controller));
        }

        public void Patch(string path, IController controller)
        {
            this._App?.MapPatch(path, Router.GetControllerInvoker(controller));
        }

        public void Delete(string path, IController controller)
        {
            this._App?.MapDelete(path, Router.GetControllerInvoker(controller));
        }

        private static RequestDelegate GetControllerInvoker(IController controller)
        {
            return (HttpContext context) => controller.Invoke(context, new RouteParams(context));
        }
    }
}
