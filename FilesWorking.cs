using System;
using System.Collections.Generic;

namespace GeneticsProject
{
    public class FileWorking
    {
        public static void ReadGeneticData(string filename)
        {
            // Функиця для чтения в массив структур генетических данных
            // Файл sequences.txt
            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] fragments = line.Split('\t');
                    GeneticData protein;
                    protein.name = fragments[0];
                    protein.organism = fragments[1];
                    protein.formula = fragments[2];
                    Program.data.Add(protein);
                    Program.count++;
                }
            }
        }
        public static void ReadHandleCommands(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                int counter = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    counter++;
                    string[] command = line.Split('\t');
                    if (command[0].Equals("search"))
                    {
                        // 001   search  SIIK
                        Console.WriteLine($"{counter.ToString("D3")}   {"search"}   {Utils.Decoding(command[1])}");
                        int index = Modes.Search(command[1]);
                        if (index != -1)
                            Console.WriteLine($"{Program.data[index].organism}    {Program.data[index].name}");
                        else
                            Console.WriteLine("NOT FOUND");
                        Console.WriteLine("================================================");
                    }
                    if (command[0].Equals("diff"))
                    {
                        // Implement diff functionality
                    }
                    if (command[0].Equals("mode"))
                    {
                        // Implement mode functionality
                    }
                }
            }
        }
    }

}
