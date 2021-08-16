using System;

namespace DevBuild_Lab_PrimeNumbers
{
    public class PrimeNum
    {
        public static int GetPrime(int nthPrime)
        {
            // Exclude primes 2 and 3 from calculation
            if (nthPrime == 1)
            {
                return 2;
            }
            else if (nthPrime == 2)
            {
                return 3;
            }

            else
            {
                int result = 0;
                int counter = 2; //2 and 3 have already been checked
                //start at 3, skip even numbers
                for (int i = 3; counter < nthPrime; i+=2) //the counter will become equal to nthPrime down below,
                                                          //so we want to stop then, and not run again at <= 
                {          
                    int primecheck = 0;
                        for (int j = 1; j < i/2; j++) // stop checking factors at the halfway point
                                                      
                        {
                            if (i%j == 0)
                            {
                                primecheck++; //count how many numbers factor in evenly
                            }
                        }
                        if (primecheck == 1) //if 1 was the only factor to increase our countup to the mid point,
                                             //we count it and set the new result to i.
                        {
                            counter++;
                            result = i;
                        }
                }
                return result;
            }
        }
    }
    


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's locate some primes!");
            bool goAgain = true;
            while (goAgain)
            {
                Console.Write("\nWhich prime are you looking for? (3rd, 10th, 21st, etc...: ");
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine($"The prime in the {DisplayWithSuffix(userInput)} spot is {PrimeNum.GetPrime(userInput)}");

                Console.Write("Find another? (y): ");

                if (Console.ReadLine() != "y")
                {
                    goAgain = false;
                }
            }
        }



        public static string DisplayWithSuffix(int num)     //Was curious if there was a way to format numbers, as in rankings.
                                                            //Pulled this off the web just for my own satisfaction.
        {
            string number = num.ToString();
            if (number.EndsWith("11")) return number + "th";
            if (number.EndsWith("12")) return number + "th";
            if (number.EndsWith("13")) return number + "th";
            if (number.EndsWith("1")) return number + "st";
            if (number.EndsWith("2")) return number + "nd";
            if (number.EndsWith("3")) return number + "rd";
            return number + "th";
        }

    }
}
