using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace _2025_second_assignment_2_23
{
    internal class Program
    {   
        //求素数，第一题
        List<int> GetPrimeFactor(int number)
        {
            List<int> result=new List<int>();
            for(int i=2;i*i<number;i++)
            {
                while(number%i==0){
                    if (result.Count==0 || result[result.Count-1]!=i)
                    {
                        result.Add(i);
                    }
                    number /= i;
                }
                
            }
            if(number!=1) result.Add(number);

            return result;
        }


        //求数组的编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和
        List<double> GetMaxMinNumber(List<double> InputLlist)
        {
            List<double> result=new List<double>();
            double MaxOne = InputLlist.Max();
            double MinOne=InputLlist.Min();
            double number = 0;
            for(int i = 0; i < InputLlist.Count; i++)
            {
                number += InputLlist[i];
            }
            result.Add(MaxOne);
            result.Add(MinOne);
            result.Add(number/InputLlist.Count);
            result.Add(number); 
            return result;  
        }
         


        //求2~100以类的素数
       void GetNeedNumber(int number)
        {
            bool[] arr= new bool[number+1];
            arr[0] = true;
            arr[1] = true;
            for(int i=2;i*i<=number;i++)
            {
                if (!arr[i])
                {
                    for(int j=i*2;j<number+1;j+=i )
                    {
                        arr[j] = true;
                    }
                }
            }

            for (int i = 0; i < number + 1; i++)
                if (!arr[i]) Console.WriteLine(i);
        }



        //判断矩阵
        bool Matrix(int[,] matrix)
        {
            int cow = 0;int low = 0;
            for(int i = 0; i <  matrix.GetLength(0);  i++)
            {
                low = i;  int number=0;
                while(cow<matrix.GetLength(0)&&low<matrix.GetLength(1))
                {
                    if (cow == 0) number = matrix[cow, low];
                    else
                    {
                        if (matrix[cow, low] != number) return false;
                        
                    }
                    low++; cow++;
                }
            }
            return true;
        }



        static void Main(string[] args)
        {  Program program = new Program();
            Console.Write("请输入一个数字求它的素数因子：");
         int number=int.Parse( Console.ReadLine());
         //第一个函数调用
            List<int>list=  program.GetPrimeFactor(number);
            Console.WriteLine("第一个函数运行结果：");
            for(int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);  Console.Write(" ");
            }

            Console.WriteLine("\n");





            //第二个函数调用
            List<double> list3 =new List<double> ();
            Console.Write("请输入一系列数以求最大值，最小值，平均值和和：");
            string []str = Console.ReadLine().Split(' ');
            for(int i=0;i< str.Length; i++)
                list3.Add(double.Parse(str[i]));    
            List<double> list2 = program.GetMaxMinNumber(list3);
            Console.WriteLine("第二个函数运行结果：");
            Console.WriteLine("分别是最大值，最小值，平均值，和");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i]); Console.Write(", ");
            }

            Console.WriteLine("\n");






            //第三个函数调用
            Console.Write("请输入一个数字要求不超过这个数字内的所有素数：");
            int number3=int.Parse( Console.ReadLine());
            Console.WriteLine("第三个函数运行结果：");
            program.GetNeedNumber(number3);
            Console.WriteLine("\n");

           // 第四个函数调用
            int[,] matrix = { { 1, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            int[,] m = { { 1, 2, 3 }, { 4, 5, 6 } };
           bool anser1= program.Matrix(matrix);
           bool anser2= program.Matrix(m);
            Console.WriteLine("第四个函数运行结果：");
            if (anser1) { Console.WriteLine("true"); } else { Console.WriteLine("false"); };
            if(anser2) { Console.WriteLine("true"); } else { Console.WriteLine("false"); }; 
        }
    }
}