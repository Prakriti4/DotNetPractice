using System;
using System.IO;
public class FileIO
{ 
    public void LearnFileHandling()
    { 
        string filepath=@"C:\Users\DELL\Desktop\.netpractice\DotNetPractice\README.md";

        bool isFileThere = File.Exists(filepath);
        if(isFileThere)
        {
       var fileContent=File.ReadAllText(filepath);
       Console.WriteLine(fileContent);
       Console.ForegroundColor = ConsoleColor.Green;
    }
}
public void LearnFileWritting()
{ 
    string filePath="Abc.txt"; 
    File.WriteAllText(filePath,"This is random file content");
}
public void LearnFileInfo()
{ 
    string filePath = "Abc.txt"; 
    FileInfo fileInfo = new FileInfo(filePath);
    var size = fileInfo.Length;
    var createDate= fileInfo.CreationTime;
    Console.WriteLine(filePath); 
    Console.WriteLine($"Size:{size} bytes"); 
    Console.WriteLine($"Created: {createDate}"); 

}
public void LearnDirectory()
{ 
    string folderPath= "MBM";
    Directory.CreateDirectory(folderPath);

    Console.WriteLine("Do you want to delete MBM folder?"); 
    string confirm = Console.ReadLine(); 
    if(confirm =="y")
    { 
        Directory.Delete(folderPath);
    }
}
}
//Assignment :"Create a folder "Nepal", with in that create 10 subfolder. Every subfolder should creat a file Test.txt with subfolder name as a content