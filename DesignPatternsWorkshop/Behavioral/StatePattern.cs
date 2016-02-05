using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsWorkshop.Behavioral
{
    /// <summary>
    /// Description: Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.
    /// </summary>
    public abstract class State
    {
        public abstract void Handle(ContextState contextState);
    }

    public class ConcreteStateA : State
    {
        public override void Handle(ContextState contextState)
        {
            contextState.State = new ConcreteStateB();
        }
    }

    public class ConcreteStateB : State
    {
        public override void Handle(ContextState contextState)
        {
            contextState.State = new ConcreteStateA();
        }
    }

    public class ContextState
    {
        private State _state;

        public ContextState(State state)
        {
            this.State = state;
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
