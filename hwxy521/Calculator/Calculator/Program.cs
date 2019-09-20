using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace product_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int a, b, c, d;
            string posture, s;
            object sum;
            char[] op = { '+', '-', '*', '/' };
            Console.Write("请输入出题数：");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rm = new Random();
            DataTable dt = new DataTable();
            while (i < n)
            {
                a = rm.Next(2, 4);
                b = rm.Next(0, 100);
                posture = Convert.ToString(b);
                for (int j = 0; j < a; j++)
                {
                    c = rm.Next(0, 4);
                    d = rm.Next(0, 100);
                    posture += op[c] + Convert.ToString(d);
                }
                sum = dt.Compute(posture, "");
                if (sum.ToString().Contains("-") || sum.ToString().Contains("."))
                    continue;
                i++;
                s = posture + "=" + sum.ToString();
                StreamWriter strmsave = new StreamWriter("C:\\hxy.txt", true);
                strmsave.WriteLine(s);
                Console.WriteLine("写入完成");
                strmsave.Close();
            }
        }
    }
}