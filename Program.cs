using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp11
{
    internal class Program
    {/// <summary>
     /// основные данные
     /// </summary>
     /// <param name="args"></param>
        static void Main(string[] args)
        {
            //double y = Function(5) + Function(12) + Function(19);
            //double a = Function(5, 7) + Function(12, 8) + Function(19, 2);
            //Console.WriteLine($"y={y:F1}");
            //Console.WriteLine($"a={a:F1}");
            //int b = Input("первая величина: ");
            //int c = Input("вторая величина: ");
            //int d = Input("третья величина: ");
            //int a = Input("первое число: ");
            //int b = Input("второе число: ");
            //int c = Input("третье число: ");
            //int d = Input("четвертое число:");
            //int max1 = Max(a,b);
            //int max2 = Max2(c,d);
            //int s=S(max1,max2);
            //Console.WriteLine($"s=max(a,b)+max(c,d)={s}");
            //int min=Min(b, c);
            //int min2=Min2(b, c, d);
            //Console.WriteLine($"минимальная величина:{min}");
            //Console.WriteLine($"минимальная величина: {min2}");
            
            Console.Read();
        }
        /// <summary>
        /// первое задание
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        //public static double Function(int x)
        //{ 
        // return (Math.Sqrt(x) + x) / 2;
        //}
        /// второе задание
        // static double Function(int x, int z)
        // {
        //    return (Math.Sqrt(x) + (x)) / (Math.Sqrt(z) + (z));
        // }

        public static int Input(string message)
        {
            Console.WriteLine(message);
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// поиск наименьшего из двух
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        //public static int Min(int b, int c)
        //{
        //   return (b < c) ? b : c;
        //}
        /// <summary>
        /// поиск наименьшего из трех
        /// </summary>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        //public static int Min2(int b, int c, int d)
        //{
        //if (b >= c && c <= d)
        //{
        //    return c;
        //}
        //else if (b<=c && c<=d)
        //{
        //    return b; 
        //}
        //else
        //{
        //    return d;
        //}
        //public static int Max(int a, int b)
        //{
        //    return (a > b) ? a : b;
        //}
        //public static int Max2(int c, int d)
        //{
        //    return (c > d) ? c : d;
        //}
        //public static int S(int max1, int max2)
        //{ 
        //    return max1+max2;
        //}
        
           
    }
}
