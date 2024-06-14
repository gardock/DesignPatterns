namespace ChainOfResponsibility.ConcreteHandlers
{
    public class ProjectManagerHandler : AbstractHandler
    {
        public override void Handle(int projectDelayInDays)
        {
            if (projectDelayInDays < 10)
            {
                Console.WriteLine("PM notuje lekkie opóżnienie");
            }
            else
            {
                base.Handle(projectDelayInDays);
            }
        }
    }
}
