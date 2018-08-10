using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }

        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.name = "No Name";
            this.sound = "No Sound";
            numOfAnimals++; //총생성한 Animal 을 찾아 증가시키는 기능도 만들었어 ?무슨말?
        }
        public Animal(double height, double weight, string name, string sound)
        {
            this.height = height; //this를 앞에서 공부한거 찾아보니까 메소드의 매개변수와 멤버변수명이 같을때 구분하기 위해서
            this.weight = weight;
            this.name = name;
            this.sound = sound;
            numOfAnimals++;
        }
        static int numOfAnimals = 0;

        public static int getNumOfAnimals()
        {
            return numOfAnimals; //NumofAnimals 라고 안해도 되나?
        }

        public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3}", name, height, weight, sound);
        }

        //여기서부터는 overloading method 를 알려줌 하나의 메소드 명에 다양한 매개변수 적용이라고 하는데 그럼 여기서 getSum이 메소드명?
        public int getSum(int num1 = 1, int num2 = 1)
        {
            return num1 + num2;
        }

        public double getSum(double num1 = 1, double num2 = 1)
        {
            return num1 + num2;
        }
        //오버로딩 어떻게 작용되는지는 밑에서 콘솔라이트라인으로 불러서 확인

        static void Main(string[] args)
        {
            Animal spot = new Animal(15, 10, "Spot", "Woof");

            //15랑 10은 키랑 무겐거는 알겠는데 콘솔화면에 출력하려면 어케해야되지? 

            Console.WriteLine("{0} says {1}", spot.name, spot.sound);

            Console.WriteLine("Number of Animals : " + Animal.getNumOfAnimals());
            // 동물의 수를 1마리 말고 여러마리 출력해보고 싶으면 어케?

            //static method 는 클래스에 속해있지 오브젝트에 속해 있는게 아니니까 (?)뭔말

            Console.WriteLine(spot.toString());

            Console.WriteLine(spot.getSum(1.5, 2.5));

            Console.WriteLine(spot.getSum(num2: 1.5, num1: 2.5));

            Console.ReadKey();
            //오브젝트를 오브젝트 초기자(initializer) 란 것을 통해 생성할 수 있어.

            Animal grover = new Animal
            {
                name = "Grover",
                height = 16,
                weight = 18,
                sound = "Grrrr"
            }; //C#에서 오브젝트를 생성하는 또 다른 방법. 모르겠음.


            //저 밑에 new 만든거랑 차이점 보기 위해서 여기에 Dog 을 생성해서 이것들을 실행해보자
            Dog spike = new Dog();

            Console.WriteLine(spike.toString());

            spike = new Dog(20, 15, "Spike", "Grrr", "Chicken");

            //개에대해서 두가지 다른 방법으로 생성해본거임
            Console.WriteLine(spike.toString());

            //왜 출력이 안되..
            Console.ReadKey();
        }
    }
    //Aniaml 에 대한 서브클래스 (자식클래스 Subclass)를 만들 수 있음. 그 Subclass는 Animal 클래스에 정의된 모든 속성과 메소드를 가지게 되지.

    class Dog : Animal
    {
        public string favFood { get; set; }

        public Dog() : base()
        {
            this.favFood = "No Favorite Food";
        }

        public Dog(double height, double weight, string name, string sound, string favFood) : base(height, weight, name, sound)
        {
            this.favFood = favFood;
        }
        //dog class 에서 animal class 의 메소드를 오버라이드 할꺼야 예를들어 toString()을 override 한다고 치면 
        //메소드를 오버라이드 할때는 new 키워드를 타이핑해. 그러면 오버라이딩 한거야.

        new public string toString()
        {
            return String.Format("{0} is {1} inches tall, weighs {2} lbs and likes to say {3} and eats {4}", name, height, weight, sound, favFood);
        }





    }
}


   

