using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Atom
    {
        private int number;
        private string symbol;
        private string fullname;
        private float weight;
        

        public bool Accept()
        {
            System.Console.WriteLine("Enter atomic number: ");
            if(!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input.Please enter an interger for atomic number.");
                return false;
            }

            System.Console.WriteLine("Enter symbol: ");
            symbol = System.Console.ReadLine();

            System.Console.WriteLine("Enter full name: "); 
            fullname = System.Console.ReadLine();

            System.Console.WriteLine("Enter automic weight: ");
            if(!float.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Invalid input.Please enter a floating-point value atomic weight.");
                return false;
            }
            return true;
        }
        public void Display()
        {
            System.Console.WriteLine("Atomic number: " + number);
            System.Console.WriteLine("Atomic symbol: " + symbol);
            System.Console.WriteLine("Full name: " + fullname);
            System.Console.WriteLine("Atomic weight: " + weight);
            System.Console.WriteLine();
        }
    }
}
