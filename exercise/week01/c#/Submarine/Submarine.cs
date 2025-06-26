using System;

public class Submarine
{
    public static void Main(string[] args)
    {
        string filePath = @"C:\\Users\\itsia\\Documents\\GitHub\\Repo\\cahier-de-vacances-b3\\exercise\\week01\\c#\\Submarine.Tests\\submarine.txt";

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

    }
}