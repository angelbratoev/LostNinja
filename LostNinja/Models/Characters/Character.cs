using LostNinja.Models.Characters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.Models.Characters
{
    internal abstract class Character : ICharacter
    {
        public float healthPoints => throw new NotImplementedException();

        public float actionPoints => throw new NotImplementedException();

        public float attackPower => throw new NotImplementedException();

        public void Atack(ICharacter target)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(float damage)
        {
            throw new NotImplementedException();
        }
    }
}
