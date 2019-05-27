using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique.Shape
{
    public class OtherPricer : IPricer
    {
        public int Price(int superficie)
        {
            return superficie * 4;
        }
    }
}
