using System; 
using System.Linq;
namespace LINQ.Learning{
class Program
{ 
    static void Main(string[] args)
    { 
        //LINQ language Integrated Query
        int[] numbers = {12, 34,23, 67, 445, 68, 10,89,26,123,43542 };

         //Method Syntax
        var result1 = numbers.Where(numbers =>numbers > 50).Select(numbers =>numbers);
         //Query expression syntax
         var result2 = from num in numbers 
                        where num>50
                        select num;

        //Restrictions Where
           var result3 = from num in numbers 
                        where num>50 && num<70
                        select num;
        //Projections = select     
        var result4 = from num in numbers 
                      where num%2 == 0 
                      select num *num;  
        //Ordering :order by operator
        var results = from num to numbers orderby         
                      num select num; 
        //To take five digits from starting
        var result6 = numbers.Take(5);
        // to skip first five digits nd the to take next 5 digits 
        var result7 = numbers.Skip(5).Take(5); 
        //Quantifiers : any, all, contains    
        var result8= numbers.Any(numbers=>numbers%2==0 );
        var result9 = numbers.All(numbers=>numbers%2==0); 
        var result10 = numbers.Contains(34); 

        //Enumerable Generations Range        
        var result11 =  Enumerable.Range(1,1000);   
        var result12 = Enumerable.Repeat("Hello Word",20);
                   
    }
}
}