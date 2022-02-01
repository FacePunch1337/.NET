using System;

class CKI
{
    public static void Main()
    {
        
        char input = '\0';
        int spacebar = '\0';
        
        Console.WriteLine("Press the '.' key to quit:: \n");
        do
        {
            input = Console.ReadKey().KeyChar;

            Console.Write(" - ");
      
            if(input == ' ')
            {
                Console.Write("spacebar");
                spacebar ++;
            }

            ;
            Console.WriteLine(Convert.ToString(input).ToUpper());
            

        } while (input != '.');

        Console.WriteLine("spacebar {0} pessed", spacebar);
    }
}