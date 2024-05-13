using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Meta
    {
        public int studentCount;
        public string lectureName;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수 (그릇), 자료형
            // int, float, bool, string
            // int : 정수 (-1, -2, 0, 1, 2, 3)
            // float : 실수 (정수 + 부동소수점)

            int number1 = 1;
            int number2 = 2;
            TestFunc(number1, number2);

            Meta meta1 = new Meta();
            meta1.studentCount = 40;
            meta1.lectureName = "슈팅";

            Meta meta2 = new Meta();
            meta2.studentCount = 40;
            meta2.lectureName = "FPS";

            Meta meta3 = new Meta();
            meta3.studentCount = 38;
            meta3.lectureName = "네트워크";

            ChangeMetaInfo(meta1, meta2, meta3);

            int bitOr = 40 | 38;
            int bitAnd = 40 & 38;
        }

        static void ChangeMetaInfo(Meta m1, Meta m2, Meta m3)
        {
            m1.studentCount = 80;

            m2.studentCount = 100;

            m3.studentCount = 120;
        }

        static void TestFunc(int num1, int num2)
        {
            num1 = 10;
            num2 = 100;
        }
    }
}
