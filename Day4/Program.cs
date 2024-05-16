using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

// 스무고개 (야구게임)
// 1 ~ 9 숫자를 랜덤하게 하나씩 뽑아서 총 3개를 뽑자 (3, 6, 9)
// 사람1. 123 --> 문제. 1볼 2아웃
// 사람2. 145 --> 문제. 3아웃
// 사람1. 267 --> 문제. 1스타크라이

// Swap, Shuffle 알고리즘
// 

namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 랜덤한 숫자 뽑자.
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int[] numbers = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] numbers = new int[9];
            for(int i = 1; i < numbers.Length + 1; i++)
            {
                numbers[i - 1] = i;
            }

            List<int> numList = new List<int>();
            for(int i = 0; i < 9; i++)
            {
                numList.Add(i + 1);
            }
            

            Shuffle(numbers);

            string strNumbers = "";
            strNumbers += numbers[0];
            strNumbers += numbers[1];
            strNumbers += numbers[2];

            //Console.Write("랜덤 숫자 : " + strNumbers);
            Console.WriteLine();

            int strikeCnt = 0;
            int ballCnt = 0;
            int outCnt = 0;

            while (strikeCnt < 3)
            {
                // 2. 숫자 입력 받자
                Console.Write("숫자를 입력하세요 : ");
                string inputNumber = Console.ReadLine(); //123

                // 3. inputNumber 와 랜덤 숫자를 비교
                strikeCnt = 0;
                ballCnt = 0;
                outCnt = 0;

                for (int i = 0; i < inputNumber.Length; i++)
                {
                    // 아웃인지 아닌지
                    bool isOut = true;

                    for (int j = 0; j < strNumbers.Length; j++)
                    {
                        // 스크라이크 or 볼
                        if (inputNumber[i] == strNumbers[j])
                        {
                            // 자릿수가 같니? 
                            if (i == j)
                            {
                                // 스트라이트 갯수 증가
                                strikeCnt++;
                            }
                            // 자리수가 같지않으나 값은 같다.
                            else
                            {
                                // 볼 갯수 증가
                                ballCnt++;
                            }

                            // 아웃이 아니다!
                            isOut = false;
                        }
                    }

                    // 만약에 아웃이면 outCnt 증가
                    if (isOut == true)
                    {
                        outCnt++;
                    }
                }

                // 비교한 결과 출력
                Console.WriteLine(strikeCnt + " 스트라이크, " + ballCnt + " 볼, " + outCnt + "아웃");

                // 만약에 strikeCnt 가 3이면 정답!
                if(strikeCnt == 3)
                {
                    Console.WriteLine("정답입니다!");
                }
            }
            

            Console.ReadKey();
        }

        static void Shuffle(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                // 랜덤한 숫자를 뽑자 (0 ~ 8)               
                int randIdx1 = rand.Next(0, 9);
                int randIdx2 = rand.Next(0, 9);
                Swap(array, randIdx1, randIdx2);
            }
        }

        static void Swap(int[] array, int m, int n)
        {
            int temp = array[m];
            array[m] = array[n];
            array[n] = temp;
        }
    }
}
