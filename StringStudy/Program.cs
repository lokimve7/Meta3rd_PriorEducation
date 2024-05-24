using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace StringStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "AbCd";
           

            // 대문자를 소문자로 바꾸기
            str = str.ToLower();
            Console.WriteLine("대문자를 소문자로 : " + str);

            string strNew = "";
            for(int i = 0; i < str.Length; i++)
            {
                // i 번째에 있는 글자가 대문자이니?
                if(65 <= str[i] && str[i] <= 90)
                {
                    strNew += str[i] + 32;
                }
                else
                {
                    strNew += str[i];
                }
            }
            Console.WriteLine("대문자를 소문자로 : " + strNew);



            // 소문자를 대문자로 바꾸기
            str = str.ToUpper();
            Console.WriteLine("소문자를 대문자로 : " + str);

            // 앞 / 뒤 공백 삭제
            //str = str.Trim();
            //Console.WriteLine("앞 / 뒤 공백 삭제 : " + str);

            // 앞 공백 삭제
            str = str.TrimStart();            
            Console.WriteLine("앞 공백 삭제 : " + str);

            // 뒤 공백 삭제
            str = str.TrimEnd();
            Console.WriteLine("뒤 공백 삭제 : " + str);

            // 원하는 위치에 문자 삽입
            str = str.Insert(1, "가나다");
            Console.WriteLine("문자 삽입 : " + str);

            //A가나다BCD
            // 원하는 위치에서 원하는 갯수만큼 삭제하기
            str = str.Remove(4, 2);
            Console.WriteLine("문자 삭제 : " + str);

            // 문자 바꾸기
            str = "123123";
            str = str.Replace("123", "마바사");
            Console.WriteLine("문자 바꾸기 : " + str);

            // csv 파일 
            // 문자 나누기
            str = "월 화 수 목 금 토1일";

            char[] separator = {' ', '1' };
            string [] splitResult = str.Split(separator);
            for(int i = 0; i < splitResult.Length; i++)
            {
                Console.WriteLine(splitResult[i]);
            }

            // 원하는 위치에서 원하는 갯수만큼 잘라오기
            str = "월화수목금토일";
            str = str.Substring(4, 2);
            Console.WriteLine("문자 잘라오기 : " + str);

            // 찾고자 하는 글자가 몇 번째에 있는지
            str = "월화수목금토일";
            int index = str.IndexOf("수");
            Console.WriteLine("자리 알아오기 : " + index);

            // 문자열 조합
            int num1 = 10;
            int num2 = 20;
            int sum = num1 + num2;
            // strSum = "10 + 20 = 30 이다";
            string strSum1 = num1 + " + " + num2 + " = " + sum + " 이다";
            
            //Console.WriteLine("{0} + {1} = {2} 이다", num1, num2, sum);
            Console.WriteLine($"{num1} + {num2} = {sum} 이다");

            // 재화표시 (,100,000,000)
            int money = 100000000;
            //string strMoney = $"남은 금액 : {money:#,0} 원";
            string strMoney = money.ToString();
            string strNewMoney = "";
            //int count = 0;
            for(int i = strMoney.Length - 1; i >=0; i--)
            {
                strNewMoney = strMoney[i] + strNewMoney;
                // 3번을 더했으면 ,를 하나 더 붙이자
                //count++;
                //if(count == 3 && i > 0)
                //{
                //    strNewMoney = "," + strNewMoney;
                //    count = 0;
                //}

                if(strMoney.Length % 3 == i % 3 && i > 0)
                {
                    strNewMoney = "," + strNewMoney;
                }
            }

            Console.WriteLine(strNewMoney);

            // 시간을 초단위 관리 => 분 초
            int time = 610; //10분 10초
            int min = time / 60;
            int sec = time % 60;
            Console.WriteLine($"{min}분 {sec}초");

            // 아스키코드
            char a = 'a';
            char b = 'b';


            // 
            

            Console.WriteLine("\"김현진\" \\");

            solution("ProgrammerS123", 11);

            Console.ReadKey();
        }

        static string solution(string my_string, int n)
        {
            string answer = "";

            int startIndex = my_string.Length - n;
            answer = my_string.Substring(startIndex);            

            //grammerS123
            return answer;
        }
    }
}
