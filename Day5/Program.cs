using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Program
    {
        class MyList
        {
            // 추가 되야하는 index
            int currIdx = 0;
            // 데이터를 가지고 있는 배열
            int[] array = new int[0];

            // 추가 함수
            public void Add(int item)
            {
                Expand();

                // currIdx 자리에 값을 넣자.
                array[currIdx] = item;

                // currIdx 의 값을 하나 증가시키자
                currIdx++;
            }

            // 추가 함수
            public void Insert(int index, int item)
            {
                // 범위를 벗어난 index 면 오류를 던지자.
                if(index > currIdx)
                {
                    throw new ArgumentOutOfRangeException();
                }

                Expand();

                // 만약에 index 가 curridx 보다 작으면 
                if(index < currIdx)
                {
                    // 데이터를 index 에 넣고, index 뒷부분은 뒤로 미룬다.
                    Array.Copy(array, index, array, index + 1, currIdx - index);

                    //for(int i = currIdx; i > index; i--)
                    //{
                    //    array[i] = array[i - 1];
                    //}
                }

                array[index] = item;

                // currIdx 의 값을 하나 증가시키자
                currIdx++;
            }

            // 삭제 함수
            public void RemoveAt(int index)
            {
                // 범위를 벗어난 index 면 오류를 던지자.
                if (index > currIdx)
                {
                    throw new ArgumentOutOfRangeException();
                }

                currIdx--;

                Array.Copy(array, index + 1, array, index, currIdx - index);

                //for(int i = index + 1; i < currIdx; i++)
                //{
                //    array[i - 1] = array[i];
                //}

                array[currIdx] = 0;
            }

            public void Remove(int item)
            {
                // item 과 같은 값을 가지는 array 의 index 를 찾자
                int index = Array.IndexOf(array, item);
                RemoveAt(index);

                //for(int i = 0; i < currIdx; i++)
                //{
                //    if (array[i] == item)
                //    {
                //        // 찾은 index 를 지우자.
                //        RemoveAt(i);
                //        // 반복문을 종료
                //        break;
                //    }
                //}
            }

            // 공간 확보 함수
            void Expand()
            {
                // currIdx 와 array 의 길이가 같으면 array 의 공간을 넓히자.
                if (currIdx == array.Length)
                {
                    // 1. 넓어야하는 공간 갯수
                    int size = currIdx == 0 ? 4 : currIdx * 2;

                    //if (currIdx == 0) size = 4;
                    //else size = array.Length * 2;

                    // 2. 공간 만큼 배열을 하나 만들자.
                    int[] newArray = new int[size];
                    // 3. 새로만든 배열에 기존 배열값을 복사하자.
                    Array.Copy(array, newArray, array.Length);

                    //for(int i = 0; i < array.Length; i++)
                    //{
                    //    newArray[i] = array[i];
                    //}

                    // 4. 새로만든 배열의 array 로 셋팅하자.
                    array = newArray;
                }
            }
        }

        static void Main(string[] args)
        {
            MyList myList = new MyList();
            myList.Add(5000);
            myList.Add(2000);
            myList.Add(5000);
            myList.Add(4000);
            myList.Add(5000);

            //myList.RemoveAt(4);
            myList.Remove(5000);




            List<int> intList = new List<int>();

            // 추가 방법
            intList.Add(10);
            intList.Add(20);

            // 수정 방법
            intList[0] = 100;
            intList[1] = 200;

          

            // 읽어오는 방법
            Console.WriteLine("첫 번째 값 : " + intList[0]);    
            Console.WriteLine("두 번째 값 : " + intList[1]);

            // 삽입 방법
            intList.Insert(1, 150); //100, 150, 200

            // 삭제 방법
            intList.RemoveAt(1);    //100, 200
            intList.Remove(100);    //200
            intList.Clear();
        }
    }
}
