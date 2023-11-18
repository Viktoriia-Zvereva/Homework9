int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task64()
{
    //Задайте значения M и N. Напишите рекурсивный метод, который выведет 
    //все натуральные числа кратные 3-ём в промежутке от M до N.
    Console.WriteLine("Задача 64");

    int m = 13;
    int n = 20;
    void num(int m, int n)
    {
        if (m > n) return;
        if (m % 3 == 0)
        {
            Console.Write($"{m}, ");
        }
        num(m + 1, n);
    }
    num(m, n);
}

void Task66()
{
    //Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
    Console.WriteLine("Задача 66");

    int m = 4;
    int n = 8;
    int sum(int m, int n)
    {
        if (m == n) return n;
        else return m + sum(m + 1, n);
    }
    Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} {sum(m, n)}");
}

void Task68()
{
    //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    Console.WriteLine("Задача 68");

    int m = 3;
    int n = 2;

    int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    Console.Write($"Функция Аккермана вычислена. {Akkerman(m, n)}.");
}

Console.Clear();
Console.WriteLine("64 - Задача 64\n66 - Задача 66\n68 - Задача 68");
int TaskNumber = Input("Введите номер задачи: ");

switch (TaskNumber)
{
    case 64:
        Task64();
        break;
    case 66:
        Task66();
        break;
    case 68:
        Task68();
        break;
    default:
        Console.WriteLine("Введен неверный номер задачи");
        break;
}