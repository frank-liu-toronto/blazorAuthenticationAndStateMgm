using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores
{
    public interface IActionDispatcher
    {        
        void Register(Action<IAction> actionHandler);
        void Unregister(Action<IAction> actionHandler);
        void Dispatch(IAction action);
    }
}
