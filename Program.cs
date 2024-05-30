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
            Console.WriteLine("Введите номер задания: 1, 2, 3, 4");
            string message = Console.ReadLine();
            if (message == "1")
            {
                Console.Write("Привет введи Имя: ");
                string name = Console.ReadLine();
                Console.Write("введи Фамилию: ");
                string lastName = Console.ReadLine();
                Console.Write("введи Отчество: ");
                string patronymic = Console.ReadLine();
                string text = GetFullName(lastName, name, patronymic);

                Console.WriteLine(text);
            }
            else if (message == "2")
            {
                Console.WriteLine("Введите числа через пробел:");
                var nubers = Console.ReadLine()
                 .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(Int32.Parse);

                var SUM = 0;
                foreach (var n in nubers)
                    SUM += n;
                Console.WriteLine(SUM);

            }
            else if (message == "3")
            {
                Console.Write("Привет введи число месяца: ");
                int month = Convert.ToInt32(Console.ReadLine());
                int ses = SeasonsMonth(month);
                SeasonS(ses);
            }
            else if (message == "4")
            {
                Console.Write("Введите число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(FibRec(n));
            }

        }

        static int FibRec(int n)
        {
            if (n == 0 || n == 1) return n;

            else return FibRec(n - 1) + FibRec(n - 2);
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string text = firstName + " " + lastName + " " + patronymic;
            return text;
        }

        static int SeasonsMonth(int numMonth)
        {
            int ret_num = 0;
            Seasons seasons = Seasons.Winter;
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
                    ret_num = -1;
                    break;
            }
            if (ret_num != -1)
            {
                if (seasons == Seasons.Winter)
                {
                    ret_num = 1;
                }
                if (seasons == Seasons.Spring)
                {
                    ret_num = 2;
                }
                if (seasons == Seasons.Summer)
                {
                    ret_num = 3;
                }
                if (seasons == Seasons.Autumn)
                {
                    ret_num = 4;
                }
            }
            return ret_num;
        }

        static void SeasonS(int seasons)
        {

            if (seasons != -1)
            {
                if (seasons == 03)
                {
                    Console.WriteLine($"Лето ");
                }
                if (seasons == 02)
                {
                    Console.WriteLine($"Весна");
                }
                if (seasons == 04)
                {
                    Console.WriteLine($"Осень");
                }
                if (seasons == 01)
                {
                    Console.WriteLine($"Зима");
                }
            }
            else { Console.WriteLine("Ошибка: введите число от 1 до 12"); }
        }


    }
}


