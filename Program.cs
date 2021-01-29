using System;

namespace MethodsWithLoopsandConditionals
{
    class Program
    {
        public static void CountDown()
        {
            int countDown;
            for (countDown = 1000; countDown <= 1000 && countDown >= -1000; countDown--)
                Console.WriteLine(countDown); 
        }
        public static void ByTres()
        {
            int byTres;
            for (byTres = 3; byTres >= 3 && byTres <= 999; byTres += 3)
            {
                Console.WriteLine(byTres);
            }

        }
        public static void IsEqual(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("Yes, they are equal");
            }
            else
            {
                Console.WriteLine("No, they are not equal");
            }

        }
        public static void EvenOrOdd(string x)
        {
            var given = int.Parse(x);
            if (given % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }
        }
        public static void PositiveOrNegative(string x)
        {
            var userNumber = int.Parse(x);
            if (userNumber >= 0)
            {
                Console.WriteLine("The number is Positive");
            }
            else
            {
                Console.WriteLine("The number is Negative");
            }
        }
        public static void CanVote(string x)
        {
            var y = int.Parse(x);
            if (y >= 18)
            {
                Console.WriteLine("Yes! They can vote");
            }
            else
            {
                Console.WriteLine("Nope! This person isnt old enough yet");
            }
        }
        public static void CheckNumber(string x)
        {
            var y = int.Parse(x);
            if (y >= -10 && y <= 10)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        public static void MultiTable(string x)
        {
            var y = int.Parse(x);
                Console.WriteLine(y * 1);
                Console.WriteLine(y * 2);
                Console.WriteLine(y * 3);
                Console.WriteLine(y * 4);
                Console.WriteLine(y * 5);
                Console.WriteLine(y * 6);
                Console.WriteLine(y * 7);
                Console.WriteLine(y * 8);
                Console.WriteLine(y * 9);
                Console.WriteLine(y * 10);
                Console.WriteLine(y * 11);
                Console.WriteLine(y * 12);
                
            
        }






static void Main(string[] args)
        {
            // exercise 1
            CountDown();
            
            // exercise 2
            ByTres();

            //exercise 3
            IsEqual(4, 7);

            // exercise 4
            Console.WriteLine("Input a number");
            EvenOrOdd(Console.ReadLine());
            
            //exercise 5
            Console.WriteLine("Input a number");
            PositiveOrNegative(Console.ReadLine());

            //exercise 6
            Console.WriteLine("How old is the person trying to vote?");
            CanVote(Console.ReadLine());

            //exercise 7
            Console.WriteLine("Input a number");
            CheckNumber(Console.ReadLine());

            //exercise 8
            Console.WriteLine("Input a number");
            MultiTable(Console.ReadLine());


        }
    }
}
