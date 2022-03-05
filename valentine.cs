using System;

namespace blyat
{
    public static class Valentine
    {
        public static void Print(string @from, string to)
        {
            Console.Clear();
            
            Console.WriteLine(
                "\n▄█      ▄  █ ██     ▄▄▄▄▀ ▄███▄       ▀▄    ▄ ████▄   ▄       ██▄   ▄███▄     ▄▄▄▄▄   ▄   \n██     █   █ █ █ ▀▀▀ █    █▀   ▀        █  █  █   █    █      █  █  █▀   ▀   █     ▀▄  █  \n██     ██▀▀█ █▄▄█    █    ██▄▄           ▀█   █   █ █   █     █   █ ██▄▄   ▄  ▀▀▀▀▄ █   █ \n▐█     █   █ █  █   █     █▄   ▄▀        █    ▀████ █   █     █  █  █▄   ▄▀ ▀▄▄▄▄▀  █   █ \n ▐        █     █  ▀      ▀███▀        ▄▀           █▄ ▄█     ███▀  ▀███▀           █▄ ▄█ \n         ▀     █                                     ▀▀▀                             ▀▀▀  \n              ▀                                                                           \n");
            
            Console.WriteLine("I hate you, desu~");
            Console.WriteLine("From: " + @from);
            Console.WriteLine("To: " + to);
        }
    }
}