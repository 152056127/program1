using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入两个操作数：");
            string str = Console.ReadLine();
            string[] oprator = str.Split(' ');
            int opa = int.Parse(oprator[0]);
            int opb = int.Parse(oprator[1]);
            Calculeator result = new Calculeator();
            Console.WriteLine("请输入要进行的运算（加：+；减：-；乘：*；除：/）");
            string op = Console.ReadLine();
            if (op == "+")
            {
                int S = result.Add(opa, opb);
                Console.WriteLine("这两个数的和是" + S);
            }
            if (op == "-")
            {
                int S = result.Sub(opa, opb);
                Console.WriteLine("这两个数的差是" + S);
            }
            if (op == "*")
            {
                int S = result.Mul(opa, opb);
                Console.WriteLine("这两个数的积是" + S);
            }
            if (op == "/")
            {
                int S = result.Div(opa, opb);
                Console.WriteLine("这两个数的商是" + S);
            }
        }
    }
    class Calculeator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            return a / b;
        }
    }
}
