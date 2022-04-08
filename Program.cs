using System;
using System.Collections.Specialized;
using System.Threading;
using System.Threading.Tasks;

namespace Magic8Ball
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Magic 8 Ball welcomes you... I see you have come to seek some answers");
            Magic8Ball();
        }

        private static void AskQuestion()
        {
            Console.Write("Speak now. The Magic 8 Ball permits it --> ");
            Console.ReadLine();
            Console.WriteLine("Interesting, interesting... the Magic 8 Ball is thinking...");
            Console.WriteLine("Let's see...");
            Thread.Sleep(800);
            Console.WriteLine(GetAnswer());
            
            Magic8Ball();
        }

        private static void Magic8Ball()
        { 
            Console.Write("\nWould you like to ask a question? --> ");
            string keepGoing = Console.ReadLine();
            if (keepGoing.ToLower().Equals("yes"))
            {
                AskQuestion();
            } else if (keepGoing.ToLower().Equals("no"))
            {
                Console.WriteLine("Then the Magic 8 Ball bids you farewell! Come again...");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Answer the question with yes or no, you fool. The Magic 8 Ball grows impatient...");
                Magic8Ball();
            }
        }

        private static string GetAnswer()
        {
            string[] possibleResponses =
            {
                "It is certain.", "It is decidedly so.", "Without a doubt.",
                "Yes definitely.", "You may rely on it.", "As I see it, yes",
                "Most likely", "Outlook good.", "Yes.", "Signs point to yes.",
                "Reply hazy, try again.", "Ask again later.", "Better not tell you now",
                "Cannot predict now.", "Concentrate and ask again.", "Don't count on it.",
                "My reply is no.", "My sources say no.", "Outlook not so good.", "Very doubtful."
            };

            Random rand = new Random();
            return possibleResponses[rand.Next(0, possibleResponses.Length)];
        }
    }
}