// See https://aka.ms/new-console-template for more information
using System.IO;

DoApp();

void DoApp()
{
    //Directory.GetFiles()
    //DirectoryInfo directory = new DirectoryInfo("");
    //directory.GetFiles()

    string dir = Directory.GetCurrentDirectory();
    string fileName = dir + @"\data.txt";

    if (File.Exists(fileName))
        Console.WriteLine($"{fileName} exists");
    else
        Console.WriteLine($"{fileName} does not exists");

    using (StreamWriter sw = new StreamWriter(fileName))
    {
        sw.WriteLine("This is line one");
        sw.WriteLine("This is line two");
        sw.WriteLine("This is line three");
        sw.WriteLine("This is line four");
    }
    Console.WriteLine($"{ fileName} created");

    string[] lines = File.ReadAllLines(fileName);
    foreach (string line in lines)
        Console.WriteLine(line);

    string fileText = File.ReadAllText(fileName);
    Console.WriteLine(fileText);
    
    File.Delete(fileName);
    Console.WriteLine($"{fileName} deleted");


}