using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "dbdaadabacabbacbbaccbbaccbbddadadac";
            string s1 = "";
            for (int i=0; i<s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    s1 += "00";
                }
                if (s[i] == 'b')
                {
                    s1 += "01";
                }
                if (s[i] == 'c')
                {
                    s1 += "10";
                }
                if (s[i] == 'd')
                {
                    s1 += "11";
                }
            }
            Console.WriteLine(s1);
            Console.ReadLine();
        }
    }
}
