using System.ComponentModel.DataAnnotations;

namespace Geometri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri rektangel = new Rektangel(); // Skapar formerna
            Geometri fyrkant = new Fyrkant();
            Geometri cirkel = new Cirkel();
            Geometri parallellogram = new Parallellogram();
            Geometri ellips = new Ellips();
            {
                Console.WriteLine("Arean av Rektangel: " + rektangel.Area()); // Skriver ut arean av alla formerna
                Console.WriteLine("Arean av Fyrkant: " + fyrkant.Area());
                Console.WriteLine("Arean av Cirkel: " + cirkel.Area());
                Console.WriteLine("Arean av Parallellogram: " + parallellogram.Area());
                Console.WriteLine("Arean av Ellips: " + ellips.Area());
            }
        }
    }

    public class Geometri // Basklassen för formerna
    {
        public virtual double Area() // Metod för arean
        {
            return 0;
        }
    }

    public class Rektangel : Geometri // Underklass
    {
        public double Lenght { get; set; } // Egenskaper som behövs för att räkna ut arean
        public double Width { get; set; }

        public Rektangel() // Konstruktor som sätter värde
        {
            Lenght = 10;
            Width = 20;
        }

        public override double Area() // Åsidosätter Area metoden från basklassen
        {
            return Lenght * Width; // Räknar ut arean
        }
    }

    public class Fyrkant : Geometri
    {
        public double Side { get; set; }

        public Fyrkant()
        {
            Side = 5;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }

    public class Cirkel : Geometri
    {
        public double Radius { get; set; }

        public Cirkel()
        {
            Radius = 2;
        }

        public override double Area()
        {
            return double.Pi * Radius * Radius;
        }
    }

    public class Parallellogram : Geometri
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Parallellogram()
        {
            Base = 6;
            Height = 9;
        }

        public override double Area()
        {
            return Base * Height;
        }
    }

    public class Ellips : Geometri
    {
        public double Semimajoraxis { set; get; }
        public double Semiminoraxis { get; set; }

        public Ellips()
        {
            Semimajoraxis = 10;
            Semiminoraxis = 5;
        }

        public override double Area()
        {
            return double.Pi * Semimajoraxis * Semiminoraxis;
        }

    }
}