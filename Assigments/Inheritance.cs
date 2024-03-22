using System;
using System.Reflection.Metadata;
public abstract class Shape{ 
    public abstract double GetArea();
    public abstract double GetCircumference();
}
/*
public class Square: Shape
{ 
    public double Side { get; set; }

    public override double GetArea()=>Side *Side;
    public override double GetCircumference()=>4*Side;
} 
*/
public class Rectangle: Shape
{ 
    public double Length{ get; set; }
    public double Breadth{ get; set; }
    public override double GetArea()
    =>Length*Breadth;
    public override double GetCircumference()=>2*(Length + Breadth);
    
}
public class Square :Rectangle
{ 
    public Square(double side)
    {
        base.Length=side; 
        base.Breadth=side;
    }
}
public class Circle: Shape 
{ 
    // public  const double PI =3.1414;
    public double radius { get; set; }
    public override double GetArea()=> Math.PI *radius*radius;
    public override double GetCircumference()=>2*Math.PI*radius;  
}