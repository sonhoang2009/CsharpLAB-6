using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet10
{
    interface ICalculate
    {
        double Area();
    }
    class Retangle : ICalculate
    {

        float _length;
        float _breadth;
        public Retangle(float valueOne, float valueTwo)
        {
            _length = valueOne;
            _breadth = valueTwo;
        }

        public double Area()
        {
            return _length * _breadth;
        }
        static void Main(string[] args)
        {
            Retangle objRetacgle = new Retangle(10.2F,20.3F);
            if (objRetacgle is ICalculate)
            {
                Console.WriteLine("Area of Rectangle :{0:F2}", objRetacgle.Area());
            }
            else
            {
                Console.WriteLine("Interface method not implement");
            }
            Console.ReadKey();

        }

    }
}
 

