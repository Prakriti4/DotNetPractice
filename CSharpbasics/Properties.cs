using System; 

internal class Person
{ 
    private  byte age; 

    private int grade;

    public string name; 

    public string address; 

    private DateTime dob; 

    public byte Age{ 
        get { return age;}
        set { 
            if(value>30 && value<40)
            { 
                age = value; 
            }
        }
    }
//Auto-implemented properties
 public string Address { get; set; }
 //Read-only
  public string Name { get;  }
}
 

