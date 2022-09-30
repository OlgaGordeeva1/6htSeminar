// Задача 43: Напишите программу,
// которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//Console.WriteLine("Введите k1")

double[,] coef = new double[2, 2];
double[] crossing = new double[2];

void Input()
{
    for (int i = 0; i < coef.GetLength(0); i++)
    {
        Console.WriteLine($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b): ");
        for (int j = 0; j < coef.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coef[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}


double[] Base(double[,] coef)
{
    crossing[0] = (coef[1, 1] - coef[0, 1]) / (coef[0, 0] - coef[1, 0]);
    crossing[1] = crossing[0] * coef[0, 0] + coef[0, 1];
    return crossing;
}


void Output(double[,] coef)
{
    if (coef[0, 0] == coef[1, 0] && coef[0, 1] == coef[1, 1])
    {
        Console.WriteLine($"Прямые совпадают");
    }
    else if (coef[0, 0] == coef[1, 0] && coef[0, 1] != coef[1, 1])
    {
        Console.WriteLine($"Прямые параллельны");
    }
    else
    {
        Base(coef);
        Console.WriteLine($"Точка пересечения прямых: ({crossing[0]}, {crossing[1]})");
    }
}

Input();
Output(coef);