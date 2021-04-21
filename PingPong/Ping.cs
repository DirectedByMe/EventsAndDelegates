using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    class Ping
    {

        public string ThrowPing()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);

            if (magicNumber > 2)
            {
                var pong = new Pong();

                Console.WriteLine("Ping получил Pong!");

                return pong.ThrowPong();
            }

            else
            {
                Console.WriteLine("Ping промахнулся! Победил Pong!");
                return null;
            }
        }
    }
}
