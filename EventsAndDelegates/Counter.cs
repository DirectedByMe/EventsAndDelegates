using System;

namespace Counter
{
    class Counter
    {
        static void Main(string[] args)
        {
            int[] Counter = new int[100];

            for (int value = 0; value <= 100; value++)
            {
                if (value == 69)
                {
                    Handler1 first = new Handler1();
                    Handler2 second = new Handler2();

                    first.H1 += FirstPhrase;
                    first.HandlerFirst(value);

                    second.H1 += SecondPhrase;
                    second.HandlerSecond(value);

                    static void FirstPhrase(string phrase)
                    {
                        Console.WriteLine(phrase);
                    }

                    static void SecondPhrase(string phrase)
                    {
                        Console.WriteLine(phrase);
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}
