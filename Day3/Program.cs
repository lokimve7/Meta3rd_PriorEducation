using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SelectSort();
            //BubbleSort();
            InsertSort();


            Console.ReadKey();
        }

        static void Swap(int[] array, int m, int n)
        {
            int temp = array[m];
            array[m] = array[n];
            array[n] = temp;
        }

        // 선택정렬
        static void SelectSort()
        {
            int[] array = { 4, 10, 7, 1, 8, 100, -1, -50, 11, 255 };

            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        // i번째 값이랑 j번째 값을 바꾸자
                        // 스왑(swap)
                        Swap(array, i, j);
                    }
                }
            }

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        // 버블정렬
        static void BubbleSort()
        {
            int[] array = new int[5];
            array[0] = 4;
            array[1] = 10;
            array[2] = 7;
            array[3] = 1;
            array[4] = 8;

            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        // 삽입 정렬
        static void InsertSort()
        {
            int[] array = new int[5] { 4, 10, 7, 1, 8 };
          
            for (int i = 1; i < array.Length; i++)
            {
                for(int j = i; j >= 1; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        Swap(array, j - 1, j);
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
