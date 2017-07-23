using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingcontest12
{
    class Problem_26
    {
        public static void Main()
        {
            string s;
            string output;
            int test;

            test = Convert.ToInt16(Console.ReadLine());
            while (test > 0)
            {
                s = Console.ReadLine();
                char[] carray = s.ToCharArray();
                Array.Reverse(carray);

                output = new string(carray);
                Console.WriteLine(output);
                test--;
            }
        }
    }
}
