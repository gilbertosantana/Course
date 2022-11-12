using System.IO;

string sourcePath = @"C:\Users\Jessica\Downloads\file1.txt";
string targetPath = @"C:\Users\Jessica\Downloads\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);

    foreach(string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch(IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}
