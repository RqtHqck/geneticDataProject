using System;
using System.Collections.Generic;

namespace GeneticsProject
{
    public class Utils
    {
        public static string GetFormula(string proteinName) 
        {
            // Получаем формулу из объекта генетических данных
            foreach (GeneticData item in Program.data)
            {
                if (item.name.Equals(proteinName)) return item.formula;
            }
            return null;
        }
        
        public static bool IsValid(string formula)
        {
            // Функция для проверки цепочки аминокислот. Проверяет на допустимые символы.
            List<char> letters = new List<char>() { 'A', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'K', 'L', 'M', 'N', 'P', 'Q', 'R', 'S', 'T', 'V', 'W', 'Y' };
            foreach (char ch in formula)
            {
                if (!letters.Contains(ch)) return false;
            }
            return true;
        }

        public static string Encoding(string formula)
        {
            // Функция для сжатия строки. 
            // aaabbc -> 3abbc
            string encoded = String.Empty;
            for (int i = 0; i < formula.Length; i++)
            {
                char ch = formula[i];
                int count = 1;
                while (i < formula.Length - 1 && formula[i + 1] == ch)
                {
                    count++;
                    i++;
                }
                if (count > 2) encoded = encoded + count + ch;
                if (count == 1) encoded = encoded + ch;
                if (count == 2) encoded = encoded + ch + ch;
            }
            return encoded;
        }

        public static string Decoding(string formula)
        {
            // Функция для разворачивания строки. 
            // 3abbc -> aaabbc 
            string decoded = String.Empty;
            for (int i = 0; i < formula.Length; i++)
            {
                if (char.IsDigit(formula[i]))
                {
                    char letter = formula[i + 1];
                    int conversion = formula[i] - '0';
                    for (int j = 0; j < conversion - 1; j++) decoded = decoded + letter;
                }
                else decoded = decoded + formula[i];
            }
            return decoded;
        }
    }
}
