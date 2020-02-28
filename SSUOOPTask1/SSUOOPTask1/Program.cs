using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSUOOPTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid obj = new Pyramid(new PointY(0,0),new PointY(0,5), new PointY(5,5), new PointY(5,0), new PointZ(2.5,2.5,13.0));
            Console.WriteLine("Периметр {0}, площадь основания {1}, Объем {2}",obj.FoundationPerimeter, obj.FoundationSquare, obj.V());
            Console.ReadLine();
        }
    }
}
