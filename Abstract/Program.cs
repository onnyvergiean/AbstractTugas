using System;
using Abstract.AbstractClass;
using Abstract.Interface;

namespace Abstract{
    class Program
    {
        static void Main(string[] args)
        {
            Hewan hewan;

            hewan = new Herbivora();
            hewan.Dekriptif();

            hewan = new Karnivora();
            hewan.Dekriptif();

            hewan = new Omnivora();
            hewan.Dekriptif();


            IHewan Ihewan;

            Ihewan = new Vivipar();
            Ihewan.deskriptif();

            Ihewan = new Ovipar();
            Ihewan.deskriptif();

            Ihewan = new Ovovivipar();
            Ihewan.deskriptif();

            Console.ReadKey();
        }
    }
}
