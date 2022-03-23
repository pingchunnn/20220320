using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220320
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "壬癸甲乙丙丁戊己庚辛";
            string b = "寅卯辰巳午未申酉戌亥子丑";

            Console.Write("請輸入西元幾年:");
            int year = Convert.ToInt32((Console.ReadLine()));
            int n = (year - 2022) + 36000;
            int first = n % 10;
            int second = n % 12;
            Console.WriteLine(Convert.ToString(a[first]) + Convert.ToString(b[second]));
            Console.ReadLine();
        }
    }
}