using LostNinja.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.Repositories
{
    internal class Inventory<IItem> : IRepository<IItem>
    {
        public IReadOnlyCollection<IItem> Items => throw new NotImplementedException();

        public void AddItem(IItem item)
        {
            throw new NotImplementedException();
        }

        public IItem GetItem(string itemName)
        {
            throw new NotImplementedException();
        }

        public bool RemoveItem(IItem item)
        {
            throw new NotImplementedException();
        }
    }
}
