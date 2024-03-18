public class MethodTeacher
{ 
  public  static void Mainr()
    { 
        MethodTeacher methodTeacher = new MethodTeacher();
        double sum= methodTeacher.Sum(2345.56,23452.1);
        Console.WriteLine($"Sum is{sum}");
    }
   public  double Sum(double firstNum, double secondNum)
    { 
       return  firstNum + secondNum; 
    }
}