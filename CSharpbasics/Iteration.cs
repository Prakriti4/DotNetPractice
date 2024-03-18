using System;
class IterationStatement {
    static void Main1()
    { 
        IterationStatement statement = new IterationStatement(); 
        statement.LearnForLoop(); 
         statement.LearnWhileLoop(); 
    }

    void LearnForLoop()
    { 
        for(int i=0; i<10;i++)
        {
            Console.WriteLine("I am beautiful");
        }
        int[] numbers ={34,2,5,6,72,45};

        foreach (int x in numbers){ 
            if(x%2 == 0){
          Console.WriteLine($"{x} is even number");
        }
        else
        { 
            Console.WriteLine($"{x} is odd number");
        }
    }

}
 void LearnWhileLoop()
 { 
    char confirm = 'y';
    while(confirm=='y')
    { 
        Console.WriteLine("I am beautiful");
        Console.WriteLine("Print one more time?"); 
        confirm =Console.ReadKey().KeyChar; 
        
    }
 }
}