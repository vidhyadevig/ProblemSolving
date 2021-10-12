using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseString();
            //Palindrome();
            //ReverseWordOrder();
            //CountCharsInaString();
            //findallsubstring();
            //sumOfDigits();
            //thirdLargest();
            //test();
            //solve(new int[] { 1, 3, 13, 31, 33, 34, 44, 46, 50, 62, 64, 65, 69, 70, 74, 75, 77, 94, 105, 108, 109, 111, 114, 115, 116, 126, 128, 132, 139, 145, 146, 149, 153, 157, 158, 164, 166, 175, 178, 187, 188, 195, 197, 198, 201, 204, 207, 208, 209, 210, 212, 218, 222, 237, 242, 244, 247, 252, 255, 263, 264, 266, 273, 276, 277, 284, 292, 294, 300, 308, 325, 335, 338, 342, 346, 348, 351, 352, 353, 354, 356, 365, 370, 373, 382, 384, 385, 398, 405, 410, 426, 427, 428, 447, 448, 455, 457, 459, 465, 497 });
            //happyNumber();
            //ifUniqueChars();
            jumpingOnClouds(new List<int> { 0, 0, 1, 0, 0, 1, 0 });
        }

        public static int jumpingOnClouds(List<int> c)
        {
            int jumps = 0, i = 0;
            while (i < c.Count)
            {
                if (i < c.Count - 2 && c[i + 2] == 0)
                    i += 2;
                else if (i < c.Count - 1 && c[i + 1] == 0)
                    i++;
                else
                    break;
                jumps++;
            }
            return jumps;

        }

        static void ifUniqueChars()
        {
            string s = "apple";
            bool[] chkChars = new bool[256];
            foreach(char c in s)
            {
                if (!chkChars[(int)c])
                    chkChars[(int)c] = true;
                else
                    Console.WriteLine("Has duplicate char");
            }
        }

        static bool happyNumber()
        {
            int num = Convert.ToInt32(Console.ReadLine().TrimEnd());
            int sum = 0, temp = num;
            //19
            List<int> lst = new List<int>();


            while (true)
            {
                sum += (temp % 10) * (temp % 10);

                if (temp >= 10)
                    temp /= 10;
                else
                {
                    if (lst.Contains(sum))
                        return false;
                    else
                    {
                        if (sum == 1 || sum == 7)
                            return true;

                        lst.Add(sum);
                        temp = sum;
                        sum = 0;
                    }
                }


            }
            //return false;


        }
        static int solve(int[] p)
        {
            int maxProfit = 0;

            // Write your code here
            for (int i = 0; i < p.Length; i++)
            {
                int range = 1;
                while (range < p.Length)
                {
                    int localProfit = p[i];
                    int temp = p[i];
                    for (int j = i + range; j < p.Length; j++)
                    {

                        if (p[j] > temp && p[j] % temp == 0)
                        {
                            localProfit += p[j];
                            temp = p[j];
                        }
                    }
                    if (localProfit > maxProfit)
                        maxProfit = localProfit;
                    range++;
                }
            }
            return maxProfit;
        }

        //public class HelloWorld
        //    {
        //        static public void Main()
        //        {
        //            String line;
        //            line = Console.ReadLine();
        //            int n = Convert.ToInt32(line);
        //            line = Console.ReadLine();
        //            int[] p = new int[n];
        //            p = line.Split().Select(str => int.Parse(str)).ToArray();

        //            int out_ = solve(p);
        //            Console.Out.WriteLine(out_);
        //        }

        static void test()
        {
            //List<int> inpu = Console.ReadLine().Split(' ').ToList().Select(x => Convert.ToInt32(x)).ToList();
            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //dynamic a = "n";
            //a = a * 10;
            //var t = a.GetType();

            object a = "vid";
            char[] n = { 'v', 'i', 'd' };
            object b = new string(n);
            Console.WriteLine(a == b);
        }


        //String reversal
        static void ReverseString()
        {
            string str = "vidhya devi g";

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }

        static void Palindrome()
        {
            string str = "madame";
            bool flag = true;
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    Console.WriteLine("Not palidrome");
                    flag = false;
                    break;
                }

            }
            if (flag)
                Console.WriteLine("Palidrome");
        }

        static void ReverseWordOrder()
        {
            string str = "I am a robot";

            string[] arrStr = str.Split(" ");
            string[] revStr = new string[arrStr.Length];

            for (int i = 0, j = revStr.Length - 1; i < j; i++, j--)
            {
                revStr[i] = arrStr[j];
                revStr[j] = arrStr[i];
            }
            string revString = new string(string.Join(" ", revStr));
            Console.WriteLine(revString);
        }

        static void CountCharsInaString()
        {
            string str = "vidhya devi ashok";
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (c != ' ')
                    if (dict.ContainsKey(c))
                        dict[c]++;
                    else
                        dict.Add(c, 1);
            }

            foreach (KeyValuePair<char, int> kv in dict)
                Console.WriteLine("{0}  -  {1}", kv.Key, kv.Value);

        }

        static void findallsubstring()
        {
            string str = "abcd";
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);
                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + " ");
                }
            }
        }

        static void sumOfDigits()
        {
            int a = 234;
            int sum = 0, t;
            while (a > 0)
            {
                t = a % 10;
                sum += t;
                a /= 10;
            }
            Console.WriteLine(sum);
        }

        static void thirdLargest()
        {
            int[] a = new int[6] { 3, 2, 1, 4, 5, 5 };
            int max1 = 0, max2 = 0, max3 = 0;
            foreach (int i in a)
            {
                if (i > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = i;
                }
                else if (i > max2 && i != max1)
                {
                    max3 = max2;
                    max2 = i;
                }
                else if (i > max3 && i != max1 && i != max2)
                {
                    max3 = i;
                }
            }
            Console.WriteLine(max3);
        }


    }
}
