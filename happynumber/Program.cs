using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HappyNums
{
    class Program
    {
        public static bool ishappy(int n)
        {
            List<int> cache = new List<int>();
            int sum = 0;
            while (n != 1)
            {
                if (cache.Contains(n))
                {
                    return false;
                }
                cache.Add(n);
                while (n != 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }
                n = sum;
                sum = 0;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int nth = 0;
            int num = 1;
            List<int> happynums = new List<int>();

            while (happynums.Count < 1000)  
            {
                if (ishappy(num))
                {
                    happynums.Add(num);
                }
                num++;
            }
            //Console.WriteLine("First 1000 happy numbers : " + string.Join(",", happynums));
            nth = 3;
            var first3items = happynums.GetRange(0,nth);
          
            Console.WriteLine("the 3th Happy numbers is : "+ string.Join(",",first3items));
        }
    }
}