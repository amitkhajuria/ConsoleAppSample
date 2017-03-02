using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_ConApp
{

    //Interface Shape
    public interface ShapeAF
    {
        void draw();
    }
    public class RectangleAF : ShapeAF
    {
        public void draw()
        {
            Console.WriteLine("Rectangle Draw");
        }
    }
    public class SquareAF : ShapeAF
    {
        public void draw()
        {
            Console.WriteLine("Square Draw");
        }
    }
    public class CircleAF : ShapeAF
    {
        public void draw()
        {
            Console.WriteLine("Circle Draw");
        }
    }




    //interface Color

    public interface ColorAF
    {
        void fill();
    }

    public class Green : ColorAF
    {
        public void fill()
        {
            Console.WriteLine("Green Fill");
        }
    }

    public class Red : ColorAF
    {
        public void fill()
        {
            Console.WriteLine("Red Fill");
        }
    }
    public class Blue : ColorAF
    {
        public void fill()
        {
            Console.WriteLine("Blue Fill");
        }
    }


    //Create an Abstract class to get factories for Color and Shape Objects.
    public abstract class AbstractFactory
    {
        public abstract ColorAF getColor(string color);
        public abstract ShapeAF getShape(string shape);
    }

    //Create Factory classes extending AbstractFactory
    public class ShapeFactoryAF : AbstractFactory
    {
        public override ShapeAF getShape(string shapeType)
        {
            if (shapeType == null)
                return null;
            if (shapeType == "circle")
                return new CircleAF();
            if (shapeType == "rectangle")
                return new RectangleAF();
            if (shapeType == "square")
                return new SquareAF();

            return null;
        }
        public override ColorAF getColor(string color)
        {
            return null;
        }
    }

    public class ColorFactoryAF : AbstractFactory
    {
        public override ColorAF getColor(string color)
        {
            if (color == "red")
                return new Red();
            if (color == "green")
                return new Green();
            if (color == "blue")
                return new Blue();

            return null;
        }
        public override ShapeAF getShape(string shape)
        {
           return null;
        }
    }

    //Factory generator/producer class to get factories by passing an information such as Shape or Color

    public class Factoryproducer
    {
     public static AbstractFactory getFactory(string choice)
     {
            if (choice == "shape")
                return new ShapeFactoryAF();
            if (choice == "color")
                return new ColorFactoryAF();

            return null;
        }
    }
    class AbstractFactory_CDP
    {
        public static void Main(string[] args)
        {
            //get Shape Factory
            AbstractFactory shapeFactory = Factoryproducer.getFactory("shape");

            //shape Object
            ShapeAF shape1 = shapeFactory.getShape("circle");

            shape1.draw();

            //shape     
            ShapeAF shape2 = shapeFactory.getShape("rectangle");
            shape2.draw();

            ShapeAF shape3 = shapeFactory.getShape("square");
            shape3.draw();


            //get color Factory

            AbstractFactory colorFactory = Factoryproducer.getFactory("color");

            ColorAF color1 = colorFactory.getColor("red");

            color1.fill();

            ColorAF color2 = colorFactory.getColor("green");
            color2.fill();

            ColorAF color3 = colorFactory.getColor("blue");
            color3  .fill();

            Console.ReadKey();
        }
    }
}
