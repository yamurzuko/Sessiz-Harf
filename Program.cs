using System;

namespace Sessiz_Harf
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Kelimeleri giriniz: ");            
            string[] words = Console.ReadLine().Split(" ");
            WordCheck(words);
            Console.ReadKey();
        }
        public static void WordCheck(string[] array)
        {
            foreach (var item in array)
            {
                bool result = false;
                for (int i = 1; i < item.Length; i++)
                {
                    if (LetterCheck(item[i]) == LetterCheck(item[i - 1]))
                    {
                        result = true;
                        break;
                    }
                }
                Console.Write("{0} ", result);
            }
        }
        public static bool LetterCheck(char a)
        {
            return !"aeıioöuü".ToCharArray().Contains(a);
        }

    }
}