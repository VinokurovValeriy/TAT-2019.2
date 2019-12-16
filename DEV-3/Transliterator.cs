using System;


namespace DEV_3
{
    public class Transliterator
    {
        string result = "";

        string[] Latin = { "Yu", "Ya","A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "L", "M", "N", "O", "P",
                                    "R", "U", "F", "Kh", "Ts", "Sch", "Ch", "Sh", "", "", "E",  "Y", "Y", "K", "T", "S",
                                  "yu", "ya","a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "l", "m", "n", "o", "p",
                                  "r", "u", "f", "kh", "ts", "sch", "ch", "sh", "", "", "e",  "y", "y", "k", "t", "s" };
        string[] Russian = { "Ю", "Я","А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Л", "М", "Н", "О", "П",
                                      "Р", "У", "Ф", "Х", "Ц", "Щ", "Ч", "Ш", "Ъ", "Ь", "Э",  "Й", "Ы", "К", "Т", "С",
                                     "ю", "я","а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "л", "м", "н", "о", "п",
                                     "р", "у", "ф", "х", "ц", "щ", "ч", "ш", "ъ", "ь", "э",  "й", "ы", "к", "т", "с"};

        public void RussianToLatin (string str)
        {
            foreach (char s in str)
            {
                for (int i = 0; i < Russian.Length; i++)
                {
                    if (Russian[i] == Convert.ToString(s))
                        result += Latin[i];
                }
            }
        }

        public void LatinToRussian(string str)
        {
            for (int i=0;i<str.Length;i++)
            {
                if (i < str.Length - 2)
                {
                    if (LatinToRussiansForSomeSymbol(Convert.ToString(str[i]) + Convert.ToString(str[i + 1]) + Convert.ToString(str[i + 2])))
                    {
                        i+=2;
                        continue;
                    }
                }

                if (i < str.Length - 1)
                {
                    if (LatinToRussiansForSomeSymbol(Convert.ToString(str[i]) + Convert.ToString(str[i + 1])))

                    {
                        i++;
                        continue;
                    }
                }
                if (LatinToRussiansForSomeSymbol(Convert.ToString(str[i])))
                {
                    continue;
                }
            }
        }

        public bool LatinToRussiansForSomeSymbol(string str)
        {
           for (int t = 0; t < Latin.Length; t++)
           {
                if (str == Latin[t])
                {
                    result += Russian[t];
                    return true;
                }
           }
            return false;
        }

        public string GetTranslitString(string inputString)
        {
            LatinToRussian(inputString);
            RussianToLatin(inputString);

            return result;
        }
    }
}
