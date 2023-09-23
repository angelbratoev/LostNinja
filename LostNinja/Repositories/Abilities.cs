using LostNinja.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.Repositories
{
    internal class Abilities<IAbility> : IRepository<IAbility>
    {
        public IReadOnlyCollection<IAbility> Items => throw new NotImplementedException();

        public void AddItem(IAbility item)
        {
            throw new NotImplementedException();
        }

        public IAbility GetItem(string itemName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveItem(IAbility item)
        {
            throw new NotImplementedException();
        }
    }
}
