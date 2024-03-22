using LearnCollections; 
using LearningClasses; 
using FolderCreation;
public class Program
{ 
    static void Main(string[] args)
    { 
        // Collections collections = new Collections(); 
        // collections.LearnDictionary();
        // collections.LearnLists();
        // Demo construct= new Demo(); 
        // construct.DoSomething();
        var Square1= new Square(23.45);
        var Square2= new Square(6);
        var Square3= new Square(2);
        var x = Square1.GetArea();
        Console.WriteLine($"Area: {x}");
        FileIO ne = new FileIO();
        ne.LearnFileHandling();  
        ne.LearnFileWritting();
        ne.LearnFileInfo();
        ne.LearnDirectory();; 
        string[] folderNames={"Kathmandu","Chitwan","Dang","Sunsari","Rajbiraj","Palpa","Dhading","Dharan","Illam","Mustang"};
        
        FoCreation nn= new FoCreation();
        nn.CreateFolderAndFiles(folderNames);

    }
}