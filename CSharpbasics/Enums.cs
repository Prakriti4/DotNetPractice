using System;
internal class Demo
{
    static void Main2(){ 
        Demo demo = new Demo();
        demo.dayofWeek = DayofWeek.Monday;
        demo.PrintGreetings();
    }
  public  enum DayofWeek{Sunday, Monday, Tuesday, Wednesday, Thursday, Friday,Saturday}
    public DayofWeek dayofWeek{get; set; }
    void PrintGreetings()
    {  

        if(dayofWeek == DayofWeek.Sunday)
        { 
            Console.WriteLine("Its a good  day"); 
        }
        else if(dayofWeek == DayofWeek.Monday)
        {
            Console.WriteLine("Its yet another weekend day");
        }
        else
        { 
            Console.WriteLine("Oh gosh, work day");
        }
    }
}