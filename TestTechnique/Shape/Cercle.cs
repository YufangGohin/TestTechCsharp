using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique.Shape
{
    public class Cercle: ShapeBase
    { 
        public Cercle(string nom, int superface)
        {
            this.Shape = "Cercle";
            this.Nom = nom;
            this.Superface = superface; 
        }
    }
}
