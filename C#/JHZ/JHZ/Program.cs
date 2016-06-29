using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JHZ
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = "goodbye";
            int result = 0;
            try
            {
                int i = int.Parse(first);
                Console.Write("{0}", i);
            }
            catch (System.FormatException)
            {
                Console.Write("输入的字符不合法{0}", first);
                result = 1;
            }
            catch (Exception exception)
            {
                Console.WriteLine("unexpected error : {0}", exception.Message);
                result = 1;
            }
            finally
            {
                Console.WriteLine("\n\rGoodbye {0}", second);
            }
        }
        
    }
}
