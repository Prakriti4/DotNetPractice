using System;

class MethodOverloading
{
    string name, surname;
    int rollNo;

    public void ShowStudentDetails(string name)
    {
        Console.WriteLine("The name of the student is " + name);
    }

    public void ShowStudentDetails(int rollNo)
    {
        Console.WriteLine("The roll number of the student is " + rollNo);
    }

    public void ShowStudentDetails(string name, string surname, int rollNo)
    {
        Console.WriteLine(name);
        Console.WriteLine(surname);
        Console.WriteLine(rollNo);
    }

    public static void main(string[] args)
    {
        MethodOverloading st = new MethodOverloading();
        st.ShowStudentDetails("Prakriti");
        st.ShowStudentDetails(1);
        st.ShowStudentDetails("Prakriti", "Khatiwada", 1);
    }
}
