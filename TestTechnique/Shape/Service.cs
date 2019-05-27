using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTechnique.Shape
{
    public class Service
    {
        public List<ShapeBase> AddShape(ref List<ShapeBase> listShape, string addString)
        {
            string[] items = addString.Split(' ');
            int value;  
            if(items.Length == 3 && int.TryParse(items[2], out value))
            switch (items[0].ToString().ToUpper())
            { 
                case "CERCLE":
                    listShape.Add(new Cercle(items[1], value));
                    break;
                case "TRIANGLE":
                    listShape.Add(new Triangle(items[1], value));
                    break;
                case "SQUARE":
                    listShape.Add(new Square(items[1], value));
                    break;
                default:
                    Console.WriteLine("Saisie non valide");
                    break;
            }
            return listShape;
        }
    }
}
