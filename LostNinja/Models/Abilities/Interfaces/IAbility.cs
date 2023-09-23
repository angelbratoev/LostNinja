using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.Models.Abilities.Interfaces
{
    internal interface IAbility
    {
        float power { get; }
        float cost { get; }

        string Description();
    }
}
