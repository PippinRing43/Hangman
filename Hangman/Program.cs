namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
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
            Console.WriteLine(HangmanArt.graphics[0]);
            Console.WriteLine("+---+\r\n  |   |\r\n  O   |\r\n /|\\  |\r\n / \\  |\r\n      |\r\n=========");
            Console.WriteLine("press enter to start");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");


        }
    }
}
