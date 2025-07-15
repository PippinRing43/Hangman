namespace Hangman
{
    internal class Program
    {
        static int guesses = 0;
        static Random rand = new Random();
        static string[] words =
        {
            "jesus",//words idk what
            "hhhhhhhhhhhhhhhh"
        };
        static string randomWord;
        static string empty;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            randomWord = words[rand.Next(0, words.Length)];
            empty = "";
            for (int i = 0; i < randomWord.Length; i++)
            {
                empty += '_';
            }
            Console.WriteLine(@"

             _                                             
            | |                                            
            | |__   __ _ _ __   __ _ _ __ ___   __ _ _ __  
            | '_ \ / _` | '_ \ / _` | '_ ` _ \ / _` | '_ \ 
            | | | | (_| | | | | (_| | | | | | | (_| | | | |
            |_| |_|\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|                      
                                __/ |                      
                               |___/                       
                    




            ");

            //Console.WriteLine(HangmanArt.graphics[0]);
            Console.WriteLine("press enter to start...");
            Console.ReadLine();
            Start();
        }

        static void Start()
        {
            Console.Clear();
            Console.WriteLine($"A word has been selected. It has {randomWord.Length} letters");
            Console.WriteLine(empty);
        }
    }
}
