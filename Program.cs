namespace less4
{
    class Program
    {
        enum Seasons
        {
            Winter = 01,
            Spring = 02,
            Summer = 03,
            Autumn = 04
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания: 1, 2");
            string message = Console.ReadLine();
            if ( message  == "1" ) 
            {
                Console.Write("Привет введи Имя: ");
                string name = Console.ReadLine();
                Console.Write("введи Фамилию: ");
                string lastName = Console.ReadLine();
                Console.Write("введи Отчество: ");
                string patronymic = Console.ReadLine();
                string text = GetFullName(lastName,name,patronymic);

                Console.WriteLine(text);
            }
            else if (message == "2")  
            {
                Console.Write("Привет введи число месяца: ");
                int month = Convert.ToInt32(Console.ReadLine());
                SeasonsMonth(month);
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string text = firstName + " " + lastName + " " + patronymic;    
            return text;
        }

       static void SeasonsMonth(int numMonth)
        {
            Seasons seasons = Seasons.Winter;

            int err = 0;
            switch (numMonth)
            {

                case 1:
                    seasons = Seasons.Winter;
                    break;
                case 2:
                    seasons = Seasons.Winter;
                    break;
                case 3:
                    seasons = Seasons.Spring;
                    break;
                case 4:
                    seasons = Seasons.Spring;
                    break;
                case 5:
                    seasons = Seasons.Spring;
                    break;
                case 6:
                    seasons = Seasons.Summer;
                    break;
                case 7:
                    seasons = Seasons.Summer;
                    break;
                case 8:
                    seasons = Seasons.Summer;
                    break;
                case 9:
                    seasons = Seasons.Autumn;
                    break;
                case 10:
                    seasons = Seasons.Autumn;
                    break;
                case 11:
                    seasons = Seasons.Autumn;
                    break;
                case 12:
                    seasons = Seasons.Winter;
                    break;
                default:
                    err = -1;
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                    break;                
            }
            if (err != -1)
            {
                if (seasons == Seasons.Summer)
                {
                    Console.WriteLine($"Лето {numMonth}");
                }
                if (seasons == Seasons.Spring)
                {
                    Console.WriteLine($"Весна {numMonth}");
                }
                if (seasons == Seasons.Autumn)
                {
                    Console.WriteLine($"Осень {numMonth}");
                }
                if (seasons == Seasons.Winter)
                {
                    Console.WriteLine($"Зима {numMonth}");
                }
            }
           
        }


    }
}


