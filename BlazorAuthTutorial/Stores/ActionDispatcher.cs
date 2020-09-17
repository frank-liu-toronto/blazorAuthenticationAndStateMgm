using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores
{
    public class ActionDispatcher : IActionDispatcher
    {
        private Action<IAction> _registeredStores;

        public void Register(Action<IAction> actionHandler)
        {
            _registeredStores += actionHandler;
        }

        public void Unregister(Action<IAction> actionHandler)
        {
            _registeredStores -= actionHandler;
        }

        public void Dispatch(IAction action)
        {
            _registeredStores?.Invoke(action);
        }
    }
}
