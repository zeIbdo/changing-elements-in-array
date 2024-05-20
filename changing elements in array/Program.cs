using System;

namespace changing_elements_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region min max deyisilme
            //int[] numbers = { 1, 31, 32, 21, 3, 213, 12, 231 };
            //int idx = 0;
            //int maxnumber = numbers[0];
            //int minnumber = numbers[0];
            //while (idx < numbers.Length)
            //{
            //    if (numbers[idx] < minnumber)
            //        minnumber = numbers[idx];
            //    else if (numbers[idx] > maxnumber)
            //        maxnumber = numbers[idx];
            //    idx++;
            //}
            //idx = 0;
            //while (idx < numbers.Length)
            //{
            //    Console.WriteLine(numbers[idx]);
            //    idx++;
            //}
            //idx = 0;
            //while (idx < numbers.Length)
            //{
            //    if (numbers[idx] == minnumber)
            //        numbers[idx] = maxnumber;
            //    else if (numbers[idx] == maxnumber)
            //        numbers[idx] = minnumber;
            //    idx++;
            //}
            //idx = 0;
            //Console.WriteLine("After change");
            //while (idx < numbers.Length)
            //{
            //    Console.WriteLine(numbers[idx]);
            //    idx++;
            //}
            #endregion

            #region daxil edilen ededler deyisilme
            int[] ints = { 1, 2, 3, 4 };
            int idx = 0;
            int num1idx = 0;
            int num2idx = 0;
            bool ent1 = false;
            bool ent2 = false;
            while (idx < ints.Length)
            {
                Console.WriteLine(ints[idx]);
                idx++;
            }
            idx = 0;
            Console.WriteLine("verilen arraydeki deyismek istediyiniz 2 elementi sirayla daxil edin: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            while (idx < ints.Length)
            {
                if (ints[idx] == number1)
                {
                    num1idx = idx;
                    ent1 = true;
                    break;
                }
                idx++;
            }
            idx = 0;
            while (idx < ints.Length)
            {
                if (ints[idx] == number2)
                {
                    num2idx = idx;
                    ent2 = true;
                    break;
                }
                idx++;
            }
            idx = 0;
            if (ent1 == true && ent2 == true) { Console.WriteLine("2 ededde arrayde var"); }
            else { Console.WriteLine("ededlerden biri ve ya ikisi yoxdur"); }
            if (ent1 != false && ent2 != false)
            {
                ints[num1idx] = number2;
                ints[num2idx] = number1;
            }                   
            Console.WriteLine("array after change:");
            while (idx < ints.Length)
            {
                Console.WriteLine(ints[idx]);
                idx++;
            }
            #endregion


        }
    }
}
