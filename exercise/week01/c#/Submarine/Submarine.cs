using System;
using System.Runtime.CompilerServices;

namespace Submarine.submarine;

public class Submarine
{

    public static int getNumber(string instruction)
    {
        int number = 0;

        for (int i = 0; i < instruction.Length; i++)
        {
            if (instruction[i] == ' ')
            {
                string temp = instruction.Substring(i+1);
                number = Int32.Parse(temp);
            }
        }

        return number;
    }

    public static int Main(string[] args)
    {
        // Récupération du fichier
        string filePath = @"C://Users//itsia//Documents//GitHub//Repo//cahier-de-vacances-b3//exercise//week01//c#//Submarine.Tests//submarine.txt";
        StreamReader reader = new(filePath);

        string instruction;
        int horizontal = 0;
        int depth = 0;


        // Lecture du fichier
        while ((instruction = reader.ReadLine()) != null)
        {
            char firstChar = instruction[0];

            // Incrémentation horizontal / depth
            switch (firstChar)
            {
                case 'u':
                    depth -= getNumber(instruction);
                    break;

                case 'd':
                    depth += getNumber(instruction);
                    break;

                case 'f':
                    horizontal += getNumber(instruction);
                    break;

            }

        }

        Console.WriteLine("Horizontal : " + horizontal);
        Console.WriteLine("Depth : " + depth);
        Console.WriteLine("Access coordinate = " + horizontal * depth);


        return horizontal * depth;
    }
}