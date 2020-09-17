using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores.CounterStore
{
    public class IncreaseAction : IAction
    {
        public const string INCREASE_ACTION = "INCREASE_ACTION";
        public string Name { get => INCREASE_ACTION; }
    }
}
