using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathf008 : MonoBehaviour
{
    public class primeTest
    {
        public bool IsPrime(int x)
        {
            for (int i = 0; i < x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    };

    private void _71()
    {
        // 编一个程序，利用自定义方法，找出2到100之间的素数
        primeTest c = new primeTest();
        Console.WriteLine("2到100上的素数");
        for (int i = 2; i < 100; i++)
        {
            if (c.IsPrime(i))
            {
                Console.Write("{0}", i);
            }
        }
    }

    public class CompareDouble
    {
        public void Swap(ref double x, ref double y, ref double z)
        {

            if (x > y)
            {
                double temp = x;
                x = y;
                y = temp;

                if (y > z)
                {
                    temp = y;
                    y = z;
                    z = temp;

                    if (x > y)
                    {
                        temp = x;
                        x = y;
                        y = temp;
                    }
                }
            }
        }
    }

    private void _72()
    {
        //编一个程序，从键盘上输入三个double 类型的数，自定义方法，且从小到大的顺序排序
        //引用型参数调用方法，然后返回主方法输出结果
        double x;
        double y;
        double z;

        CompareDouble c = new CompareDouble();

        Console.Write("请输入一个实数：");
        x = double.Parse(Console.ReadLine());

        Console.Write("请输入一个实数：");
        y = double.Parse(Console.ReadLine());

        Console.Write("请输入一个实数：");
        z = double.Parse(Console.ReadLine());

        c.Swap(ref x, ref y, ref z);

        Console.WriteLine("排序后的三个数一次为{0},{1},{2}", x, y, z);
    }

    public class ClassName
    {
        public static void Root(float a, float b, float c, float root1, float root2)
        {
            //第一个根
            root1 = (-b + Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
            root2 = (-b - Mathf.Sqrt(b * b - 4 * a * c)) / (2 * a);
        }

    };

    private void _73()
    {
        //编一个程序，输入a,b,c的值，定义一个静态方法，求出一元二次方程 a*x*x+b*x+c=0 的二个实数根
        //计算二个实数根必须使用Math类中的Sqrt()方法，计算指定数的开方。计算二个实数根，可以用
        //公式(-b+Math.Sqrt(b*b-4*a*c))/(2*a)和(-b-Math.Sqrt(b*b-4*a*c))/(2*a)

        float a;
        float b;
        float c;

        float root1 = 0;
        float root2 = 0;
        Console.Write("请输入一个数：");
        a = float.Parse(Console.ReadLine());

        Console.Write("请输入一个数:");
        b = float.Parse(Console.ReadLine());

        Console.Write("请输入一个数");
        c = float.Parse(Console.ReadLine());

        if (a != 0 && b * b - 4 * a * c >= 0)
        {
            ClassName.Root(a, b, c, root1, root2);
            Console.Write("root1={0},root2 ={1}", root1, root2);
        }
        else
        {
            Console.WriteLine("输入的数据有误");

        }
    }

    public class ClassArray
    {
        public void Find(out int max, out int min, params int[] array)
        {
            int n = array.Length;
            int i = 1;
            max = array[0];
            min = array[0];

            while (i < n)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                i++;
            }
        }

    };

    private void _74()
    {
        //编一个程序，定义一个数组，再定义类以及方法，用方法(out参数传递数据)找出这组数据中的最大数和最小数

        int max;
        int min;

        int[] a = new int [10] {1, 2, 3, 4, 5, 6, 7, 8, 11, 23};
        ClassArray s = new ClassArray();
        s.Find(out max, out min, a);
        Console.WriteLine("最大数为：" + max);
        Console.WriteLine("最小数为：" + min);
    }


    public class Triangle
    {
        // 两个非静态方法
        public double C(double a, double b, double c)
        {
            double zc;
            zc = a + b + c;
            return zc;
        }

        public double S(double a, double b, double c)
        {
            double area;
            double s1;
            s1 = (a + b + c) / 2;
            area = Math.Sqrt(s1 * (s1 - a) * (s1 - b) * (s1 - c));
            return area;
        }

    }

    private void _75()
    {
        //编一个程序，定义一个类，该类中定义二个非静态方法，一个方法用来求出这个三角形的周长，
        //另一个方法用来求出这个三角形的面积，已知三角形三条边 a b c 计算其面积可以用Math类中的
        //Sqrt()方法，有表达式Math.Sqrt(s*(s-a)*(s-b)*(s-c)),可以利用它计算指定数的开方
        //其中s=(a+b+c)/2 在主方法中输入一个三角形三条边a b c 要求调用这二个非静态方法计算三角形的周长和面积
        //注意：在输入三角形三条边时，必须检查它们的数据合法性；

        Triangle tr = new Triangle();
        double x;
        double y;
        double z;

        Console.WriteLine("请输入三个角形三边");

        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        z = double.Parse(Console.ReadLine());

        // 两边之和要大于第三边
        if ((x + y > z && x - y < z) && (x + z > y && x - z < y) && (y + z > x && -z < x))
        {
            Console.WriteLine("三角形的周长：{0}", tr.C(x, y, z));
            Console.WriteLine("三角形面积为:{0}", tr.S(x, y, z));
        }
        else
        {
            Console.WriteLine("三角形的三边不合法");
        }
    }

    private void _76()
    {
        //求出0~1000能被7整除的数，并计算输出每五个数的和
        int sum = 0;
        int Count = 0;
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 7 ==0)
            {
                sum += i;
                Count++;
                Console.WriteLine("{0}",i);
            }

            if (Count==5)
            {
                Console.WriteLine("{0}",sum);
                Count = 0;
                sum = 0;
            }
        }
    }

    public class ClassSort
    {
        public void Sort(string str)
        {
            char[] num = str.ToCharArray();
            bool t = true;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < '0' || num[i] > '9') ;
                {
                    t = false;
                    break;
                }
            }

            if (t) // 如果是数字的话
            {
                for (int i = 0; i < num.Length; i++)
                {
                    if (num[i]>num[i+1])
                    {
                        char temp = num[i];
                        num[i] = num[i + 1];
                        num[i + 1] = temp;
                    }
                }
                
                string Num= new string(num);
                Console.WriteLine(Num);
            }
            else  // 如果不是数字 
            {
                for (int i = 0; i < num.Length/2; i++)
                {
                    char temp = num[i];
                    num[1] = num[num.Length - 1 - i];
                    num[num.Length-1-i]=temp;
                }
            }
        }
    };

    private void _77()
    {
        //编写一个类，其中包含一个排序的方法Sort(),当传入的是一串整数，就按照从小到大的顺序顺序，
        //如果传入的是一个字串，就将字符串反序输出。
        Console.WriteLine("输入字符串");
        string str =Console.ReadLine();
        
        ClassSort sort =new ClassSort();
        sort.Sort(str);
    }

    public class Rectangle
    {
        float length = 0;
        float width = 0;

        public float Length
        {
            get { return length; }
            set
            {
                length = value;
            }
        }

        public float Width
        {
            get { return length; }
            set
            {
                length = value;
            }
        }

        //周长
        public float Perimeter
        {
            get
            {
                return (length + width) * 2;
            }
        }

        // 面积
        public float Area
        {
            get
            {
                return length * width;
            }
        }

        public void LengthAndWidth(float length, float width)
        {
            this.Length = length;
            this.width = width;
        }

        public void ELength(float len)
        {
            this.Length = len;
        }

        public void EWidth(float wid)
        {
            width = wid;
        }

        public float GetLength()
        {
            return this.Length;
        }

        public float GetWidth()
        {
            return this.width;
        }
    };

    private void _78()
    {
        //编写一个矩形类，私有数据成员为矩形的长（len） 和 宽 （wid），无参构造函数将len和wid设置为9
        //有参构造函数设置和的值，另外，类还包括矩形的周长，求面积，取矩形的长度、取矩形的长度、取矩形的宽度
        //修改矩形的长度和宽度为对应的形参值等公用方法
        
        
    }

    public class stringClass
    {
        private string str = string.Empty;

        public string Str
        {
            get { return str; }
            set { str = value; }
        }

        // 字符串的长度
        public string Length()
        {
            char[] ss = this.str.ToCharArray(); //将字符串转换为数组z
            int len = ss.Length;
            return len.ToString();
        }

        public string Alocation()
        {
            // 字母A的位置
            char[] ss = this.str.ToCharArray();

            int location = 1;
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i] == 'a')
                {
                    location = i + 1;
                }
            }

            return location.ToString();
        }

        public string AddStr()
        {
            string addStr = str.Insert(3, "hellow");
            return addStr;
        }

        // 将hello 替换成me
        public string EdiStr(string Str)
        {
            string old = "hellow";
            string newstr = "me";
            string ediStr = Str.Replace(old,newstr);

            return ediStr;
        }

        // 用字母m将字符串分割，输出分割后的字符
        public string SplitStr(string ss)
        {
            string[] newStr = ss.Split('m');
            string aa = string.Empty;
            for (int i = 0; i < newStr.Length; i++)
            {
                aa = newStr[i];
            }

            return aa;
        }
    };

    private void _79()
    {
        // 1、输入字串长度
        // 2、输出字符串中第一个出现字母a的位置
        // 3、在字串符的第3个字符后面插入字串“hello”，输出新字符串。
        // 4、将字符串“hello” 替换成 “me” 输出新字串符
        // 5、以字符“m”为分隔符，将字符串分离，并输出分离后的字符串
        
        Console.Write("输入字符串");
        string myStr = Console.ReadLine();
        
        stringClass str= new stringClass();
        str.Str = myStr;
        Console.WriteLine("1:字符串的长度为{0}\n" +
                          "2: 第一次出现a的位置是；{1}\n" +
                          "3:插入hello后的字符串{2}\n" +
                          "4:将hello替换me字符串{3}\n",str.Length(),str.Alocation(),str.AddStr(),str.EdiStr(str.AddStr()));

        Console.WriteLine("5:用m分割 后的字符串{0}",str.SplitStr(str.EdiStr(str.AddStr())));
    }


}
