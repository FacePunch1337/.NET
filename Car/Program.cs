using System;
using System.Collections.Generic;
using System.Text;


namespace Car
{
    class CAR : Garage
    {
        private static string model = "Car";
        private static string country_manufacturer = "Country";
        private static int year_of_issue = 2022;
        private static double mileage = 000.000;
        private static bool used = false;

        public CAR()
        {
            
        }

        public CAR(int _size)
        {
            size = _size;
        }
        public string Model { get { return model; } set { model = model; } }
        public string Country_Manufacturer { get { return country_manufacturer; } set { country_manufacturer = country_manufacturer; } }
        public int Year_Of_Issue { get { return year_of_issue; } set { year_of_issue = year_of_issue; } }
        public double Mileage { get { return mileage; } set { mileage = mileage; } }
        public bool Used { get { return used; } set { used = used; } }

        public void AddCarInfo()
        {

            Console.Write("Модель: ");
            model = Console.ReadLine();
            Console.Write("Страна-производитель: ");
            country_manufacturer = Console.ReadLine();
            Console.Write("Год выпуска: ");
            year_of_issue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Пробег: ");
            mileage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Состояние:\n[0]Новая \n[1]б/у \n Ввод: ");

            int _used = Convert.ToInt32(Console.ReadLine());
            if (_used == 1)
            {
                used = true;


            }
            else used = false;
        }
        public void ShowCarInfo()
        {
            Console.Write("Модель: ");
            Console.WriteLine(model);
            Console.Write("Страна-производитель: ");
            Console.WriteLine(country_manufacturer);
            Console.Write("Год выпуска: ");
            Console.WriteLine(year_of_issue);
            Console.Write("Пробег: ");
            Console.WriteLine(mileage);
            Console.Write("Состояние: ");
            if (used == true)
                Console.Write("б/у\n");
            else
                Console.Write("Новая\n");
        }

        public void AddToGarage(ref CAR car)
        {
            for (int i = 0; i < size; i++)
            {
                cars[i] = new CAR();
            }
        }






    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var car = new CAR();
            int choice;
            while (true)
            {
                Console.WriteLine("__________________________");
                Console.WriteLine("1] Создать новую машину");
                Console.WriteLine("2] Добавить в гараж");
                Console.WriteLine("3] Посмотреть информацию");
                Console.Write("\nГараж: ");

                foreach (var item in Garage.cars)
                {
                    Console.WriteLine('\n');
                    Console.WriteLine(item);
                }
                Console.Write("\nВыбор: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n__________________________");

                switch (choice)
                {
                    case 1: car.AddCarInfo(); break;
                    case 2: car.AddToGarage(ref car); break;
                    case 3: car.ShowCarInfo(); break;
                }
            }


        }
    }
}
