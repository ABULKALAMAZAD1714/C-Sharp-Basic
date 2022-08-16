using System;
using System.Collections;

namespace hastable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable aHastable = new Hashtable();
            aHastable.Add(" 1","one");
            aHastable.Add(2,2);
            aHastable.Add(3,3.5);
            aHastable.Add(123,90);
            foreach (var data in aHastable)
            {
                Console.WriteLine(data);
            }
           
        }
    }
}
