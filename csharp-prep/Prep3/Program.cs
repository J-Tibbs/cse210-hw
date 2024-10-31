using System;

class Program
{
    static void Main(string[] args)
    {
        char again = 'n';
        do{
        Random rand = new Random();
        int magic_number = rand.Next(1,10);
        int tries = 0;
        int guess_number = 0;

        while(guess_number != magic_number){
            Console.Write("Pick any number, 1-10:\n");
            guess_number = int.Parse(Console.ReadLine());
            tries ++;
            if (guess_number == magic_number){
                Console.WriteLine($"Congrats! You guessed the number in {tries} guesses!");
            }
            else if (guess_number < magic_number){
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("Lower");
            }
        }
        
        Console.Write("Would you like to play again? (y or n)\n");
        again = char.Parse(Console.ReadLine());

        }while(again == 'y');
    }
}