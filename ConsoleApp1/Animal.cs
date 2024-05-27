using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Animal(string name, int value) { 
            Name = name;
            Value = value;
        }

        public SayName(string name) {
            Console.WriteLine($"my name is {name}");
        }
        public SayValue(int value)
        {
            Console.WriteLine($"my value is {value}");
        }
    }
