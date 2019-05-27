using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique.Shape
{
    public class Square: ShapeBase
    { 
        public Square(string nom, int superface)
        {
            this.Shape = "Square";
            this.Nom = nom;
            this.Superface = superface;
        }
    }
}
