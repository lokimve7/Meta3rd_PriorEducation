using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalDay
{
    // 딜리게이트 : 함수를 담을 수 있는것
    delegate void Print(string text);

    interface IInteraction
    {
        void Interaction();
    }

    class Door : IInteraction
    {
        public void Interaction()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("문이 열렸습니다.");
        }
    }

    abstract class ItemBase : IInteraction
    {
        public ItemBase(string _name, int _price)
        {
            name = _name;
            price = _price;

            delegatePrint += AAAA;
            delegatePrint += PrintMyInfo;

            Console.WriteLine("ItemBase 생성자");
        }

        public virtual void Use()
        {
            Console.WriteLine($"{name} 을 사용합니다.");
        }

        public void GetInventory()
        {
            Console.WriteLine($"인벤토리에 {name} 이 들어갔습니다.");
        }

        public void Interaction()
        {
            GetInventory();
        }

        void PrintMyInfo(string text)
        {
            Console.WriteLine("저는 아이템 입니다.");
        }

        void AAAA(string text)
        {
            Console.WriteLine("저는 AAAA 함수입니다.");
        }

        abstract public void PrintInfo();

        public string name;
        public int price;

        public Print delegatePrint;
    }

    class HealingPotion : ItemBase
    {
        public HealingPotion(string _name, int _price) 
            : base(_name, _price)
        {
            Console.WriteLine("HealingPotion 생성자");

        }

        public override void PrintInfo()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine($"HP 가 채워집니다!");
        }
    }

    class ManaPotion : ItemBase
    {
        public ManaPotion(string _name, int _price) 
            : base(_name, _price)
        {
            Console.WriteLine("ManaPotion 생성자");

        }

        public override void PrintInfo()
        {
            throw new NotImplementedException();
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine($"MP 가 채워집니다!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {

            // ItemBase 형태의 클래스를 담는 변수
            List<ItemBase> itemList = new List<ItemBase>();


            // IInteraction 형태의 클래스를 담는 변수
            List<IInteraction> interationList = new List<IInteraction>();

            HealingPotion hp = new HealingPotion("HP 아이템", 1000);
            itemList.Add(hp);
            interationList.Add(hp);
            
            ManaPotion mp = new ManaPotion("MP 아이템", 2000);
            itemList.Add(mp);
            interationList.Add(mp);

            Door door = new Door();
            interationList.Add(door);


            hp.delegatePrint("111");

            //ItemBase itemBase = hp;
            //itemBase.Use();

            //hp.Use();
            //mp.Use();

            while (true)
            {
                Console.WriteLine("행동을 입력하세요 (1 : 힐링포션, 2 : 마나포션, 3 : Door)");

                string input = Console.ReadLine();
                // 숫자로 된 문자열을 int 데이터로 바꾼다.
                int key = int.Parse(input);

                // itemList 에 있는 데이터를 이용해서 Use 함수를 실행
                // itemList[key - 1].Use();

                interationList[key - 1].Interaction();

                //switch (key)
                //{
                //    case 1:
                //        hp.Interaction();
                //        break;
                //    case 2:
                //        mp.Interaction();
                //        break;
                //    case 3:
                //        door.Interaction();
                //        break;

                //}

                Console.WriteLine("");
            }


            Console.ReadKey();
        }
    }
}
