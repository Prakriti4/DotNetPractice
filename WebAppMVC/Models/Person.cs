// using System.Collections.Generic;
#pragma warning disable CA1050 // Declare types in namespaces
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

public class Person
#pragma warning restore CA1050 // Declare types in namespaces
{
    // Implementation to return list of employees
    public int Id { get; set; }
    [Required]
    [Display(Name ="First Name")]
     public string FirstName { get; set; }
     [Required]
     [Display(Name ="Last Name")]
    public string Surname { get; set; } 

    public string? Address { get; set; }
    public char? Gender { get; set; }
    public double? Salary { get; set; }
       public Person(int id, string firstName, string surname, string address, char gender, double salary)
    {
        Id = id;
        FirstName = firstName;
        Surname = surname;
        Address = address;
        Gender = gender;
        Salary = salary;
    }
    public static List<Person> GetEmployee()
    { 
               //Object initializer syntax
         Person emp1=   new(1, "Prakriti", "Khatiwada", "Kapan", 'F', 34953845.00);
         Person emp2=   new(2, "Prapanna", "Bista", "Taudaha", 'M', 12953845.00);
         Person emp3=   new(3, "Pranav", "Yadav", "Baneshwor", 'M', 353845.00);
         Person emp4=   new(4, "Anisha", "Limbu", "Panitanki", 'F', 4953845.00);
         Person emp5=   new(5, "Joshna", "Basnet", "Panauti", 'F', 845.00);
         Person emp6=   new(6, "Samrat", "Devkota", "Ghattekulo", 'M', 3845.00);
         Person emp7=   new(7, "Yangchen", "Gurung", "Muktinath", 'F', 9845.00);
        List<Person> employees =new(){emp1,emp2,emp3,emp4,emp5,emp6,emp7};

        return employees;
    }
    public Person()
    { 

    }
 public static Person GetEmployeeById(int id)
{
    var employees = GetEmployee(); // Retrieve the list of employees
    if (employees != null)
    {
        return employees.FirstOrDefault(emp => emp.Id == id); // Find employee by ID
    }
    return null; // Return null if list is null
}

   
 }


