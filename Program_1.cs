// Известен список рабочих и их месячный заработок. Напечатать список рабочих в порядке убывания зарплаты.
class Program
{
    static void Main()
    {
        // Создаем массив
        (string name, decimal salary)[] workers =
        {
            ("Иван", 50000m),
            ("Алексей", 55000m),
            ("Светлана", 60000m),
            ("Ольга", 45000m),
            ("Михаил", 65000m),
        };

        // Сортируем массив
        for (int i = 1; i < workers.Length; i++)
        {
            var key = workers[i];
            int j = i - 1;

            // Сравниваем зарплату рабочих
            while (j >= 0 && workers[j].salary < key.salary)
            {
                workers[j + 1] = workers[j];
                j = j - 1;
            }
            workers[j + 1] = key;
        }

        // Выводим готовый список
        foreach (var worker in workers)
        {
            Console.WriteLine($"{worker.name} - {worker.salary} рублей");
        }
    }
}