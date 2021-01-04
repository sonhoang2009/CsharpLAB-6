using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet11
{   
    interface ISet
    {
        void AcceptDetails(int valueOne, string valTwo);
    }

    interface IGet
    {
        void Display();
    }
    class Employee : ISet
    {
        int _empID;
        string _empName;
        public void AcceptDetails(int valOne, string valTwo)
        {
            _empID = valOne;
            _empName = valTwo;
        }
        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            objEmployee.AcceptDetails(10, "jack");
            IGet objGet = objEmployee as IGet;
            if(objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }
            Console.ReadKey();
        }
    }
}
