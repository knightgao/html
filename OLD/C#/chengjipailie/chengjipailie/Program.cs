using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chengjipailie
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string[] name = new string[n];
            string[] XH = new string[n];
            int[] CJ = new int[n];
            for (int i = 0; i < n; i++)
            {
                string strA = Console.ReadLine();
                char[] Sep = { ' ' };
                String[] strB = new String[3];
                strB = strA.Split(Sep);
                name[i] = strB[0];
                XH[i] = strB[1];
                CJ[i] = Int32.Parse(strB[2]);
            }
            for (int i = 0; i < CJ.Length; i++)
            {

            }
        }
    }
}