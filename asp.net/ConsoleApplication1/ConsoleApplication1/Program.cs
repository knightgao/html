using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PAT第二题
            string str1 = Console.ReadLine();
            string str2 = "";
            int sum = 0;
            string[] arr1 = new string[100];
            for (int i=0; str1.Length>i;i++  )
            {
                str2 = str1.Substring(i, 1);
                arr1[i] = str2;
            }
            for (int i = 0; i < str1.Length;i++ )
            {
                sum += int.Parse(arr1[i]);
            }
            string sum2 = sum.ToString();
            string sumend = "";
            string sumend2 = "";
            for (int i = 0; i < sum2.Length; i++)
            {
                string str3 = "";
                
                str3 = sum2.Substring(i, 1);
                switch (str3)
                { 
                    case "1":
                        sumend = "yi ";
                        break;
                    case "2":
                        sumend = "er ";
                        break;
                    case "3":
                        sumend = "san ";
                        break;
                    case "4":
                        sumend = "si ";
                        break;
                    case "5":
                        sumend = "wu ";
                        break;
                    case "6":
                        sumend = "liu ";
                        break;
                    case "7":
                        sumend = "qi ";
                        break;
                    case "8":
                        sumend = "ba ";
                        break;
                    case "9":
                        sumend = "jiu ";
                        break;
                    case "0":
                        sumend = "ling ";
                        break;
                    default:
                        break;
                }
                sumend2 += sumend;
            }
            Console.Write("{0}", sumend2.TrimEnd());
            Console.ReadKey();
        }
    }
}
