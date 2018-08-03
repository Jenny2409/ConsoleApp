using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program_20180801
    {
        static void Main(string[] args)
        {
            /*
            bool canDrive = age >= 16 ? true : false;
            int canDo = age >= 16 ? 1 : 0;
            Console.WriteLine("{0}", canDrive);
            Console.WriteLine("{0}", canDo);
            Console.ReadKey();



            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler");

                                                           default:
                                                           Console.WriteLine("Just Child or Adult");
                                                           break;
                         
                    goto Cute;


            }
            Cute:
            Console.WriteLine("Toddlers are Cute");
            Console.ReadKey();
            */

            //while loop
            /*
             int i = 0;
              while (i < 20)
              {
                  if (i == 7)
                  {
                      i++;
                      continue;
                  }
                  if (i == 15)
                  {
                      Console.WriteLine(i);
                      break;
                  }
                  if ((i % 2) > 0)
                  {
                      Console.WriteLine(i);
                  }
                  i++;

              }
              Console.ReadKey();
            //홀수만 나오게 하는데 왜 7은없고 그래? 그리고 만약에 i=7했을때 8부터 15까지 나오게 하는건 저첫두개의 if 문의 용도가 아닌가? 그리고 끝에 i++하는것도 왜?
            */
            //do while
            //선언
            /*string guess;

            do
            {
                Console.WriteLine("Guess a Number");
                //초기화
                guess = Console.ReadLine();
            }
            while (!guess.Equals("15"));
            //선언 + 초기화 방법 string guess = Console.ReadLine();
            */


            //for 문
            /*
          for (int i = 0; i < 10; i++) 
          {
              if ((i % 2) > 0)
              {
                  Console.Write(i+" "); //\n  \t

              }
          }
          Console.ReadKey();
          */

            //인강에서는 1,3,5,7,9가 한번에 떴는데 나는 왜 엔터쳐야지 뜨지? 밑에 foreach도 마찬가지!

            //foreach 문

            /* string randStr = "Here are some random character";

             foreach (char a in randStr)
             {
                 Console.WriteLine(a);

             }
              Console.ReadKey();
              */
            //string
            /*
            string sampString = "A bunch of random words";

             Console.WriteLine("Is empty " + String.IsNullOrEmpty(sampString));
             Console.WriteLine("Is empty " + String.IsNullOrWhiteSpace(sampString));
             Console.WriteLine("String Length: " + sampString.Length);


             Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));
             Console.WriteLine("2nd Word " + sampString.Substring(2, 6));

             Console.ReadKey();
*/
            /*
                        string sampString = "  A bunch of random words  ";
                        string sampString2 = "More random words";

                        Console.WriteLine("Strings Equal? " + sampString.Equals(sampString2));

                        Console.WriteLine("Start with \"A bunch\"" + sampString.StartsWith("A bunch"));

                        Console.WriteLine("Ends with \"words\"" + sampString2.EndsWith("words"));

                        Console.ReadKey();

                        Console.WriteLine(sampString.Trim());


                        Console.WriteLine(sampString.TrimEnd());


                        Console.WriteLine(sampString.TrimStart()); */

            /*sampString = sampString.Replace("words", "characters");
            Console.WriteLine(sampString);

            sampString = sampString.Remove(0, 2);
            Console.WriteLine(sampString);

            Console.ReadKey(); */

            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine("Name List : " + String.Join("->", names)); //join 괄호안이 이해가 안됨
            Console.ReadKey();


            Console.Write("baby");
            Console.ReadKey();
        }

    }
}
