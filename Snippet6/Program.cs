using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet6
{
    interface ITerresttrialAnimal
    {
        void Eat();
    }

    interface IMarineAnimal
    {
        void Swim();
    }
    class Crocodile : ITerresttrialAnimal,IMarineAnimal

    {       
        public void Eat()
        {
            Console.WriteLine("The crocodile eats flesh");
        }

        public void Swim()
        {
            Console.WriteLine("The crocodile can swim four times faters the an Olympic swimmer");
        }
         static void Main(string[] args)
        {
            Crocodile objCrocodile = new Crocodile();
            objCrocodile.Eat();
            objCrocodile.Swim();
            Console.ReadKey();
        }
    }
}
