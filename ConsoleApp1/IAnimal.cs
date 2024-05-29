using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IAnimal
    {
        string Name { get; set; }
        int Value { get; set; }

        void SayName();
        void SayValue();
    }
}
