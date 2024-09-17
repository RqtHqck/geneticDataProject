using System;
using System.Collections.Generic;

namespace GeneticsProject
{
    public class FileWorking
    {
        public static void ReadGeneticData(string filename){
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
        public static void ReadHandleCommands(string filename){
            using (StreamReader reader = new StreamReader(filename))
            {
                string resultString = null;
                int counter = 0;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (counter == 0) {
                        Utils.PrintProgramInfo("Ihar Tsitou\nGenetic Searching\n--------------------------------------------------------------------------");
                    }
                    counter++;
                    string[] command = line.Split('\t');

                    if (command[0].Equals("search"))
                    {
                        // 001   search  SIIK
                        Utils.PrintProgramInfo($"{counter.ToString("D3")}\t\t{command[0]}\t\t{Utils.Decoding(command[1])}");
                        Utils.PrintProgramInfo($"organism\t\tprotein");
                        int index = Modes.Search(command[1]);
                        if (index != -1)
                            Utils.PrintProgramInfo($"{Program.data[index].organism}\t\t{Program.data[index].name}");
                        else
                            Utils.PrintProgramInfo("NOT FOUND");
                        Utils.PrintProgramInfo("--------------------------------------------------------------------------");
                    }

                    if (command[0].Equals("diff"))
                    {
                        Utils.PrintProgramInfo($"{counter.ToString("D3")}\t\t{command[0]}\t\t{command[1]}\t\t{command[2]}");
                        int differents  = Modes.Diff(command[1], command[2]);
                        Utils.PrintProgramInfo($"amino-acids difference:\n{differents}");
                        Utils.PrintProgramInfo("--------------------------------------------------------------------------");
                    }
                    if (command[0].Equals("mode"))
                    {
                        Utils.PrintProgramInfo($"{counter.ToString("D3")}\t\t{command[0]}\t\t{Utils.Decoding(command[1])}");
                        (char mostFrequentChar, int mostFrequentAmount) = Modes.Mode(command[1]);
                        Utils.PrintProgramInfo($"amino-acid occurs:\n{mostFrequentChar}\t\t{mostFrequentAmount}");
                        Utils.PrintProgramInfo("--------------------------------------------------------------------------");
                    }
                }
            }
        }
        public static void WriteInfoIntoFile() {
            string filePath = "./output/output.txt";
            // Запись строки в файл
            File.WriteAllText(filePath, Program.resultInfo);

            Console.WriteLine("Данные программы успешно записаны в файл ./output/output.txt");
        }
    }

}
