using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong
{
    public class Pong
    {
        public string ThrowPong()
        {
            var ping = new Ping();

            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);

            if (magicNumber > 2)
            {
                Console.WriteLine("Pong получил Ping!");
                return ping.ThrowPing();
            }
            else
            {
                Console.WriteLine("Pong промахнулся! Победил Ping!");
                return null;
            }

        }
    }
}
