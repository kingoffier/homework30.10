using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            //GetSymbols(str);
            //Ex2(str);
            //Ex3(str);
            //Ex4(str);
            //int collichestvo = Convert.ToInt32(Console.ReadLine());
            // Ex5(str, collichestvo);
            // Ex6(str);
            //Ex7(str);
            //Ex8(str);
            //Ex9(str);
            //Ex10(str);
            //Ex11(str);
            //Ex12(str);
            //Ex13(str);
            //Ex14(str);
            //Ex15(str);
            //Ex16(str);
            Ex17(str);
            /*   Ex18(str);
              */
            Console.ReadKey();
        }
        private static void Ex18(string str)
        {

        }
        private static void Ex17(string str)
        {
            string[] textMass;
            textMass = str.Split(' ');
            if (textMass.Length > 3)
            {
                Console.WriteLine("Да");
            }
            else
            {
                Console.WriteLine("Нет");
            }
            Console.ReadLine();
        }
        private static void Ex16(string str)
        {
            string p = "аеёиоуыэюя";
            int i = 0;
            foreach (char item in str)
            {
                if (p.Contains(item))
                {
                    i++;
                }
            }
            Console.WriteLine("Согласных в предложении-" + i);
        }
        private static void Ex15(string str)
        {
            int i = 0;
            int j = 0;
            foreach (char item in str)
            {
                if (item == '+')
                {
                    i += 1;
                }
                if (item == '-')
                {
                    j += 1;
                }
            }
            Console.WriteLine("В этом тексте '+' встречается:" + i);
            Console.WriteLine("В этом тексте '-' встречается:" + j);
        }
        private static void Ex14(string str)
        {

        }
        private static void Ex13(string str)
        {
            int i = 0;
            foreach (char item in str)
            {
                if (item == ' ')
                {
                    i += 1;
                }
            }
            Console.WriteLine(i);
        }
        private static void Ex12(string str)
        {
            for (int i = 1; i < str.Length; i += 4)
            {
                Console.WriteLine(str[i]);
                int j = i + 1;
                Console.WriteLine(str[j]);

            }
        }
        private static void Ex11(string str)
        {

        }
        private static void Ex10(string str)
        {
            for (int i = 3; i < str.Length; i += 3)
            {
                Console.WriteLine(str[i]);
            }
        }
        private static void Ex9(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'и')
                {
                    result += "и";
                }
            }
            Console.WriteLine(result);
        }
        private static void Ex8(string str)
        {
            string str2 = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            if (str.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    result.Append(str[i]);
                }
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Второе слово длиннее первого");
            }
        }
        private static void Ex7(string str)
        {
            StringBuilder str2 = new StringBuilder();
            int l = str.Length;
            str2.Insert(0, "*", l);
            str2.Insert(str.Length, str);
            int h = str2.Length;
            str2.Insert(str2.Length, "*", l);
            Console.WriteLine(str2);

        }
        private static void Ex6(string str)
        {
            StringBuilder str2 = new StringBuilder();
            string plusi = "++++";
            string minusi = "-----";
            str2.Insert(0, str);
            str2.Insert(0, plusi);
            str2.Insert(str2.Length, minusi);
            Console.WriteLine(str2);
        }
        private static void Ex5(string str, int collichestvo)
        {

            for (int i = 0; i < collichestvo; i++)
            {
                Console.WriteLine(str);
            }
        }
        private static void Ex4(string str)
        {
            StringBuilder t = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                t.Append(str[i]);
            }
            Console.WriteLine(t);
        }
        private static void Ex3(string str)
        {
            StringBuilder str2 = new StringBuilder();
            for (int i = 0; i < str.Length; i += 2)
            {
                str2.Append(str[i]);
            }
            Console.WriteLine(str2);
        }

        private static void Ex2(string str)
        {
            StringBuilder str2 = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2.Append(str[i]);
            }
            Console.Write(str2);
        }

        /// <summary>
        /// Печать символа столбиком
        /// </summary>
        /// <param name="str"></param>
        private static void GetSymbols(string str)
        {
            foreach (char item in str)
            {
                Console.WriteLine(item);
            }
        }

    }
}

