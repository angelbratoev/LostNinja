using LostNinja.Models.Characters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.Core.Interfaces
{
    internal interface IController
    {
        bool InitiateCombat(ICharacter player, params ICharacter[] enemy);
    }
}
