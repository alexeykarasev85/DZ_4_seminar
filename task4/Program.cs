// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Первый вариант, рандомной кол-во элементов массива
// int[] arr = new int[8];
// Random rnd = new Random();
// for (int i = 0; i < arr.Length; i++)
// {
// arr[i] = rnd.Next(0,100);
// // System.Console.Write($"{arr[i]} ");
// }
// System.Console.WriteLine($"[{string.Join("; ", arr)}]");


// Второй вариант, когда пользователь сам вводит кол-во элементов массива
Console.Write("Введите количество элементов массива Х: ");
int number = Convert.ToInt32(Console.ReadLine());
int Length = number;
int[] arr = new int[Length];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0,100);
// System.Console.Write($"{arr[i]} ");
}
System.Console.WriteLine($"[{string.Join("; ", arr)}]");

