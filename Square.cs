using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDesignPatterDemo
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square :: draw()");
        }
    }
}
