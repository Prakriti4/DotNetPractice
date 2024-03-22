﻿using System; 
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

 
namespace ParallelAndAsync
{ 
   class Program
   { 
    static void Main1(string[] args)
    { 
    //TPL - Task Parallel Library
    int[] numbers ={23,45,12,56,78,43,54,65,32,21};

    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    foreach(var num in numbers)
    { 
        Compute(num);
    }
    Console.WriteLine($"Time taken (Sequential):{stopwatch.ElapsedMilliseconds} ms");
    //Parallel
    stopwatch.Restart();
    Parallel.ForEach(numbers,num=>{ 
            Compute(num);
    });
        Console.WriteLine($"Time taken (Parallel):{stopwatch.ElapsedMilliseconds} ms");
    }
    static void Compute(int x)
    {  
        Thread.Sleep(100);
        Console.WriteLine($"Computed for {x}");


    }
   }
}