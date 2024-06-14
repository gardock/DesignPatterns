namespace ChainOfResponsibility.ConcreteHandlers
{
    public class DirectorHandler : AbstractHandler
    {
        public override void Handle(int projectDelayInDays)
        {
            Console.WriteLine("Brak premii");
        }
    }
}
