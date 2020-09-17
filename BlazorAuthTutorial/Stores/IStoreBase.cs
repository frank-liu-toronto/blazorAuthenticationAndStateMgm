using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores
{
    public interface IStoreBase<TState>
    {
        TState GetState { get; }

        void AddStateChangeListeners(Action listener);

        void RemoveStateChangeListener(Action listener);

        protected void BroadcastStateChange();

        protected void HandleAction(IAction action);
        
    }
}
