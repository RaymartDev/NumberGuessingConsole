using System;

namespace NumberGuessingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int play = 1;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;

            while(play == 1)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);

                while(guess != number)
                {
                    Console.WriteLine("Pick a number between 1 to 100");
                    guess = Convert.ToInt32(Console.ReadLine());


                    if (guess > number)
                    {
                        if((guess - number) > 5)
                        {
                            Console.WriteLine("Your guess is too high");
                        }
                        else
                        {
                            Console.WriteLine("Your guess is a little high");
                        }
                    }
                    else
                    {
                        if ((number - guess) > 5)
                        {
                            Console.WriteLine("Your guess is too low");
                        }
                        else
                        {
                            Console.WriteLine("Your guess is a little low");
                        }
                        guesses++;
                    }
                }
                Console.WriteLine("Congratulations you got it!!");
                Console.WriteLine("The number is: " + number);
                Console.WriteLine("The number of guesses: " + guesses);
                Console.WriteLine("Type 1 to continue.\nType 2 to end the game.");
                play = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Thank you for playing!!");
        }
    }
}
