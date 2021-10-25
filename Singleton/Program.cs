using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory fact = new Factory();
            fact.dressclothes("sport suit");
            Console.WriteLine(fact.clothes.Name);
          
        }
    }
}
