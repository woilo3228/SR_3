// Известен список рабочих и их месячный заработок. Напечатать список рабочих в порядке убывания зарплаты.
class Program
{
    static void Main()
    {
        // Создаем и заполняем массив
        Console.WriteLine("Введите количество рабочих:");
        int workersCount = int.Parse(Console.ReadLine());

        (string name, decimal money)[] workers = new (string, decimal)[workersCount];

        for (int i = 0; i < workersCount; i++)
        {
            Console.WriteLine($"Введите имя рабочего {i + 1}:");
            string name = Console.ReadLine();

            Console.WriteLine($"Введите месячный заработок рабочего {i + 1}:");
            decimal money = decimal.Parse(Console.ReadLine());

            workers[i] = (name, money);
        }

        // Сортируем массив
        for (int i = 1; i < workers.Length; i++)
        {
            var key = workers[i];
            int j = i - 1;

            // Сравниваем зарплату рабочих
            while (j >= 0 && workers[j].money < key.money)
            {
                workers[j + 1] = workers[j];
                j = j - 1;
            }
            workers[j + 1] = key;
        }

        // Выводим готовый список
        Console.WriteLine("Список рабочих в порядке убывания зарплаты:");
        foreach (var worker in workers)
        {
            Console.WriteLine($"{worker.name} - {worker.money} рублей");
        }
    }
}
