using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    // 선입 후출 (먼저 입력된 값이 나중에 뽑힌다)
    class MyStack<T>
    {
        T[] array = new T[0];
        int size = 0;

        public void Push(T data)
        {
            if(size == array.Length)
            {
                int num = size == 0 ? 4 : size * 2;
                T[] newArray = new T[num];
                Array.Copy(array, newArray, size);
                array = newArray;
            }

            array[size] = data;
            size++;
        }

        public T Pop()
        {
            // size 를  하나 줄여준다.
            size--;
            T result = array[size];
            // size 자리에 있는 값을 초기화
            array[size] = default(T);

            // 결과를 반환
            return result;
        }
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            MyStack<float> myStack = new MyStack<float>();
            myStack.Push(3.14f);
            myStack.Push(9.81f);
            myStack.Push(333);

            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
        }
    }
}
