/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.WriteLine("Введите размер массива:");
int sizearray = int.Parse(Console.ReadLine());

int[] array = new int[sizearray];

for (int i = 0; i < sizearray; i++)
{
    Console.WriteLine($"Введите значение для элемента массива {i}:");
    array[i] = int.Parse(Console.ReadLine());
}

PrintArray(array);

void PrintArray (int[] array)
{
    if (array.Length != 0)
    {

        for (int i = 0; i < array.Length; i++)
        {
            if (array.Length == 1)
            {
                Console.Write($"[{array[i]}]");
            }

            else if (i == 0)
            {
                Console.Write($"[{array[i]},");
            }

            else if (i == array.Length -1)
            {
                Console.Write($" {array[i]}]");
            }
            
            else
            {
                Console.Write($" {array[i]},");
            }
        }
    }
}