using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void Handle(int projectDelayInDays);
    }
    public class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;
        public virtual void Handle(int projectDelayInDays)
        {
            if (this._nextHandler != null)
            {
                this._nextHandler.Handle(projectDelayInDays);
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
