using System;
using System.Collections.Generic;
using System.Linq;
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
