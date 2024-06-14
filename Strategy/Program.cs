using Strategy;

string start = "dom";
string end = "praca";

//Car
CalculateRoute ca = new CalculateRoute(new CarCalculateRouteStrategy());
Console.WriteLine(ca.ReturnRouteDescribtion(start, end));

//Bike
ca.SetStrategy(new BikeCalculateRouteStrategy());
Console.WriteLine(ca.ReturnRouteDescribtion(start, end));

Console.ReadKey();