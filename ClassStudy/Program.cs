
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace ClassStudy
{   
    struct AnimalInfo
    {
        public AnimalInfo(string _name)
        {
            name = _name;
            age = 0;
            color = "";
        }

        public string name;
        public int age;
        public string color;
    }

    class Animal
    {
        public string name;
        public int age;
        public string color;

        protected float weight;

        public void PrintInfo()
        {
            Console.WriteLine($"{name} 의 나이는 {age} 살 입니다. 색은 {color} 입니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine("움직이는 중~");
        }
    }

    class Dog : Animal
    {
        //생성자
        public Dog()
        {
            Console.WriteLine("강아지 객체 생성");
        }

        public Dog(string _name, int _age, string _color)
        {
            name = _name;
            age = _age;
            color = _color;
        }

        //소멸자
        ~Dog()
        {
            Console.WriteLine("해제 됨");
        }
      

        public void Bark()
        {
            Console.WriteLine($"몸무게가 {weight} 인  {name} 이 짖습니다.");
        }

        public override void Move()
        {
            base.Move();

            Console.WriteLine($"당당하게 걷습니다.");

        }
    }


    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{name} 이 웁니다.");
        }

        public override void Move()
        {
            Console.WriteLine($"사뿐사뿐 걷습니다.");

        }
    }

    internal class Program
    {        

        static void Main(string[] args)
        {
            // Dog 객체를 만들자
            Dog dog1 = new Dog("누렁이", 10, "노란색");
            
            //dog1.name = "누렁이";
            //dog1.age = 10;
            //dog1.color = "노란색";
            dog1.PrintInfo();
            dog1.Move();

            Dog dog2 = new Dog();
            dog2.name = "검둥이";
            dog2.age = 2;
            dog2.color = "검정색";
            dog2.PrintInfo();

            Dog dog3 = new Dog("잭슨", 9, "흰색");
            dog3.PrintInfo();

            Cat cat1 = new Cat();
            cat1.name = "나비";
            cat1.age = 20;
            cat1.color = "얼룩색";
            cat1.PrintInfo();
            cat1.Move();

            Animal[] animals = new Animal[3];
            animals[0] = dog1;
            animals[1] = cat1;
            animals[2] = dog2;

            AnimalInfo animInfo;
            animInfo.age = 111;

            //dog1.Move();
            //cat1.Move();
            //dog2.Move();

            for(int i = 0; i < animals.Length; i++)
            {
                animals[i].Move();
            }


            //string dogName1 = "누렁이";
            //string color1 = "노란색";
            //int age1 = 10;

            //Console.WriteLine($"{dogName1} 의 나이는 {age1} 입니다. 색은 {color1} 입니다.");


            //string dogName2 = "검둥이";
            //int age2 = 2;

            //Console.WriteLine($"{dogName2} 의 나이는 {age2} 입니다.");


            //string dogName3 = "잭슨";
            //int age3 = 9;

            //Console.WriteLine($"{dogName3} 의 나이는 {age3} 입니다.");

            Console.ReadKey();                
        }
    }
}
