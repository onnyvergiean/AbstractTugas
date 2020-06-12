using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract.Interface
{
    public class Vivipar : IHewan
    {
        public void deskriptif()
        {
            Console.WriteLine("Vivipar Hewan Beranak");
            Console.WriteLine("Contohnya Sapi, Kambing dan Kucing");
            Console.WriteLine();
        }
    }
}
