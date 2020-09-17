using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores.CounterStore
{
    public class DecreaseAction : IAction
    {
        public const string DECREASE_ACTION = "DECREASE_ACTION";
        public string Name { get => DECREASE_ACTION; }
    }
}
