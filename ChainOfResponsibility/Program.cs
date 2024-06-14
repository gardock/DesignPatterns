using ChainOfResponsibility.ConcreteHandlers;

var teamLeader = new TeamLeaderHandler();
var pm = new ProjectManagerHandler();
var director = new DirectorHandler();

teamLeader.SetNext(pm).SetNext(director);

int delayInDays = 2;
Console.WriteLine($"Opónienie: {delayInDays}");
teamLeader.Handle(delayInDays);

delayInDays = 5;
Console.WriteLine($"Opónienie: {delayInDays}");
teamLeader.Handle(delayInDays);

delayInDays = 15;
Console.WriteLine($"Opónienie: {delayInDays}");
teamLeader.Handle(delayInDays);


Console.ReadKey();