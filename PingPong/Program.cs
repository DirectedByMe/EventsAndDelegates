using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            var ping = new Ping();
            var pong = new Pong();

            for (int value = 1; value <= 100; value++)
            {
                ping.ThrowPing();
                pong.ThrowPong();

                Console.WriteLine("Game Over!");
                Console.ReadLine();
            }
        }
    }
}
