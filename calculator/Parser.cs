using System;

namespace calculator
{
    public class Parser
    {
        public static bool CheckIfArgIsInteger(string arg)
        {
            return int.TryParse(arg, out int result);
        }

        public static Exception NotEnoughArguments = new Exception("Not enoutgh arguments");
        
        public static void CheckArgsLength(string[] args)
        {
            if (args.Length < 3)
            {
                throw NotEnoughArguments;
            }
        }

        public static Exception SomeArgsAreNotInteger = new Exception("Some of arguments are not an integer.");
        
        public static void CheckIfArgsIsCorrect(string[] args)
        {
            if (CheckIfArgIsInteger(args[0]) == false || CheckIfArgIsInteger(args[2]) == false)
            {
                throw SomeArgsAreNotInteger;
            }
        }
    }
}