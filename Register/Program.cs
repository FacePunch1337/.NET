using System;

class Reg
{
    public static void Main()
    {

        char input = '\0';

        Console.WriteLine("Press the '.' key to quit: \n");
        do
        {
            input = Console.ReadKey().KeyChar;

            Console.Write(" - ");

            if(Convert.ToString(input) == input.ToString().ToUpper())
            {
                Console.WriteLine(Convert.ToString(input).ToLower());

            }

            if (Convert.ToString(input) == input.ToString().ToLower())
            {
                Console.WriteLine(Convert.ToString(input).ToUpper());

            }

        } while (input != '.');

        
    }
}