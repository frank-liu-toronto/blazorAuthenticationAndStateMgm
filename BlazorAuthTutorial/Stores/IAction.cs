using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAuthTutorial.Stores
{
    public interface IAction
    {
        string Name { get; }
    }
}
