using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    internal class HangmanArt
    {
        public static string[] graphics =
        {
            @"
                +---+ 
                | | 
                | 
                | 
                | 
                | 
                =========
            ",
            @"
                +---+ 
                | | 
                O |
                | 
                | 
                | 
                =========
            ",
            @"
                +---+ 
                | | 
                O | 
                | | 
                | 
                |
                =========
            ",
            @"
                +---+ 
                | | 
                O | 
                /| | 
                | 
                | 
                =========
            ",
            @"
            +---+ 
            | | 
            O | 
            /|\ | 
            | 
            | 
            =========
            "
        };
    }
}
