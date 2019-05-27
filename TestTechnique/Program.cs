using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTechnique.Shape;

namespace TestTechnique
{
    static class ShapeFactory
    {
        public static ShapeBase getInstance(string type, string name, int superFace)
        {
            switch (type)
            {
                case "Cercle":
                    return new Cercle(name, superFace);
                case "Triangle":
                    return new Triangle(name, superFace);
                default:
                    return new Square(name, superFace);
            }
        }
    }

    class Program
    {
        /*Author Yufang GOHIN; Date 07/01/2017*/
        static void Main(string[] args)
        {
            //-Cercle – Nom1 - 12 cm² -Cercle – Nom2 - 15 cm² -Triangle – Nom3 - 16 cm² 
            IPricer calculatePrice = new Pricer();
            var list = new List<ShapeBase>(); 
            list.Add(ShapeFactory.getInstance("Cercle", "Nom1", 12));
            list.Add(ShapeFactory.getInstance("Cercle", "Nom2", 15));
            list.Add(ShapeFactory.getInstance("Triangle", "Nom3", 16));

            PrintListShape(list,1);
            Console.WriteLine("---------------------------------------------------------");
            string line = Console.ReadLine();
            
            
            if (args != null)
            {
                var shapeService = new Service();
                shapeService.AddShape(ref list, line);
                if (list.Count > 3)
                    PrintListShape(list,1);
            }
            Console.WriteLine("---------------------------------------------------------");
            string json = JsonConvert.SerializeObject(list.ToArray());

            string filePath = ConfigurationManager.AppSettings["FilePath"];
            bool exists = System.IO.Directory.Exists(filePath);

            if (!exists)
                System.IO.Directory.CreateDirectory(filePath);
            //write string to file
            System.IO.File.WriteAllText(filePath+ "collection.json", json);

            //Exemple d’utilisation : var pricer = new Pricer(); var superficie = 5; var cout = pricer.Price(superficie)
            //list.ForEach((shape) => shape.Calcule = new Pricer());

            PrintListShape(list,2);
            Console.WriteLine("---------------------------------------------------------");

            //list.ForEach((shape) => shape.Calcule = new OtherPricer());

            PrintListShape(list, 3);
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();
        }
        
        private static void PrintListShape(List<ShapeBase> shapeList, int choix)
        {
            if(choix ==1)
               shapeList.ForEach((shape) => { Console.WriteLine("-" + shape.Shape + " - " + shape.Nom + " - " + shape.Superface + "cm²-"); });
            else if (choix == 2)
               shapeList.ForEach((shape) => { Console.WriteLine("-" + shape.Shape + " - " + shape.Nom + " - " + shape.Superface + "cm²" + " - Estimation cout: " + shape.CalculeCout(new Pricer()).ToString() + "-"); });
            else
               shapeList.ForEach((shape) => { Console.WriteLine("-" + shape.Shape + " - " + shape.Nom + " - " + shape.Superface + "cm²" + " - Estimation cout: " + shape.CalculeCout(new OtherPricer()).ToString() + "-"); });
        }
         
    }
}
