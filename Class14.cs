using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingcontest12
{
    class Class14
    {
        static void Main(string[] args)
        {


            int test = Convert.ToInt32(Console.ReadLine());
            double total = 0,carry=0;
            string[] st = new string[3];
            double[] a = new double[3];
            while(test>0)
            {
                  string s = Console.ReadLine();



             st = s.Split(' ');
             for(int i=0;i<st.Length;i++)
             {
                 a[i] = Convert.ToDouble(st[i]);
                 carry=Math.Pow(a[i], 2);
                 total = total + carry;
                 
             }
             total = Math.Sqrt(total);
             //total = Math.Round(total, 2);
             Console.WriteLine(total.ToString("0.00"));
                 test--;
                 total = 0; carry = 0;
            }
          
           

            Console.ReadKey();
        }
    }
}
