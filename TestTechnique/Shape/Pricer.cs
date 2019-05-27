using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique.Shape
{
    public class Pricer : IPricer
    {
        public int Price(int superficie)
        {
            return superficie * 2;
        }
    }
}
