using System;

public class FunctionOverloading
{
    public double Sum(double a, double b)
    {
        return a + b;
    }

    public double Sum(params double[] numbers)
    {
        double sum = 0;
        foreach (double num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public static void Main()
    {
        FunctionOverloading obj = new FunctionOverloading();
        double s = obj.Sum(12.3, 23.5);
        double a = obj.Sum(1, 2, 3, 4, 5);
        Console.WriteLine("The sum is {0}", s);
        Console.WriteLine("The sum is {0}", a);
    }

    //Returning multiple value -Using tuples
    //Example: Method to find min and max from set of numbers. 
    (int, int)FindMinMax(int[] numbers)
    { 
        int min= numbers[0];
        int max= numbers[0];

        foreach(int num in numbers)
        { 
            if(num<min)
            min= num; 
            if(num>max)
            max= num; 
        }
         return (min, max);
    }
} 
