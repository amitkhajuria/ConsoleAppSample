using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_ConApp
{

    public interface Shape
    {
     void draw();
    }

    //concrete classes implementing the  interface
    class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("class Circle method Draw");
        }
    }
    class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("class Reclangle method Draw");
        }
    }


    //Factory Class to generate object of concrete class based on given information.
    public class ShapeFactory
    {
        public Shape Createobject(string shapeType)
        {
            if (shapeType == null)
                return null;

            if (shapeType == "circle")
            {
                return new Circle();
            }
            if (shapeType == "reclangle")
            {
                return new Rectangle();
            }

            return null;
        }
    }

    
    //use factory class
    class Factory_CDP
    {
        public static void  Main1(string[] args)
        {
            ShapeFactory objFactory = new ShapeFactory();
            Shape shapeObjCir= objFactory.Createobject("circle");
            shapeObjCir.draw();

            Shape shapeObjRec = objFactory.Createobject("reclangle");
            shapeObjRec.draw();


            Console.ReadKey();
          }
    }
}
