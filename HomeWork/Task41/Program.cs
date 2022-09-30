// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int M = 5;
Console.WriteLine($"Введите {M} чисел");
int[] arr = new int[M];

int[] Massiv (int M)
{
    for (int i = 0; i<M; i++)
    {
    Console.WriteLine($"Введите {i+1} число: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}


int Pos(int[] array)
{
    int result = 0;
    for (int i = 0; i < M; i++)
    {
        if (array[i] > 0) result += 1;
    }
    return result;
}

arr = Massiv(M);
Console.WriteLine($"Количество положительных чисел: {Pos(arr)}");
