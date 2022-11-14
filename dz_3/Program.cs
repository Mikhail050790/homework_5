// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76




int[] array = new int[4];
int max =Int32.MinValue;
int min =Int32.MaxValue;
 for (int i = 0; i <array.Length; i++)
 {
    array[i] = new Random().Next(99);

Console.WriteLine(array[i]+", ");
 }
 for (int i = 0; i <array.Length; i++)
 {
    if(array[i]>max)
    {
        max=array[i];
    }
    if (array[i]<min)
    {
        min = array[i];
    }
 }
 Console.WriteLine($"всего {array.Length} чисел. Максимальное = {max}, минимальное = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом = {max - min}");