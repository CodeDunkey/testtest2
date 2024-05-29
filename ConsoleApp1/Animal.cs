using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public int Value { get; set; }

        protected Animal(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public void SayName()
        {
            Console.WriteLine($"my name is {Name} ");
        }
        public void SayValue()
        {
            Console.Write($"my value is {Value} ");
        }
    }
}
