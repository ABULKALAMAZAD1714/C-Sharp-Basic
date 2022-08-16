using System;
using System.Collections.Generic;

namespace Dictionary_AndHastableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> adictionary = new Dictionary<int, string>();
            adictionary.Add(1,"abul");
            adictionary.Add(2, "kalam");
            adictionary.Add(3, "azad");

            foreach (var data in adictionary)
            {
                Console.WriteLine(data);
            }
           
        }
    }
}
