namespace Strategy
{
    public class CalculateRoute
    {
        private ICalculateRouteStrategy _strategy;
        public CalculateRoute(ICalculateRouteStrategy strategy) 
        { 
            _strategy = strategy;
        }
        public void SetStrategy(ICalculateRouteStrategy strategy)
        {
            _strategy = strategy;
        }
        public string ReturnRouteDescribtion(string pointA, string pointB)
        {
            string result = string.Join(",",_strategy.CalculateRoute(pointA, pointB).ToArray());
            return result;
        }
    }

    public interface ICalculateRouteStrategy
    {
        List<string> CalculateRoute(string pointA, string pointB);
    }

    public class BikeCalculateRouteStrategy : ICalculateRouteStrategy
    {
        public List<string> CalculateRoute(string pointA, string pointB)
        {
            List<string> result = new List<string>();
            result.Add("start - " + pointA);
            result.Add("przejażdżka rowerem");
            result.Add("koniec - " + pointB);
            return result;
        }
    }
    public class CarCalculateRouteStrategy : ICalculateRouteStrategy
    {
        public List<string> CalculateRoute(string pointA, string pointB)
        {
            List<string> result = new List<string>();
            result.Add("start - " + pointA);
            result.Add("droga samochodem");
            result.Add("skręć w lewo");
            result.Add("koniec - " + pointB);
            return result;
        }
    }
}
