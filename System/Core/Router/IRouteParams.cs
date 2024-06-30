namespace ChuckNorris.System.Core.Router
{
    public interface IRouteParams
    {
        T? GetParam<T>(string key);
    }
}
