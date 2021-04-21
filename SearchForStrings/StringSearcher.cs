using System;
using System.Collections.Generic;

namespace SearchForStrings
{
    public class StringSearcher
    {
        public delegate void Searcher(string s1);
        public event Searcher S1;

        public List<string> list = new() { "First Line", "Second Line", "Third Line", "Fourth Line", "Fifth Line" };

        public void Search()
        {
            string lineNumber = "Third Line";

            for (int value = 0; value < list.Count; value++)
            {
                if (string.Equals(lineNumber, list[value]))
                {
                    S1?.Invoke($"{lineNumber}");
                }
            }
        }
    }
}
