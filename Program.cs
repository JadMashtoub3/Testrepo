using System;

namespace Testrepo
{
    class Program
    {
        static void Main(string[] args)
        {
        Random random = new Random();
        int randomNumber = random.Next(1,25);
        int numberofguesses = 7;
        bool sit = false;
        int guess;
        int guessesLeft = 7;
        
        int [] guesses = new int[7];
        for (int i = 0; i < numberofguesses; i++)
        {
            guesses[i]= Convert.ToInt32(Console.ReadLine());
        }
            for (int i = 0; i < numberofguesses; i++)
        {
            Console.Write(guesses[i] + " ");
        }
               Console.WriteLine("hey there! Lets play a little guessing game. Guess the number between 0 and 25");
                
                while (sit==false)
                {
                    guess= Convert.ToInt32(Console.ReadLine());
                    numberofguesses--;
                    if (guess != randomNumber && numberofguesses == 0)

                    {
                        Console.WriteLine("You Fool, the number was " + randomNumber);
                        sit = true;
                    }
                    else if (guess == randomNumber)
                   {
                    Console.WriteLine("Correct");
                    sit = true;
                    if (sit == false)
                    Console.Write("It took you ");
                    Console.Write(guessesLeft - numberofguesses);
                    Console.Write(" guesses!");
                   }
                   
                    else if (guess > randomNumber)
                    {
                    Console.WriteLine("the number is lower than that");
                    Console.WriteLine("number of guesses left: " + numberofguesses);
                    }
                    else if (guess < randomNumber)
                    {
                    Console.WriteLine("number higher than that");
                    Console.WriteLine("number of guesses left: " + numberofguesses);
                    }
                   
                   
            

               
           
              
                
                   
                   
        } 
        }
    }
}

    
