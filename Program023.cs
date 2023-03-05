// Программа принимает на вход число (N) и
// выдает таблицу кубов чисел от 1 до N:
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

int N = InputNumber("Введите число - ");
PrintResult(N);
Console.WriteLine();

//---------------БЛОК ОПИСАНИЙ---------------------

static int InputNumber(string message)   // Ввод числа и проверка корректности ввода
{
    int Num;
    while (true)
    {
        try
            {
                Console.Write(message);
                Num = int.Parse(Console.ReadLine() ?? "");
                return Num;
            }
        catch (Exception exc)
            {
                Console.WriteLine($"Ошибка ввода! {exc.Message}");
            }
    }
}

static void PrintResult(int Number)
{
    Console.Write($"{Number} -> ");
    int i;
    for (i = 1; i < Number; i++)
        {
            Console.Write($"{Math.Pow(i,3)}, ");
        }
    Console.Write($"{Math.Pow(i,3)}");
}
