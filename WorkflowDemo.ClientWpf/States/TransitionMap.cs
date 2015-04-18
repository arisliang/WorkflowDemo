using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowDemo.ClientWpf.Models;
using WorkflowDemo.ClientWpf.ViewModels;

namespace WorkflowDemo.ClientWpf.States
{
    public class TransitionMap : Dictionary<Type, Dictionary<StateTransition, Type>>
    {
        public void AddTransition<TIdentity, TResponse>(StateTransition transition)
            where TIdentity : IScreen
            where TResponse : IScreen
        {
            var identity = typeof(TIdentity);
            var response = typeof(TResponse);
            if (!ContainsKey(identity))
            {
                var value = new Dictionary<StateTransition, Type>();
                value.Add(transition, response);
                Add(identity, value);
            }
            else
            {
                this[typeof(TIdentity)].Add(transition, response);
            }
        }

        [Obsolete]
        public IScreen GetNextScreen<TIdentity>(StateTransition transition)
        {
            var identity = typeof(TIdentity);
            if (!ContainsKey(identity))
            {
                throw new InvalidOperationException(string.Format("There are no states transitions defined for state {0}", identity.ToString()));
            }

            if (!this[identity].ContainsKey(transition))
            {
                throw new InvalidOperationException(string.Format("There is response setup for transition {0} from screen {1}", transition.ToString(), identity.ToString()));
            }

            return this[identity][transition] as IScreen;
        }

        public Type GetNextScreenType(BaseViewModel screenClosed)
        {
            var identity = screenClosed.GetType();
            var transition = screenClosed.NextTransition;

            if (!ContainsKey(identity))
            {
                throw new InvalidOperationException(string.Format("There are no states transitions defined for state {0}", identity.ToString()));
            }

            if (!this[identity].ContainsKey(transition))
            {
                throw new InvalidOperationException(string.Format("There is response setup for transition {0} from screen {1}", transition.ToString(), identity.ToString()));
            }

            return this[identity][transition];
        }
    }
}
