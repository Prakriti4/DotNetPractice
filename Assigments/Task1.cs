using System; 
using System.IO; 
 
 namespace FolderCreation{
 public class FoCreation{ 
    public void CreateFolderAndFiles(string[] folderNames)
    { 
        string rootFolder = @"C:\Users\DELL\Desktop\.netpractice\DotNetPractice\Assigments\Nepal";
        Directory.CreateDirectory(rootFolder); 
        foreach(string folderName in folderNames)
        {
            string subFolderPath = Path.Combine(rootFolder, folderName);
            Directory.CreateDirectory(subFolderPath);
            File.WriteAllText(Path.Combine(subFolderPath,"Test.txt"),folderName);
        }
        Console.WriteLine("Folders and files created successfully");

    }
 }}
