using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class clothes
    {
        private static clothes instance;
        public string Name{get; set;}
        public clothes(string n)
        {
            Name = n;
        }
        public static clothes getInstance(string n)
        {
            if (instance == null)
                instance = new clothes(n);
            return instance;
        }
    }
}
