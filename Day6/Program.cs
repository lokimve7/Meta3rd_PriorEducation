using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    class Node
    {
        // 내 다음 Node를 담을 변수
        public Node next;

        // 내 앞의 Node를 담을 변수
        public Node prev;

        // 데이터 값
        public string data = "";
    }

    class MyLinkedList
    {
        // 데이터 갯수
        int count = 0;
        // 처음 Node
        Node first;
        // 마지막 Node
        Node last;

        // 추가 함수
        public void Add(string item)
        {
            // 새로운 Node 를 만든다.
            Node node = new Node();
            node.data = item;

            // 만약에 first 가 null 이라면 (없다면)
            // 만약에 count 가 0 이라면
            if(count == 0)
            {
                first = node;
            }
            else
            {
                last.next = node;
                node.prev = last;
                
            }

            // 새로 추가된 node 를 last 롤 설정
            last = node;

            // 갯수 증가
            count++;
        }

        // 삽입 함수
        public void Insert(int index, string item)
        {
            Node node = new Node();
            node.data = item;

            // 만약에 첫번째 자리에 추가한다면 (index 가 0 이라면)
            if(index == 0)
            {
                node.next = first;
                first.prev = node;
                
                first = node;
            }
            else
            {
                // 처음 Node 에서 index 의 위치한 node 를 찾자
                Node temp = first;
                int i = 0;

                while (temp != null)
                {
                    if (index - 1 == i)
                    {
                        // 새로 만든 node 의 다음을 index 자리에 있던 node 로 설정
                        node.next = temp.next;
                        node.prev = temp;

                        temp.next.prev = node;
                        // 바꾸고자 하는 인덱스 앞의 Node의 다음을 새로운 Node로 설정
                        temp.next = node;
                        // 반복문을 종료한다.
                        break;
                    }

                    i++;
                    temp = temp.next;
                }

                // 만약에 index 가 count 와 같다면
                if(index == count)
                {
                    last = node;
                }
            }            

            // 데이터 갯수 증가
            count++;
        }

        // 지우는 함수
        public void RemoveAt(int index)
        {
            if(index == 0)
            {
                first = first.next;
                first.prev = null;
            }

            Node temp = first;
            int i = 0;
            while(temp != null)
            {
                if(index - 1 == i)
                {
                    temp.next.next.prev = temp;

                    temp.next = temp.next.next;
                    break;
                }

                i++;
                temp = temp.next;
            }

            if(index == count - 1)
            {
                last = temp;
            }

            count--;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList linkedList = new MyLinkedList();
            linkedList.Add("월"); 
            linkedList.Add("화"); 
            linkedList.Add("수"); 

            linkedList.Insert(0, "공휴일");
            linkedList.Insert(4, "일요일");

            linkedList.RemoveAt(4);
        }
    }
}
