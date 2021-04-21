using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Handler1
    {
        public delegate void FirstHandler(string h1);
        public event FirstHandler H1;

        public void HandlerFirst(int value)
        {
            H1?.Invoke($"Пора действовать, ведь уже {value}!");
        }
    }
}