using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet2
{   
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Every animal eat food in order to survice");
        }
        public abstract void AnimalSound();
    }

    class Lion : Animal
    {
        public override void AnimalSound()
        {
           
            Console.WriteLine("Lion Roar");
        }
        static void Main(string[] args)
        {
            Lion objLion = new Lion();
            objLion.AnimalSound();
            objLion.Eat();
            Console.ReadKey();
        }
    }
}
