using System;

namespace RandomT
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            int numEyes;

            for(int i =0; i < 10; i++)
            {
                numEyes = dice.Next(1, 7);
                Console.WriteLine(numEyes);

            }

            Random YesNoMaybe = new Random();
            int answerNum= YesNoMaybe.Next(1,4);

            Console.WriteLine("Type your question here... and get an answer.");
            string input = Console.ReadLine();
            string word = "";
            if (answerNum == 1)
            {
                word = "Yes";
            }
            else if (answerNum == 2)
            {
                word = "No";
            }else
            {
                word = "Maybe";
            }

            
            Console.WriteLine(word);



            

            Console.ReadLine();

        }
    }
}
