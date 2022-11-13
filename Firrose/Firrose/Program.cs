using System;

namespace Firrose
{

    static class Program
    {
        static char commandsKey;
        static char inputModeCommand;
        static string currentMode = "console";

        public static void ConsoleMode()
        {
            commandsKey = Convert.ToChar(Console.Read());
            inputModeCommand = Convert.ToChar(Console.Read());
            if (commandsKey == ':' && inputModeCommand == ' ')
            {
                currentMode = "console";
            }
        }
        static void InputMode()
        {
            commandsKey = Convert.ToChar(Console.Read());
            inputModeCommand = Convert.ToChar(Console.Read());
            if (commandsKey == ':' && inputModeCommand == 'i')
            {
                currentMode = "input";
            }
        }
        


        static void Main(string[] args)
        {
            Console.WriteLine(currentMode);

            InputMode();
            ConsoleMode();

            while (currentMode == "console")
            {

            }
            
            while (currentMode == "input")
            {

            }

            Console.WriteLine(currentMode);
        }
    }
}
