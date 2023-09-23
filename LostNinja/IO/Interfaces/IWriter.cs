using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LostNinja.IO.Interfaces
{
    internal interface IWriter
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
