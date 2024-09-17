using System;
using System.Collections.Generic;

namespace GeneticsProject
{
    public class Modes
    {
        public static int Search(string amino_acid){
            // Поиск. Ищет подстроку в формулах белка (аминокислотах)
            // FKIII -> FK3I
            string decoded = Utils.Decoding(amino_acid);
            for (int i = 0; i < Program.data.Count; i++)
            {
                if (Program.data[i].formula.Contains(decoded)) return i;
            }
            return -1;
        }

        public static int Diff(string proteinName1, string proteinName2){
            // Сравнение. Показывает сколько символов отличается в формуле белка (аминокислотах)
            string formula1 = null; 
            string formula2 = null;

            for (int i = 0; i < Program.data.Count; i++) {
                if (Program.data[i].name == proteinName1) {
                    formula1 = Program.data[i].formula;
                }
                if (Program.data[i].name == proteinName2) {
                    formula2 = Program.data[i].formula;
                }
            }

            int counter = 0;
            int minLength = Math.Min(formula1.Length, formula2.Length);

            for (int i = 0; i < minLength; i++)
            {
                if (formula1[i] != formula2[i]) counter++;
            }

            // Count the remaining characters if the lengths are different
            counter += Math.Abs(formula1.Length - formula2.Length);

            return counter;
        }

        public static (char, int) Mode(string proteinName1){
            // Ищет во входных данных указанный белок, а в его цепочке аминокислоту, которая встречается чаще всего.
            string formula = null;
            for (int i = 0; i < Program.data.Count; i++) {
                if (Program.data[i].name == proteinName1) {
                    formula = Program.data[i].formula;
                    break;
                }
            }
            var (symbol, frequency) = Utils.FindMostFrequentChar(formula);
            
            return (symbol, frequency);
        }
    }
}
