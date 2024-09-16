using System;
using System.Collections.Generic;

namespace GeneticsProject
{
    public class Modes
    {
        public static int Search(string amino_acid)
        {
            // Поиск. Ищет подстроку в формуле белка (аминокислотах)
            // FKIII -> FK3I
            string decoded = Utils.Decoding(amino_acid);
            for (int i = 0; i < Program.data.Count; i++)
            {
                if (Program.data[i].formula.Contains(decoded)) return i;
            }
            return -1;
        }

        public static int Diff(string protein1, string protein2)
        {
            // Сравнение. Показывает сколько символов отличается в формуле белка (аминокислотах)
            // Implement the diff logic
            int counter = 0;
            int minLength = Math.Min(protein1.Length, protein2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (protein1[i] != protein2[i]) counter++;
            }

            // Count the remaining characters if the lengths are different
            counter += Math.Abs(protein1.Length - protein2.Length);

            return counter;
        }

        public static void Mode()
        {
            // Ищет во входных данных указанный белок, а в его цепочке аминокислоту, которая встречается чаще всего.
            // Implement mode functionality
        }
    }
}
