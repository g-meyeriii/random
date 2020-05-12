using System;
using System.Text.RegularExpressions;

namespace RandomT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random dice = new Random();
            //int numEyes;

            //for(int i =0; i < 10; i++)
            //{
            //    numEyes = dice.Next(1, 7);
            //    Console.WriteLine(numEyes);

            //}

            //Random YesNoMaybe = new Random();
            //int answerNum= YesNoMaybe.Next(1,4);

            //Console.WriteLine("Type your question here... and get an answer.");
            //string input = Console.ReadLine();
            //string word = "";
            //if (answerNum == 1)
            //{
            //    word = "Yes";
            //}
            //else if (answerNum == 2)
            //{
            //    word = "No";
            //}else
            //{
            //    word = "Maybe";
            //}


            //Console.WriteLine(word);
            string pattern = @"there";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine("{0} hits found: \n {1}", matchCollection.Count, text );

            foreach(Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            Console.ReadLine();

        }
    }
}
