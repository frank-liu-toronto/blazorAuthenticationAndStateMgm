using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores
{
    public abstract class StoreBase<TState> 
    {
        public abstract TState GetState();

        public StoreBase(IActionDispatcher dispatcher)
        {            
            dispatcher.Register(HandleAction);
        }
        public abstract void HandleAction(IAction action);


        private Action _listeningers;        

        public void AddStateChangeListeners(Action listener)
        {
            _listeningers += listener;
        }

        public void RemoveStateChangeListener(Action listener)
        {
            _listeningers -= listener;
        }

        public void BroadcastStateChange()
        {
            _listeningers?.Invoke();
        }
        
        
    }
}
