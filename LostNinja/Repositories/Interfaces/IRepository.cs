using LostNinja.Models.Items.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.Repositories.Interfaces
{
    internal interface IRepository<T>
    {
        IReadOnlyCollection<T> Items { get; }

        void AddItem(T item);
        bool RemoveItem(T item);
        T GetItem(string itemName);
    }
}
