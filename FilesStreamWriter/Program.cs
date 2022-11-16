﻿
string path = @"C:\temp\file1.txt";
string targetPath = @"C:\temp\file2.txt";

try
{
    string[] lines = File.ReadAllLines(path);
    
    using(StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}