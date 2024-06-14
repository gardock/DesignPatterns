using Facade;

string pointA = "Białystok";
string pointB = "Łódź";

var flightBookingFacade = new FlightBookingFacade();
flightBookingFacade.FindAndBookNearestFlight(pointA, pointB);

Console.ReadKey();