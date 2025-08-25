namespace Hangman
{
    internal class Program
    {
        static int guesses = 0;
        static Random rand = new Random();
        static string[] words =
        {
            "abandon",
            "ability",
            "about",
            "above",
            "academic",
            "accept",
            "accompany",
            "administration",
            "agricultural",
            "ally",
            "also",
            "anymore",
            "anyone",
            "apple",
            "average",
            "architect",
            "axe",

            "banana",
            "belief",
            "big",
            "blanket",
            "bone",
            "book",
            "breath",
            "breathe",
            "bullet",

            "capture"
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
            Console.WriteLine($"A word has been selected. It has {randomWord.Length} letters\n");
            Console.WriteLine(empty);

            while (true)
            {
                string userinput;
                do
                {
                    Console.WriteLine("Guess a word or a letter.");
                    userinput = Console.ReadLine().ToLower().Trim();
                } while (userinput.Length > 0);

                if (userinput.Length == 1)
                {
                    if (randomWord.Contains(userinput)) 
                    {
                        
                    }
                }
                else if (userinput.Length > 1)
                {
                    if (userinput == randomWord)
                    {
                        End(true);
                        break;
                    }
                }
            }
        }

        static void End(bool win)
        {
            if (win)
            {
                Console.WriteLine($"Well done! You guessed the word: {randomWord} in {guesses} guesses");
            }
        }
    }
}
