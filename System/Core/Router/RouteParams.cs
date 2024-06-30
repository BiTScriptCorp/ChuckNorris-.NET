namespace ChuckNorris.System.Core.Router
{
    public class RouteParams : IRouteParams
    {
        private HttpContext _Context;


        public RouteParams(HttpContext context)
        {
            this._Context = context;
        }


        public T? GetParam<T>(string key)
        {
            try
            {
                var routeValue = this._Context?.GetRouteValue(key);

                if (routeValue != null)
                {
                    return (T)Convert.ChangeType(routeValue, typeof(T));
                }

                return default;
            }
            catch
            {
                return default;
            }
        }
    }
}
