using System;

class SelectionStatement{ 

   static void Min(){ 
        SelectionStatement ss = new SelectionStatement (); 
      //   ss.LearnIfElse();
        ss.LearnSwitch();
    }
   void LearnIfElse()
   { 
    Console.Write("Enter any number:"); 
    string input = Console.ReadLine(); 
    byte x= byte.Parse(input);
    
     if(x==34)
     { 
        Console.WriteLine("I am Inside IF Statement");
     }
     else 
     { 
        Console.WriteLine("The given number isnot equal");
     }
   }
   void LearnSwitch(){ 
      char option ='p';
      switch(option)
      { 
         case'y':
         Console.WriteLine("You opted for no for relationships I hate this word as it sucks.");
         break;
         case'n':
         case'p':
         Console.WriteLine("You opted for None.");
         break;
          case'x':
          Console.WriteLine("You opted for Multiple.");
         break;
          case'z':
          Console.WriteLine("You opted for Zero.");
         break;
          case's':
          Console.WriteLine("You opted for Single.");
         break;
         default:
         Console.WriteLine("You opted for default.");
         break;
      }
   }
}