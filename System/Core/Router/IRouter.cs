using ChuckNorris.System.Core.Controller;

namespace ChuckNorris.System.Core.Router
{
    public interface IRouter
    {
        void Get(string path, IController controller);
        void Put(string path, IController controller);
        void Post(string path, IController controller);
        void Patch(string path, IController controller);
        void Delete(string path, IController controller);
    }
}
