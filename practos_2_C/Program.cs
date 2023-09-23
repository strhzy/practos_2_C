void ugaday(int otvet)
{
    Random rand = new Random();
    int x = rand.Next(101);
    Console.WriteLine("Компьтер загадал число");
    while (true)
    {
        Console.WriteLine("Введите число");
        otvet = Convert.ToInt32(Console.ReadLine());
        if (x < otvet)
        {
            Console.WriteLine("Нужно меньше");
        }
        if (x > otvet)
        {
            Console.WriteLine("Нужно больше");
        }
        if (x == otvet)
        {
            Console.WriteLine("Вы победили!");
            break;
        }
    }
}
void tablica()
{
    int[,] tablica = new int[9, 9];
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            int G = i + 1;
            int B = j + 1;
            int Q = G * B;
            tablica[i, j] = Q;
        }
    }
    for (int j = 0; j < 9; j++)
    {
        for (int i = 0; i < 9; i++)
        {
            Console.Write(tablica[j, i]);
            Console.Write("\t");
        }
        Console.WriteLine();
    }
}
void delitel(int x)
{
    Console.WriteLine("Введите число");
    x = Convert.ToInt32(Console.ReadLine());
    for (int a = 1; a <= x; a++)
    {
        if (x % a == 0) Console.Write("{0} ", a);

    }
    Console.WriteLine();
}
int x = 0;
int choice;
do
{
    Console.WriteLine("Выберите действие:");
    Console.WriteLine("1.Игра 'Угадай число''");
    Console.WriteLine("2.Таблица умножения");
    Console.WriteLine("3.Вывод делителей числа");
    Console.WriteLine("4.Выход из программы");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            ugaday(x);
            break;
        case 2:
            tablica();
            break;
        case 3:
            delitel(x);
            break;
    }
} while (choice != 4);
