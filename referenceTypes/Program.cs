using System;

namespace referenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Zad1();
            //Zad2();
            //Zad3();
            //Zad4();
            Zad5();
        }

        public static void Zad1()
        {
            /* Zad 1 - typy referencyne
                / Stwórz program, w którym zadeklarujesz zmienne dotyczące danych pracownika firmy. Dane które chcesz przetrzymywać to:
                / Imię, 
                / Nazwisko, 
                / Wiek, 
                / Płeć(‘m’ albo ‘k’), 
                / PESEL
                / Numer pracownika(np. 2509324094)
            */

            string firstName = "Jan";
            string lastName = "Kowalski";
            uint age = 45;
            char sex = 'm'; // 'm' or 'k'
            ulong pesel = 75100502111;
            ulong employeeNumber = 2509324094;

            Console.WriteLine($"{firstName}, {lastName}, \r\nwiek: {age} lat, \r\npłeć: {sex}, \r\nPESEL: {pesel}, \r\nNumer pracownika: {employeeNumber}");
        }

        public static void Zad2()
        {
            /*
             * Napisz program, w którym stworzysz 3 zmienne z jedną literą, a następnie wypiszesz je w odwrotnej kolejności niż zostały zadeklarowane.
             */

            char firstLetter = 'O';
            char secondLetter = 'C';
            char thirdLetter = 'H';

            Console.WriteLine($"{thirdLetter}, {secondLetter}, {firstLetter}");
        }

        public static void Zad3()
        {
            /*
             * Napisz program, który na podstawie podanej szerokości i długości prostokąta 
             * wyliczy długość przekątnej. (Aby, obliczyć kwadrat liczby użyj metody Math.Pow())
             */

            Console.WriteLine("Obliczanie przekatnej prostokąta");
            double width = 0, lenght = 0;

            Console.Write("Podaj szerokość prostokąta: ");
            string dimension = Console.ReadLine();
            double.TryParse(dimension, out width);


            Console.Write("Podaj długość prostokąta: ");
            dimension = Console.ReadLine();
            double.TryParse(dimension, out lenght);

            double diagonal = Diagonal(width, lenght);
            Console.WriteLine($"Przekątna prostokąta o wymiarach {width}x{lenght} wynosi {diagonal}");

        }

        public static double Diagonal(double width, double lenght)
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(lenght, 2));
        }

        public static void Zad4()
        {
            /*
             * Napisz program w którym stworzysz 2 zmienne liczbowe, oraz jedną tekstową, a następnie przypiszesz im następujące wartości:
             * a)10 b)Szkoła Dotneta c) 12,5
             */

            int a = 10;
            string b = "Szkoła Dotneta";
            float c = 12.5f;
        }

        public static void Zad5()
        {
            /*
             * Napisz program w którym poprosisz użytkownika o jego dane personalne tj. 
             * Imię, nazwisko, numer telefonu, adres email, wzrost, waga (np. 85,7), itp (postaraj się wymyślić jak najwięcej) i spróbuj przekonwertować odpowiedź do odpowiedniego typu danych używając metody: typDanych.Parse(odpowiedźOdUżytkownika).
             */

            Console.WriteLine("Witaj podaj dane nowego użytkownika: ");
            User user = new User();

            Console.Write("\nPodaj imie: ");
            user.FirstName = Console.ReadLine();

            Console.Write("\nPodaj nazwisko: ");
            user.LastName = Console.ReadLine();

            Console.Write("\nPodaj date urodzenia (dd/mm/rrrr): ");
            string result = Console.ReadLine();
            DateTime birthDay;      
            if(DateTime.TryParse(result, out birthDay))
            {
                user.BirthDay = birthDay;
            }
            
            Console.Write("\nPodaj adres zamieszkania: ");
            user.Addres = Console.ReadLine();

            Console.Write("\nPodaj email: ");
            user.Email = Console.ReadLine();

            Console.Write("\nPodaj telefon kontaktowy: ");
            result = Console.ReadLine();
            long phoneNumber;
            if (long.TryParse(result, out phoneNumber))
            {
                user.PhoneNumber = phoneNumber;
            }

            Console.Write("\nPodaj średnie miesięczne zarobki (brutto): ");
            result = Console.ReadLine();
            decimal earnings;
            if (decimal.TryParse(result, out earnings))
            {
                user.MonthlyEarnings = earnings;
            }

            Console.Write("\nPodaj wzrost: ");
            result = Console.ReadLine();
            double height;
            if (double.TryParse(result, out height))
            {
                user.Height = height;
            }

            Console.Write("\nPodaj wagę: ");
            result = Console.ReadLine();
            double weight;
            if (double.TryParse(result, out weight))
            {
                user.Weight = weight;
            }

            Console.WriteLine(user.ToString());
        }
    }
}
