using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFirst
{
    class Questions
    {
        public void q1()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Sahil");
        }

        public void q2()
        {
            int a = 3, b = 5;
            Console.WriteLine($"Inital, A : {a} B : {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Final, A : {a} B : {b}");
        }

        public void q3()
        {
            Console.Write("Enter your first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Additon : {a + b}");
            Console.WriteLine($"Subtraction : {a - b}");
            Console.WriteLine($"Multiplication : {a * b}");
            Console.WriteLine($"Division : {a / b}");
        }

        public void q4()
        {
            Console.Write("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; ++i)
            {
                Console.WriteLine($"{a} X {i} = {a*i}");
            }
        }

        public void q5()
        {
            Console.Write("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <4; ++i)
            {
                Console.Write($"{a} ");
            }
            Console.Write("\n");
            for (int i = 0; i < 4; ++i)
            {
                Console.Write(a);
            }
        }

        public void q6()
        {
            Console.Write("Enter anything : ");
            string s = Console.ReadLine();
            char[] newString = new char[s.Length];
            for(int i = 1; i < s.Length - 1; ++i)
            {
                newString[i] = s[i];
            }
            newString[s.Length - 1] = s[0];
            newString[0] = s[s.Length - 1];
            string finalString = new string(newString);
            Console.WriteLine($"Updated String : {finalString}");
        }

        public void q7()
        {
            Console.Write("Enter your first number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            bool aPos = (a>=0);

            bool bPos = (b>=0);

            if ((aPos && !bPos) || (!aPos && bPos))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        public void q8()
        {
            Console.Write("Enter anything sentence: ");
            string s = Console.ReadLine();

            string[] temp = s.Split(' ');
            
            string longest = "";

            for(int i = 0; i < temp.Length; ++i)
            {
                if(temp[i].Length > longest.Length)
                {
                    longest = temp[i];
                }
            }
            Console.WriteLine($"Longest Word : {longest}");
        }

        public void q9()
        {
            Console.Write("Enter any number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (a>0)
            {
                int rem = a % 10;
                sum += rem;
                a = a / 10;
            }

            Console.WriteLine($"Sum of digits : {sum}");
        }

        public void q10()
        {
            int[] arr = new int[3];
            for(int i = 0; i < 3; ++i)
            {
                Console.Write($"Enter the element {i+1} of the array : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = arr[0];
            for(int i = 1; i < 3; ++i)
            {
                arr[i - 1] = arr[i];
            }
            arr[2] = temp;
            Console.Write("\n Final array : ");
            for(int i = 0; i < 3; ++i)
            {
                Console.Write($"{arr[i]},");
            }
            Console.Write("\n");
        }

        public void q11()
        {
            int[] arr1 = new int[3];
            Console.WriteLine("\n\t\tEnter the data for Array - 1");
            for (int i = 0; i < 3; ++i)
            {
                Console.Write($"Enter the element {i + 1} of the array : ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr2 = new int[3];
            Console.WriteLine("\n\t\tEnter the data for Array - 2");
            for (int i = 0; i < 3; ++i)
            {
                Console.Write($"Enter the element {i + 1} of the array : ");
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] arr3 = new int[3];
            Console.WriteLine("\n\t\tEnter the data for Array - 3");
            for (int i = 0; i < 3; ++i)
            {
                Console.Write($"Enter the element {i + 1} of the array : ");
                arr3[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] newArray = new int[3];
            newArray[0] = arr1[1];
            newArray[1] = arr2[1];
            newArray[2] = arr3[1];
            Console.Write("\n Final array : ");
            for (int i = 0; i < 3; ++i)
            {
                Console.Write($"{newArray[i]},");
            }
            Console.Write("\n");
        }

        public void q12()
        {
            Console.Write("Enter a word : ");
            string word = Console.ReadLine();

            char[] temp = word.Reverse().ToArray();
            string newWord = new string(temp);
            if (word == newWord)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }
        }

        public void q13()
        {
            Console.Write("Enter any one character : ");
            Console.WriteLine(Console.Read());
        }

        public void q15()
        {
            Console.Write("Enter a String : ");
            string s = Console.ReadLine();

            StringBuilder strBuild = new StringBuilder();
            
            for(int i = 0; i < s.Length; ++i)
            {
                if((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    strBuild.Append(s[i]);
                }
            }
            Console.WriteLine($"Final string : {strBuild}");
        }
    }
}
