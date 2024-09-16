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


        static void Main(string[] args)
        {
            // Console.WriteLine(Utils.Encoding("AAAAAAAATATTTCGCTTTTCAAAAATTGTCAGATGAGAGAAAAAATAAAA"));
            // Modes.Search('MLQSIIKNIWIPMKPYYTKVYQEIWIGMGLMGFIVYKIRAADKRSKALKASAPAPGHH');
            // string formula2 = Utils.Decoding("FK3I");
            // FileWorking.ReadGeneticData("./gendata/gendata.0.txt");
            // Console.WriteLine("=============Search===================");
            // FileWorking.ReadHandleCommands("./commands/commands.0.txt");
            // Console.WriteLine("=============Get Formula of the Protein===================");
            // string formula = Utils.GetFormula("6.8 kDa mitochondrial proteolipid");
            // if (formula != null) Console.WriteLine(formula);
        }
    }
}
