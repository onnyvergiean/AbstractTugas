using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.AbstractClass
{
    public class Herbivora : Hewan
    {
        public override void Dekriptif()
        {
            Console.WriteLine("Herbivora Hewan Pemakan Tumbuhan");
            Console.WriteLine("Contohnnya Sapi, Kambing dan Kuda");
            Console.WriteLine();
        }

    }
}
