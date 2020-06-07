using System;

namespace FactoryDesignPatterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Rectangle
            IShape shape1= shapeFactory.getShape("Rectangle");
            shape1.Draw();

            //get an object of Circle
            IShape shape2 = shapeFactory.getShape("Circle");
            shape2.Draw();

            //get an object of Square
            IShape shape3 = shapeFactory.getShape("Square");
            shape3.Draw();

            Console.Read();
        }
    }
}
