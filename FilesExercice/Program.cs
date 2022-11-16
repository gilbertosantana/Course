using System.Globalization;
using FilesExercice.Entities;

Console.WriteLine("Informe o diretório C:\\");
string sourceFilePath = @"C:\" + Console.ReadLine()!;

try
{
    string[] lines = File.ReadAllLines(sourceFilePath);

    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath)!;
    string targetFolderPath = sourceFolderPath + @"\out";
    string targetFilePath = targetFolderPath + @"\summary.csv";

    Directory.CreateDirectory(targetFolderPath);

    Produto produto;

    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        foreach (string line in lines)
        {
            string[] properties = line.Split(',');
            string name = properties[0];
            double value = double.Parse(properties[1], CultureInfo.InvariantCulture);
            int quant = int.Parse(properties[2]);

            produto = new Produto(name, value, quant);

            sw.WriteLine(produto);
        }


    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}