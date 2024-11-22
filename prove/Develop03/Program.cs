using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        bool userInput = true;
        Reference ref1 = new Reference("John", 3, 16);
        Scripture script1 = new Scripture(ref1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        Scripture script2 = new Scripture(ref2, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Reference myRef;
        Scripture myScript;

        Random rnd = new Random();
        
        if (rnd.Next(1,3) == 1){
            myRef = ref1;
            myScript = script1;
        }
        else{
            myRef = ref2;
            myScript = script2;
        }
        myScript.Display();

        while(userInput){

            Console.Clear();
            if(myScript.IsHidden()){
                userInput = false;
            }
            else
            {
                myScript.Display();
                Console.Write("\n\nPress enter to continue or type 'quit' to finish: ");
                string quitEarly = Console.ReadLine();
                if (quitEarly == "quit"){
                    userInput = false;
                }
                else{
                myScript.HideWord();

                }
            }
        }
    }
}