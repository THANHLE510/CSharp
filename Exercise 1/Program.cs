using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atom[] atoms = new Atom[10];
            int count = 0;

            while (count < 10)
            {
                Atom atom = new Atom();
                if(atom.Accept())
                {
                    atoms[count] = atom;    
                    count++;
                }
                else
                {
                    Console.WriteLine("Invalid input.Please try again");
                }
            }
            Console.WriteLine("Automic Information");
            Console.WriteLine(".....................");
            for(int i = 0; i < count;i++) 
            {
                atoms[i].Display();
            }
        }
    }
}
