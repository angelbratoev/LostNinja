using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.Models.Characters.Interfaces
{
    internal interface ICharacter
    {
        float HealthPoints { get; }
        float ActionPoints { get; }
        float AttackPower { get; }

        void Atack(ICharacter target);
        void TakeDamage(float damage);
    }
}
