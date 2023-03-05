// Программа принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве:
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5,0); B(1,-1,9) -> 11.53

Console.Clear();

int xA = InputNumber("Введите координату Х точки А - ");
int yA = InputNumber("Введите координату Y точки А - ");
int zA = InputNumber("Введите координату Z точки А - ");
int xB = InputNumber("Введите координату Х точки B - ");
int yB = InputNumber("Введите координату Y точки B - ");
int zB = InputNumber("Введите координату Z точки B - ");

DistancePointToPoint(xA, yA, zA, xB, yB, zB);
Console.WriteLine();

//-----------------БЛОК ОПИСАНИЙ----------------------------------------------------------

static int InputNumber(string message)         // Ввод числа и проверка корректности ввода
{
    int num;
    while (true)
        {       
            try
                {
                    Console.Write(message);
                    num = int.Parse(Console.ReadLine() ?? "");
                    return num;
                }
            catch (Exception exc)
                {
                    Console.WriteLine($"Ошибка ввода! {exc.Message}");
                }

        }
}

static void DistancePointToPoint(int xA, int yA, int zA, int xB, int yB, int zB)    // Подсчет и вывод результата
{
    double result = Math.Sqrt((Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2)));
    Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) -> {result}");
}