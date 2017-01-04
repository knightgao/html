using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0630test
{
    class Rectangle
    {
        private double length;
        private double width;

        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("长度： {0}", length);
            Console.WriteLine("宽度： {0}", width);
            Console.WriteLine("面积： {0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle();
            r.Display();
            Console.ReadLine();
        }
    }
}
