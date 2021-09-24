using System;
using System.Collections.Generic;
using System.Linq;


namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareWithStars();
            //TriangleWithStarsDownToUp();
            //TriangleWithStarsUpToDown();
           // FindMinNum();
           // FindMaxNum();
           // GuessNum();
        } 
      
           public static int FindMaxNum()
            {
                int[] numbers = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    Console.Write((i + 1).ToString() + ". number please ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());

                }
                int max = numbers[0];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (max < numbers[i])
                    {
                        max = numbers[i];
                    }
                }
            Console.WriteLine("max number is {0}", max);
            return max;
            }

            public static int FindMinNum()
        {
            int[] numbers = new int[3];
            for (int j = 0; j < 3; j++)
            {
                Console.Write((j + 1).ToString() + ". number please ");
                numbers[j] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(numbers);
            int min = numbers[0];
            Console.WriteLine("min number is {0}", min);
            return min;
           
        }
        public static int GuessNum()
        {
            Console.Write("tell me the sum of 2 numbers, between 0-6 ");
            int guess = Console.Read();
            Random ran = new Random();
            int a = ran.Next(1, 7);
            int b = ran.Next(7);
            int sum = a + b;
            if (sum == guess)
            {
                Console.Write("Congrats");
            }
            else
            {
                Console.Write("Sorry");
            }
            return sum;
        }
        public static void TriangleWithStarsDownToUp()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void TriangleWithStarsUpToDown()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j>i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public static void SquareWithStars()
        {
            Console.Write("How many stars do you want?");
            int starsno = Convert.ToInt32(Console.ReadLine());
          
            //We create firts upper Edge
            for (int i = 0; i < starsno; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();

            // left Edge
            for (int j = 0; j < starsno-2; j++)
            {
                Console.Write("*");
            // the spaces in the middle
                for (int k = 0; k <starsno-2; k++)
                {
                    Console.Write("  ");
                }
                Console.Write(" *");
                Console.WriteLine();
            }
            // the under  Edge
            for (int l = 0; l <starsno; l++)
            {
                Console.Write("* ");
            }

        }
        


    }
}
