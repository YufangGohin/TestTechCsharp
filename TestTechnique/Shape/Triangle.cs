using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique.Shape
{
    public class Triangle: ShapeBase
    {  
        public Triangle(string nom, int superface)
        {
            this.Shape = "Triangle";
            this.Nom = nom;
            this.Superface = superface; 
        }
      
    }
}
