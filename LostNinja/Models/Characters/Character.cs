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
        private float healthPoints;
        private float actionPoints;
        private float attackPower;

        public Character()
        {
            
        }

        public float HealthPoints => throw new NotImplementedException();

        public float ActionPoints => throw new NotImplementedException();

        public float AttackPower => throw new NotImplementedException();

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
