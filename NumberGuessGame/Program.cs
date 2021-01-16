using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int tries = 0;
            int score = 0;
            Console.WriteLine("Hello! Do you want to play number guessing? (Answer with Yes or No)");
            Console.WriteLine();
            string response = Console.ReadLine();
            Console.WriteLine();
            while (response != "Yes")
            {
                if (response == "No")
                {
                    Console.WriteLine("I'll wait here for you!");
                    System.Threading.Thread.Sleep(2000);
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("I didn't understand what you said. Please write carefully!");
                    Console.WriteLine();
                    response = Console.ReadLine();
                    Console.WriteLine();
                }
            }

            int range = 3;

            //Choosing level  
            Console.WriteLine("Difficulty levels:");
            Console.WriteLine("1- Easy (from 1 to 3)");
            Console.WriteLine("2- Normal (from 1 to 10)");
            Console.WriteLine("3- Hard (from 1 to 1000)");
            Console.WriteLine("4- Impossible (fron 1 to 2147483646)");
            Console.WriteLine("5- Custom (from 1 to x)");
            Console.WriteLine();

            Console.Write("Enter the number of difficulty level : ");
            string difficultyStr = Console.ReadLine();

            Console.WriteLine();

            int difficulty;

            Int32.TryParse(difficultyStr, out difficulty);

            while (difficulty < 1 || 5 < difficulty)
            {
                Console.Write("Enter the number of difficulty level : ");
                difficultyStr = Console.ReadLine();

                Int32.TryParse(difficultyStr, out difficulty);
            }
            switch (difficulty)
            {
                case 1:
                    Console.WriteLine("Difficulty: Easy");
                    break;
                case 2:
                    Console.WriteLine("Difficulty: Normal");
                    range = 10;
                    break;
                case 3:
                    Console.WriteLine("Difficulty: Hard");
                    range = 1000;
                    break;
                case 4:
                    Console.WriteLine("Difficulty: Near-Impossible");
                    range = 2147483646;
                    break;
                case 5:
                    Console.WriteLine("Difficulty: Custom");
                    Console.WriteLine();
                    Console.Write("Define x :");
                    string rangeStr = Console.ReadLine();
                    Int32.TryParse(rangeStr, out range);

                    while (range < 2)
                    {
                        Console.Write("Define x :");
                        rangeStr = Console.ReadLine();
                        Int32.TryParse(rangeStr, out range);
                    }
                    break;

                default:
                    Console.WriteLine("Difficulty: Chosen Easy from default");
                    break;
            }
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);

            while (response == "Yes")
            {
                //Computer picks a number from range

                Random random = new Random();

                int computerPick = random.Next(range + 1);

                if (computerPick == 0)
                {
                    computerPick = 1;
                }

                Console.WriteLine("Okay! I picked a number from 1 to " + range + ". Guess it!");

                Console.WriteLine();
                System.Threading.Thread.Sleep(500);

                //User inputs a number

                int guess = 0;
                while (guess <= 0 || guess > range)
                {
                    Console.Write("What's your guess ? ");

                    string guessStr = Console.ReadLine();

                    Int32.TryParse(guessStr, out guess);
                    tries++;
                }

                while (computerPick != guess)
                {
                    if (guess < computerPick)
                    {
                        Console.WriteLine("Guess Higher!");
                        tries++;
                    }
                    else
                    {
                        Console.WriteLine("Guess Lower!");
                        tries++;
                    }

                    string guessStr = Console.ReadLine();
                    Int32.TryParse(guessStr, out guess);
                }

                score++;
                Console.WriteLine("Right! You guessed " + tries + " times in total. You have won " + score + " times.");
                Console.WriteLine("Do you want to play again ? (Answer with Yes or No)");


                response = Console.ReadLine();
                Console.WriteLine();
                while (response != "Yes" && response != "No")
                {
                    Console.WriteLine("I didn't understand what you said. Please write carefully!");
                    response = Console.ReadLine();
                }
                if (response == "No")
                {
                    Console.WriteLine("Made by MyavKat");
                    Console.WriteLine("Press any key to exit!");
                    Console.ReadKey(true);
                }

            }

        }

    }

}
