using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace product_count
{
    public class Program
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
            Random rm = new Random();//生成随机数
            DataTable dt = new DataTable();//计算数据总和
            while (i < n)
            {
                a = rm.Next(2, 4);//随机生成运算符个数
                b = rm.Next(0, 100);//随机生成第一运算数字
                posture = Convert.ToString(b);
                for (int j = 0; j < a; j++)
                {
                    c = rm.Next(0, 4);//随机生成运算符号
                    d = rm.Next(0, 100);//随机生成运算数字
                    posture += op[c] + Convert.ToString(d);//利用字符串特性，将数字和运算符连接起来
                }
                sum = dt.Compute(posture, "");//利用C#自带函数，计算数据总和
                if (sum.ToString().Contains("-") || sum.ToString().Contains("."))//确定数据总和没有小数、负数
                    continue;
                i++;
                s = posture + "=" + sum.ToString();//将数据总和与运算式子连接起，形成四则运算练习题
                StreamWriter strmsave = new StreamWriter("C:\\hxy.txt", true);//将练习题写入hxy.txt中
                strmsave.WriteLine(s);
                Console.WriteLine("写入完成");
                strmsave.Close();
            }
        }
        public void method(int n)
        {
             int i = 0;
            int a, b, c, d;
            string posture, s;
            object sum;
            char[] op = { '+', '-', '*', '/' };
            Random rm = new Random();//生成随机数
            DataTable dt = new DataTable();//计算数据总和
            while (i < n)
            {
                a = rm.Next(2, 4);//随机生成运算符个数
                b = rm.Next(0, 100);//随机生成第一运算数字
                posture = Convert.ToString(b);
                for (int j = 0; j < a; j++)
                {
                    c = rm.Next(0, 4);//随机生成运算符号
                    d = rm.Next(0, 100);//随机生成运算数字
                    posture += op[c] + Convert.ToString(d);//利用字符串特性，将数字和运算符连接起来
                }
                sum = dt.Compute(posture, "");//利用C#自带函数，计算数据总和
                if (sum.ToString().Contains("-") || sum.ToString().Contains("."))//确定数据总和没有小数、负数
                    continue;
                i++;
                s = posture + "=" + sum.ToString();//将数据总和与运算式子连接起，形成四则运算练习题
                StreamWriter strmsave = new StreamWriter("C:\\hxy.txt", true);//将练习题写入hxy.txt中
                strmsave.WriteLine(s);
                Console.WriteLine("写入完成");
                strmsave.Close();
            }
        }
    }
}