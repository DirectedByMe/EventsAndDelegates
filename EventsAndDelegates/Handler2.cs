using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Handler2
    {
        public delegate void SecondHandler(string h1);
        public event SecondHandler H1;

        public void HandlerSecond(int value)
        {
            H1?.Invoke($"Уже {value}, давно пора было начать!");
        }
    }
}
