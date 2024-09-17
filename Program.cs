using System;
using System.Collections.Generic;
using System.IO;

namespace GeneticsProject
{
    public struct GeneticData
    {
        public string name; // protein name
        public string organism; // organism name
        public string formula; // formula
    }

    class Program
    {
        public static List<GeneticData> data = new List<GeneticData>(); 
        public static int count = 1;    
        public static string resultInfo = "";  // Переменная для общего вывода


        static void Main(string[] args)
        {
            // Читаем генетические данные
            FileWorking.ReadGeneticData("./gendata/gendata.0.txt");
            // Читаем комманды и выполняем мод
            FileWorking.ReadHandleCommands("./commands/commands.0.txt");
            Console.WriteLine(resultInfo);
            FileWorking.WriteInfoIntoFile();
        }
    }
}
