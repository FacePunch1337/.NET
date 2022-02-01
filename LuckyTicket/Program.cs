using System;


namespace LuckyTicket
{
    class LT
    {

      
        public static void Main()
        {
            string number;
            
            Console.WriteLine("Enter ticket number: ");
            Console.WriteLine("----------------");
            number = Console.ReadLine();




            int first_part = Convert.ToInt32(number) / 1000;
            int second_part = Convert.ToInt32(number) % 1000;

            Console.WriteLine("----------------");
           // Console.WriteLine(first_part);
           // Console.WriteLine(second_part);
           // Console.WriteLine("----------------");
            

            int f_val_fp = first_part /= 100;
           // Console.WriteLine(f_val_fp);
            first_part = Convert.ToInt32(number) / 1000;

            int s_val_fp = first_part /= 10;
            s_val_fp %= 10;
           // Console.WriteLine(s_val_fp);
            first_part = Convert.ToInt32(number) / 1000;


            int t_val_fp = first_part %= 100;
            t_val_fp %= 10;
           // Console.WriteLine(t_val_fp);
            first_part = Convert.ToInt32(number) / 1000;

            int first_part_sum = f_val_fp + s_val_fp + t_val_fp;

           // Console.WriteLine("----------------");

           // Console.WriteLine(first_part_sum);

            //Console.WriteLine("----------------");

            int f_val_sp = second_part /= 100;
           // Console.WriteLine(f_val_sp);
            second_part = Convert.ToInt32(number) % 1000;

            int s_val_sp = second_part /= 10;
            s_val_sp %= 10;
           // Console.WriteLine(s_val_sp);
            second_part = Convert.ToInt32(number) % 1000;

            int t_val_sp = second_part %= 100;
            t_val_sp %= 10;
           // Console.WriteLine(t_val_sp);
            second_part = Convert.ToInt32(number) % 1000;

            int second_part_sum = f_val_sp + s_val_sp + t_val_sp;

            //Console.WriteLine("----------------");

            //Console.WriteLine(second_part_sum);

            //Console.WriteLine("----------------");

            if (first_part_sum == second_part_sum)
                Console.WriteLine(" Lucky Ticket! :) ");
            else
                Console.WriteLine(" Unlucky Ticket... :( ");




        }
    }
}
