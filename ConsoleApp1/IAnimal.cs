using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface IAnimal
    {
        // there can not be any private signature in an interface, it has to be a public or public can be deleted
        // example public string Name { get; set; }

        // signature property
        string Name { get; set; }
        int Value { get; set; }

        // signature method
        void SayName();
        void SayValue();
    }
}
