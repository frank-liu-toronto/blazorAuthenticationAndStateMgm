using BlazorAuthTutorial.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores.CounterStore
{
    public class CounterState
    {
        public CounterState(int count)
        {
            this.Count = count;
        }
        public int Count { get; }
    }

    public class CounterStore : StoreBase<CounterState>
    {
        private CounterState _state;

        public CounterStore(IActionDispatcher dispatcher):base(dispatcher)
        {
            _state = new CounterState(0);
        }

        public override CounterState GetState()
        {
            return _state;
        }

        private void IncrementCount()
        {
            var count = this._state.Count;
            count++;
            this._state = new CounterState(count);
            base.BroadcastStateChange();
        }

        private void DecrementCount()
        {
            var count = this._state.Count;
            count--;
            this._state = new CounterState(count);
            base.BroadcastStateChange();
        }

        public override void HandleAction(IAction action)
        {
            switch (action.Name)
            {
                case IncreaseAction.INCREASE_ACTION:
                    IncrementCount();
                    break;
                case DecreaseAction.DECREASE_ACTION:
                    DecrementCount();
                    break;
                default:
                    break;
            }

        }

        
    }
}
