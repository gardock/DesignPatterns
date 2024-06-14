namespace ChainOfResponsibility.ConcreteHandlers
{
    public class TeamLeaderHandler : AbstractHandler
    {
        public override void Handle(int projectDelayInDays)
        {
            if (projectDelayInDays < 3)
            {
                Console.WriteLine("Nic się nie dzieje - pracujemy dalej");
            }
            else
            {
                base.Handle(projectDelayInDays);
            }
        }
    }
}
