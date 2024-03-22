using System;
using System.Threading;

namespace AsynchronousProgrammingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MakeTea();
            MakeBreakfast();
        }

        static void MakeTea()
        {
            TurnOnBurner();
            Console.WriteLine("Burner turned on");
            PutOnKettle();
            Console.WriteLine("Put kettle on burner");
            AddWater();
            Console.WriteLine("Added water in kettle");
            BoilWater();
            Console.WriteLine("Water boiled");
            GridMasala();
            Console.WriteLine("Tea masala grinded");
            AddSugarAndMasalas();
            Console.WriteLine("Added sugar and masala");
            AddMilk();
            Console.WriteLine("Added milk in the kettle");
            BoilIt();
            Console.WriteLine("Boiled it with low flame");
        }

        static void MakeBreakfast()
        {
            TurnOnBurner();
            Console.WriteLine("Burner turned on");
            PutOn("Pan");
            Console.WriteLine("Put on pan");
            Add("Oil");
            Console.WriteLine("Added oil");
            CrackAndStirEggs();
            Console.WriteLine("Cracked and stirred eggs");
            Fry();
            Console.WriteLine("Fried eggs");
            Serve();
            Console.WriteLine("Served the breakfast!");
        }

        static void TurnOnBurner()
        {
            Thread.Sleep(2000);
        }

        static void PutOnKettle()
        {
            Thread.Sleep(2000);
        }

        static void AddWater()
        {
            Thread.Sleep(2000);
        }

        static void BoilWater()
        {
            Thread.Sleep(10000);
        }

        static void GridMasala()
        {
            Thread.Sleep(2000);
        }

        static void AddSugarAndMasalas()
        {
            Thread.Sleep(2000);
        }

        static void AddMilk()
        {
            Thread.Sleep(2000);
        }

        static void BoilIt()
        {
            Thread.Sleep(2000);
        }

        static void PutOn(string name)
        {
            Thread.Sleep(2000);
        }

        static void Serve()
        {
            Thread.Sleep(10000);
        }

        static void Fry()
        {
            Thread.Sleep(2000);
        }

        static void CrackAndStirEggs()
        {
            Thread.Sleep(2000);
        }

        static void Add(string oil)
        {
            Thread.Sleep(2000);
        }
    }
}
