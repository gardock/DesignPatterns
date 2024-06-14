using Builder;

Director director = new Director();
director.SetPizzaBuilder(new MargheritaPizzaBuilder());
director.ConstructPizza();
var margherita = director.GetPizza();
Console.WriteLine(margherita.ToString());


director.SetPizzaBuilder(new CheesyPizzaBuilder());
director.ConstructPizza();
director
    .AddExtraGouda()
    .AddExtraOlives();

var cheesy = director.GetPizza();
Console.WriteLine(cheesy.ToString());

Console.ReadKey();