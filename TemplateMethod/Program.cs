using TemplateMethod;

Beverage tea = new Tea();
tea.Prepare();

Console.WriteLine();

Beverage coffe = new Coffe();
coffe.Prepare();

Console.ReadKey();