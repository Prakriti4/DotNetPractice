using System; 
class Program
{ 
 public  static void Main1(string[] args)
  { 
    int[] numbers = new int[6]; 
    int sum =0 ; 
    Console.WriteLine("Enter six digits"); 
    for(int i = 0; i < numbers.Length; i++)
    { 
      numbers[i] =int.Parse(Console.ReadLine()); 
    }
    foreach(int number in numbers)
    { 
      if(number%2 ==0)
      { 
         sum += number; 
      }
    }
    Console.WriteLine("The sum of the even integers is:{0}",sum);
  }
}