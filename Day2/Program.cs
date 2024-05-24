using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 자료형 (int, float, bool, string, 사용자 자료형(class))
// 변수 : 데이터를 담을 그릇

// 비교연산자 : > , < , <= , >= , == , !=
// 논리연산자 : &&, ||

// 조건문 (if)
/*
    if(조건식1 && 조건식2 || 조건식3)
    {
        // 위 조건이 true 이면 실행되는 코드
        
    }
    else if(조건식4)
    {
        
    }
    else if(조건식5)
    {
    }
    else
    {
    }
 */

// 반복문 (for)
/*
    for(변수초기화; 조건식; 증감값)
    {
        
    }
 */

// 함수
/*
    반환자료형 함수이름(매개변수1, 매개변수2, ....)
    {
        return 반환값;
    }
 */

// 배열 : 여러 데이터를 담을 수 있는 그릇

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = { "지연", "현진", "메타버스", "라파" };

            for (int i = 0; i < studentName.Length; i++)
            {
                Console.WriteLine(studentName[i]);
            }
            Console.ReadLine();
        }

        // 함수의 오버로딩 : 같은 함수 이름을 함수를 만들 수 있다.
        // 단, 매개 변수가 달라야 한다.


        static int Add(int m, int n)
        {
            int sum = m + n;
            return sum;
        }

        static int Add()
        {
            int num1 = 100;
            int num2 = 50;
            int sum = num1 + num2;

            return sum;
        }


        void StudyFor()
        {
            int num = 10;
            num = num + 1;
            num += 1;
            num--;
                       
            int i;
            for (i = 2; i < 5; i += 2)
            {
                // 만약에 i 가 1보다 커지면 출력하지마!
                if (i > 1)
                {
                    break;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("마지막 i 의 값 : " + i);
        }


        static void StudyIf()
        {
            int num1 = 50;
            int num2 = 77;
            int num3 = 100;

            bool isBool = num1 < num2 && num1 > num3;

            if (isBool)
            {
                Console.WriteLine("num1 이 num2 보다 작습니다.");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("num1 이 num2 보다 큽니다.");
            }
            else
            {
                Console.WriteLine("num1 이 num2 와 같다.");
            }

            if (num1 < num2)
            {
                Console.WriteLine("num1 이 num2 보다 작습니다.");

            }
        }
    }
}
