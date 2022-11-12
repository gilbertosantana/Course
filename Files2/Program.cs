﻿
string path = @"C:\Users\Jessica\Downloads\file1.txt";

StreamReader ?streamReader = null;

try
{
	streamReader = File.OpenText(path);
	while (!streamReader.EndOfStream)
	{
        string line = streamReader.ReadLine()!;
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
	Console.WriteLine("An error occurred");
	Console.WriteLine(e.Message);
}
finally 
{ 
	if(streamReader != null) streamReader.Close();
}