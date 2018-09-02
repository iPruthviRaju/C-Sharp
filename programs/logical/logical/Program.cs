using System;

namespace logical
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "123456";
            {
                Console.WriteLine($"Approach1 - Reverse string of {str} is {ReverseSringApproach1(str)}");
                Console.WriteLine($"Approach2 - Reverse string of {str} is {ReverseSringApproach2(str)}");
            }

            string[] arrayString = new string[] { "John", "Jack", "Raymond", "Human" };

            foreach (string aStr in arrayString)
            {
                Console.WriteLine($"Array - {aStr}");
            }

            foreach (string aStr in ReverseArray(arrayString))
            {
                Console.WriteLine($"Array after reverse - {aStr}");
            }
            int a = 20, b = 40;
            Console.WriteLine($"A - {a}, B - {b} before swapping");
            Swap2NumbersApproach1(ref a, ref b);
            Console.WriteLine($"A - {a}, B - {b} after swapping, Approach1");
            Swap2NumbersApproach2(ref a, ref b);
            Console.WriteLine($"A - {a}, B - {b} after swapping, Approach2");

            Console.WriteLine($"Sum of all elements in array - {SumOfAllElements(new int[] { 1, 2, 3 })}");
            Console.Read();
        }

        static string ReverseSringApproach1(string input)
        {
            int length = input.Length;
            char[] reverseChar = new char[length];

            for (int incrementer = 0, decrementer = length - 1; incrementer < length; incrementer++, decrementer--)
            {
                reverseChar[incrementer] = input[decrementer];
            }

            return new string(reverseChar);
        }

        static string ReverseSringApproach2(string input)
        {
            int length = input.Length;

            char[] charInput = input.ToCharArray();
            char[] charReverse = new char[length];

            for (int incrementer = 0, decrementer = length - 1; incrementer < length; incrementer++, decrementer--)
            {
                charReverse[incrementer] = charInput[decrementer];
            }

            return new string(charReverse);
        }

        static string[] ReverseArray(string[] arrayStr)
        {
            int length = arrayStr.Length;
            string[] reverseArrayStr = new string[length];

            for (int incrementer = 0, decrementer = length - 1; incrementer < length; decrementer--, incrementer++)
            {
                reverseArrayStr[decrementer] = arrayStr[incrementer];
            }

            return reverseArrayStr;
        }

        static void Swap2NumbersApproach1(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        static void Swap2NumbersApproach2(ref int a, ref int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
        }

        static int SumOfAllElements(int[] array)
        {
            int result = 0;

            //foreach (int i in array) { result += i; }
            for (int i = 0; i < array.Length; i++) { result += array[i]; }

            return result;
        }
    }
}