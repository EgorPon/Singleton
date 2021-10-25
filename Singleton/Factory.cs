using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Factory
    {
        public clothes clothes { get; set; }
        public void dressclothes(string name)
        {
            clothes = clothes.getInstance(name);
        }

    }
}
