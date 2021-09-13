using System;

namespace CS1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Hello World");
                Console.WriteLine("2.圆的面积及周长");
                Console.WriteLine("3.复印价格");
                Console.WriteLine("4.冒泡排序");
                Console.WriteLine("5.学生成绩等级");
                Console.WriteLine("6.九九乘法表");
                Console.WriteLine("0.退出");
                Console.Write("请输入操作:");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        exp1();
                        break;
                    case 2:
                        exp2();
                        break;
                    case 3:
                        exp3();
                        break;
                    case 4:
                        exp4();
                        break;
                    case 5:
                        exp5();
                        break;
                    case 6:
                        exp6();
                        break;
                    case 0:
                        return;
                    default:
                        continue;
                }

                Console.WriteLine();
            }
        }
        
        static void exp1()
        {
            Console.WriteLine("1.Hello World!");
        }

        static void exp2()
        {
            const double pi = 3.14;
            Console.Write("2.输入圆的半径：");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("面积：{0}", (pi * radius * radius));
            Console.WriteLine("周长：{0}", (pi * 2 * radius));
        }

        static void exp3()
        {
            Console.Write("3.请输入总张数：");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 50)
            {
                Console.WriteLine("价格：{0}", num * 0.5);
            }
            else
            {
                Console.WriteLine("价格：{0}", 50 * 0.5 + (num - 50) * 0.2);
            }
        }

        static void exp4()
        {
            Console.Write("4.数字数量：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("请输入第{0}个数据：", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j + 1 < n - i; j++)
                {
                    if (a[j] < a[j + 1])
                    {
                        (a[j + 1], a[j]) = (a[j], a[j + 1]);
                    }
                }
            }

            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void exp5()
        {
            Console.Write("5.输入学生成绩：");
            int score = Convert.ToInt32(Console.ReadLine());
            Console.Write("成绩等级：");
            switch (score/10)
            {
                case 10:
                    Console.WriteLine("优");
                    break;
                case 9:
                    Console.WriteLine("优");
                    break;
                case 8:
                    Console.WriteLine("中");
                    break;
                case 7:
                    Console.WriteLine("良");
                    break;
                case 6:
                    Console.WriteLine("中");
                    break;
                default:
                    Console.WriteLine("不及格");
                    break;
            }
        }

        static void exp6()
        {
            Console.WriteLine("6.九九乘法表");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} * {1} = {2}\t", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}