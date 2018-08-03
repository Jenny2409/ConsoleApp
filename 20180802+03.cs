using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program_20180802
    {
        static void Main(string[] args)
        {
            /*
            string sampString = "A bunch of random words";

            string sampString2 = "More random words";

            string fmtStr = String.Format(" {0:c} {1:00.00} {2:#.00} {3:0,0} ", 1.56, 15.567, .56, 1000);

            Console.WriteLine(fmtStr);
            Console.ReadKey();

            //String Builder

            StringBuilder sb = new StringBuilder();

            sb.Append("This is the first sentence");
        
            sb.AppendFormat("\nMy name is {0} and I live in {1} ", "jenny", "truro");

            sb.Replace("e", "a");
            //나는 이렇게 해보니까 그래도 되는데? 왜 아래처럼 해야되지?Console.WriteLine(sb);
            sb.Remove(5, 7); //index 5부터 7까지 제거했는데 왜 is 랑 the 랑 둘다 없어졌지?
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
            */
            //20180803
            //array


            /*
            int[] randNumArray;
            int[] randArray = new int[5];
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            Console.Write("Where is number 1: " + Array.IndexOf(randArray2, 1));

            string[] names = { "Tom", "Paul", "Sally" };
            string nameStr = string.Join(",", names);
            string[] nameArray = nameStr.Split(',');
            

            //왜 위에 3줄은 안나와... 어떻게 해야지 나와

            /*Console.WriteLine("Array Length : " + randArray2.Length);
            Console.WriteLine("Item 0 " + randArray2[0]);
            for (int i = 0; i < randArray2.Length; i++) 
            {
                Console.WriteLine("{0} : {1}", i, randArray2[i]);
            }

            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }
            
           

            //다중배열 -> 요것도 모르겠고
            int[,] multArray = new int[5, 3];
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };
            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }

            for (int x = 0; x < multArray2.GetLength(0); x++)
            {
                for (int y = 0; y < multArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x, y]);
                }
            }
            //List

            List<int> numList = new List<int>();

            numList.Add(5);
            numList.Add(15);
            numList.Add(25);

           // int[] randArray = { 1, 2, 3, 4, 5 }; 왜 이게 빠져야되? 어디서 이미 정의를 했다는거지?
            numList.AddRange(randArray);

            List<int> numList2 = new List<int>(randArray);
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            numList.Insert(1, 10);
            numList.Remove(5);
            numList.RemoveAt(2);

            for (int i = 0; i < numList.Count; i++)
            {
              Console.WriteLine(numList[i]);
            }
          

            Console.WriteLine("4 is in index " + numList3.IndexOf(4));
            Console.WriteLine("5 in List " + numList.Contains(5));

            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });

            Console.WriteLine("Tom in List " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase)); 소문자로 해도 된다는거 보여주기 위해서 해야함

            strList.Sort(); //아이템의 데이터 타입종류에 따라 뭐오름차순으로 정리한다는데 모르겠어

            Console.ReadKey();
            
            //try and catch 예외처리

            try
            {
                Console.WriteLine("Divide 10 by");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} = {1}", num, (10 / num));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero"); //여기 밑에 두개는 왜하는거고? 콘솔에 나오는게 이해가 안됨
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
            */

            //클래스와 오브젝트

        }

        class Animal
        {
            static void Main(string[] args)
            {
            }
}