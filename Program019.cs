// Программа принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом:
// 14212 -> нет
// 23432 -> да
// 12821 -> нет


Console.Clear();

int number = InputNumber("Введите пятизначное число: ");
PrintResult(number, PalNum(number));
Console.WriteLine();

//---------- БЛОК ОПИСАНИЙ-------------------------------

static int InputNumber(string message) // Ввод и проверка корректности ввода
{
    int num = 0;
    while (true)
    {
        try
            {
                Console.Write(message);
                num = int.Parse(Console.ReadLine() ?? "");
            }
        catch (Exception exc)
            {
                Console.WriteLine($"Ошибка ввода! {exc.Message}");
            }
        if ((num > 9999) && (num < 100000))
            {
                return num;
            }
        else
            Console.Write("Введено неправильное число. ");
            
    }           
}

static int PalNum(int num)             // Метод возвращает палиндром введенного числа
{
    int rev_num = 0;
    while (num >= 1)
        {
            rev_num = (rev_num * 10) + (num % 10);
            num = num / 10;
        }
    return rev_num;
}

static void PrintResult(int num, int pal_num)  // Вывод результата
{
    if (num == pal_num)
        Console.WriteLine($"{num} -> да");
    else    
        Console.WriteLine($"{num} -> нет");
}   
            
