using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique.Shape
{
    public abstract class ShapeBase
    {
        public string Shape { get; set; }
        public string Nom { get; set; }
        public int Superface { get; set; }

        public int CalculeCout(IPricer price)
        {
            if (null != price)
                return price.Price(this.Superface);
            else
                return 0;
        }
    }

}
