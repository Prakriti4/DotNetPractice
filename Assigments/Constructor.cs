namespace LearningClasses
{ 
    public class Countr{ 
        public string Name { get; set; }
        public int Population { get; set; }
        public Countr()
        { 

        }
        public Countr(string name)
    { 
        Name = name;
    }
    public Countr(string name, int population)
    { 
        Name= name; 
        Population = population;
    }
    }
    public class Demo{ 
     public  void DoSomething()
    {
        Countr country1= new Countr();
        Countr country2= new Countr("Nepal");
        Countr country3= new Countr("Nepal", 300000000);

        Console.WriteLine("Country 1 - Name: " + country1.Name + ", Population: " + country1.Population);
        Console.WriteLine("Country 2 - Name: " + country2.Name + ", Population: " + country2.Population);
        Console.WriteLine("Country 3 - Name: " + country3.Name + ", Population: " + country3.Population);
    }

    }
}