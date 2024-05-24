using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class MyQueue
    {
        // 데이터를 담을 공간
        int[] array = new int[0];

        // 실제 데이터 갯수
        int size = 0;

        // 가져올때 (Dequeue) 배열의 index
        int head = 0;

        // 추가할때 (Enqueue) 배열의 index
        int tail = 0;

        // 추가 하는 함수
        public void Enqueue(int item)
        {
            if (size == array.Length)
            {
                int num = size == 0 ? 4 : size * 2;
                int [] newArray = new int[num];

                //Array.Copy(array, newArray, size);
                // head 위치 부터 끝까지 복사
                Array.Copy(array, head, newArray, 0, size - head);
                // 처음부터 size - head 위치에 복사
                Array.Copy(array, 0, newArray, size - head, tail);

                array = newArray;
                head = 0;
                tail = size;
            }

            array[tail] = item;
            tail = (tail + 1) % array.Length;
            size++;
        }

        // 가져오는 함수
        public int Dequeue()
        {
            int result = array[head];
            array[head] = 0;
            head = (head + 1) % array.Length;
            size--;

            return result;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue myQueue = new MyQueue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(3);
            myQueue.Enqueue(4);
            //int result = myQueue.Dequeue();
            myQueue.Enqueue(5);
            myQueue.Enqueue(6);
        }
    }
}
