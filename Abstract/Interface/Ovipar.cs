using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Interface
{
    public class Ovipar : IHewan
    {
        public void deskriptif()
        {
            Console.WriteLine("Ovipar Hewan Bertelur");
            Console.WriteLine("Contoh Ular, Penyu dan Itik");
            Console.WriteLine();
        }
    }
}
