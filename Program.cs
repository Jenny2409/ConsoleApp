using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Console.Write("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello" + name);
            Console.ReadKey();  
            */


            /*
           bool canVote = true;
           char grade = 'A';

           Console.WriteLine("unicode value :" +((int)grade).ToString("X4"));

           //이건 뭐?

           // this is going to hold a single 16-bit Unicode character 

           int maxInt = int.MaxValue;

           Console.WriteLine("Max Int: " + maxInt);

           var anotherName = "Tom";

           Console.WriteLine("anotherName is {0}", anotherName.GetTypeCode());
           //겟타입코드하면 이름 스트링이 나오는건가? 이걸왜?

           Console.ReadKey();
           // 영상에서는 리드키가 없는데도 유지되었다. 왜?
              */




            /*
         Console.WriteLine("5+3=" + (5 + 3));
         Console.WriteLine("5-3=" + (5 - 3));
         Console.WriteLine("5*3=" + (5 * 3));
         Console.WriteLine("5/3=" + (5 / 3));
         Console.WriteLine("5.2%3=" + (5.2 % 3));

         int i = 0;

         Console.WriteLine("i++=" + (i++));
         Console.WriteLine("i = " + i);
         Console.WriteLine("++i=" + (++i));
         Console.WriteLine("i--=" + (i--));
         Console.WriteLine("--i=" + (--i));

         i = i + 3; 
         //이거 있을 때랑 없을때 랑 설명 필요

         Console.WriteLine("i+=3 " + (i += 3));
         Console.WriteLine("i-=2 " + (i -= 2));
         Console.WriteLine("i*=2 "+ (i*=2));
         Console.WriteLine("i/=2 "+ (i/=2));
         Console.WriteLine("i%=2 " + (i%=2));

         Console.ReadKey();
          */


          
         
                double pi = 3.14;
            int intPi = (int)pi;
            Console.WriteLine("{0}", intPi);

            double number1 = 10.5;
            double number2 = 15;

             Random rand = new Random();
             Console.WriteLine("Give me the random number between 1 and 10 : " + (rand.Next(1,11)));
             Console.ReadKey();
             
            
            Console.Write("Type your age here : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to the elementary school");

            }
            else if ((age >= 7) && (age <= 13))
            {
                Console.WriteLine("Go to the middle school");
            }
            else if ((age>=14) && (age <=19))
            {
                Console.WriteLine("Go to the high school");
            }
           

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }
            else if ((age >= 15) || (age <= 66))
            {
                Console.WriteLine("You can work");
            }

            Console.WriteLine("! true : " + (!true));
            Console.ReadKey();

        }
    }
}
