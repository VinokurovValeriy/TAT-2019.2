

namespace UnitTest.hw2
{
    public class StringAnalizer
    {
        public static int MaxCountOfDifferentSymbols (string str)
        {
            int count = 1;
            int maxCount = 1;

            if (str.Length == 0)
            {
                return 0;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i]!=str[i-1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
                else
                {
                    count = 1;
                }

            }
            return maxCount;
        }  

        public static int MaxCountOfIdenticalDigits (string str)
        {
            int count = 0;
            int maxCount = 0;

            foreach (char element in str)
            {
               if (element >= 48 && element <= 57)
                {
                    count = 1;
                    maxCount = 1;
                    break;
                }
            }

            if (maxCount==0)
            {
                return 0;
            }

            for (int i = 1; i < str.Length; i++)
            { 
                if ((str[i] == str[i - 1])&&(str[i] >= 48 && str[i] <= 57))
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                }
                else
                {
                    count = 1;
                }
            }
            return maxCount;
        }

        public static int MaxCountOfIdenticalLatinSymbols (string str)
        {
            int count = 0;
            int maxCount = 0;

            foreach (char element in str)
            {
                if ((element >= 65 && element <= 90) || (element >= 97 && element <= 122))
                {
                    count = 1;
                    maxCount = 1;
                    break;
                }
            }

            if (maxCount == 0)
            {
                return 0;
            }

            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i] == str[i - 1]) && ((str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122)))
                {
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }

                }
                else
                {
                    count = 1;
                }
            }
            return maxCount;
        }

    }
}
