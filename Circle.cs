using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterDemo
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle :: draw()");
        }
    }
}
