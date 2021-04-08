using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Mathf005 : MonoBehaviour
{
    private void _41()
    {
        //编一个程序，把一张1元的钞票换成5分，2分和1分的硬币，要求每种至少一枚，并且所换硬币数不超过30枚，请问，有哪几种换法？
        static void Main(string[] args)
        {
            int sum=0;
           // 一分 两分 三分
           for (int i = 1; i <= 100; i++)
           {
               for (int j = 1; j <= 50; j++)
               {
                   for (int k = 1; k <= 20; k++)
                   {
                       if (i+j+k<=30&&1+2*j+5*k==100)
                       {
                           sum++;
                       }
                   }
               }
           }
           Console.WriteLine(sum);
        }
    }
    private void _42()
    {
        //编一个程序，把一张面值100元的钞票换成5元，1元和5角面值的钞票，要求100元换以上的零钱100张，且要求每种不少于一张
        //请问，有哪几种换法？
        static void Main(string[] args)
        {
            int sum=0;
            for (int i = 1; i <= 20; i++) //5元
            {
                for (int j = 1; j <= 100; j++) // 1元
                {
                    for (int k = 1; k <= 200; k++) // 5毛
                    {
                        if (i+j+k==100 && 5*i+j+0.5*k==100)
                        {
                            sum++;
                        }
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
    private void _43()
    {
        //编一个程序，解决百钱买百鸡问题，某人有100元钱，要买100只鸡。
        //公鸡5元钱一只，母鸡3元钱一只，小鸡一元钱3只
        //问可买到公鸡，母鸡，小鸡各为多少只？
        static void Main(string[] args)
        {
            int z;
            for (int i = 1; i <= 20; i++)
            {
                for (int j = 0; j <=33; j++)
                {
                    z = 100 - i - j;
                    if (5*i+3*j+z/3==100)
                    {
                        //  Console.WriteLine("{0},{1},{2}",i,j,k);
                        Console.WriteLine("{0},{1},{2}",i,j,z);
                    }
                }

            }
        }
    }
    private void _44()
    {
        // 编一个程序，定义数组，用for循环语句，顺序输入10个实数，然后逆序输出这10个数
        
        static void Main(string[] args)
        {
            int[] num  = new  int [10]; //  先开10个空间
        
            for (int i = 0; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
               
            }

            //到0的时候结束
            for (int i = 9; i >=0; i--)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
    private void _45()
    {
        //编一个程序，从键盘输入10个实数，存入一个数组，用冒泡法对这个数作升序排序 
        // 它重复地走访过要排序的元素列，依次比较两个相邻的元素，如果顺序（如从大到小、首字母从Z到A）错误就把他们交换过来。走访元素的工作是重复地进行直到没有相邻元素需要交换，也就是说该元素列已经排序完成。
        static void Main(string[] args)
        {
            int n = 10;
            int[]SortArray =new int[10];

            for (int i = 0; i < n; i++)
            {
                SortArray[i] = int.Parse(Console.ReadLine()); //存入输入数组
            }
            
            Console.WriteLine("等待排列的数列为:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}",SortArray[i]);
            }

            for (int i = n-1; i >=0; i--)//  9~0
            {
                for (int j = 0; j < i-1; j++)//0~8
                {
                    if (SortArray[j] >SortArray[j+1])  // 2,1  2->1  1->2
                    {
                        // 交换
                        int temp = SortArray[j];
                        
                        SortArray[j] = SortArray[j + 1];
                        
                        SortArray[j + 1] = temp;
                    }
                    
                }
            }

        }
    }
    private void _46()
    {
        //编一个程序，定义一个有10个元素的一堆数组a，在键盘上输入时没有大小次序，但是存入数组时要按
        //由小到大的顺序存放
        //例如，输入第1个数时，存入a[0];假如第二个数是5，则数存入a[1]
        //假如第三个数是4，那么把前面输入的5向后面移动到a[2]把4插入到a[1]的位置上，
        //这样使得每输入一个数保持从小到大的顺序排列
        static void Main(string[] args)
        {
           int[] a =new int[10];
           for (int i =0; i <10; i++) //输入10次
           {
               a[i] = int.Parse(Console.ReadLine());
               for (int j = i; j>=1 ; j--) // 每输入一次遍历当前所有数组
               {
                   if (a[j]<a[j-1])
                   {
                       int temp = a[j-1];
                       a[j - 1] = a[j];
                       a[j] = temp;
                   }
                   break;// 继续输入
               }
           }

           for (int i = 0; i < 10; i++)
           {
               Console.WriteLine(i);
           }
        }
    }
    private void _47()
    {
        //编一个程序，定义一个数组，用for语句输入10个实数存入这个数组
        //然后按逆序重新存放后再输出！
        static void Main(string[] args)
        {
            double[] a =new double[10];
            for (int i = 0; i < 10; i++)
            {
                a[i]=Double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10 / 2; i++)
            {
                double temp = a[i];
                a[i] = a[9 - i];
                a[9 - i] = temp;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }

        }
    } 
    //  如何将字符串拆开成字符 string -> char
//     string oldstr= "abcdef";
//     string[] newstr = changestr(oldstr); //调用
//     定义一个函数
//     private string[] changestr(string str)
//     {
//         List<string> strs = new List<string>();
//         for (int i = 0; i < str.Length; i++)
//             strs.Add(str.Substring(i, 1));
//         return strs.ToArray();
//    }
    private void _48()
    {
        //编一个程序，从键盘输入一个字串符，用foreach循环语句，统计其中大写字母的个数和小写字母的个数
        static void Main(string[] args)
        {

            string allchar;
            int anum=0;
            int Anum=0;

            allchar = Console.ReadLine();

            foreach (var c in allchar)
            {
                if (c>='a'&&c<='z')
                {
                    anum++;
                }
                else if (c>='A'&&c<='Z')
                {
                    anum--;
                }
                else
                {
                    Console.Write("不是字符");
                }
            }
        }
    }

    private void _49()
    {
        //编一个程序，定义一个字串符数组和一个字串符变量，给这个字串符变量输入一个字符串
        //然后用foreach语句把这个字串符拷贝到字符数组里，最后输出字符数组
        static void Main(string[] args)
        {
           
            string n;
            n = Console.ReadLine();
            char[] A=new char[n.Length];
            
            // 临时变量
            int i = 0;
            foreach (char c in n)
            {
                A[i] = c;
                i++;
            }

            foreach (var num in A)
            {
                Console.WriteLine(num);
            }
       
        }
    }
    private void _50()
    {
        //输入一个字符串，将其中小写字母改成大写字母，把大写字母改成小写字母，其中字符不变，输出该字符串
        static void Main(string[] args)
        {
            string n;
            n = Console.ReadLine();
            
            // 临时变量
            int i = 0;
            
            foreach (char ch in n)
            {
                if (ch>='a'&&ch>='z')
                {
                    Console.WriteLine((char)((int)ch+32)); // char类型转换为int类型
                }
                else if (ch >= 'A' && ch >= 'Z')
                {
                    Console.WriteLine((char)((int)ch-32));
                }
            }

        }
    }
}
