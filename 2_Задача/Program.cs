/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine(SummNumber(number));

int SummNumber(int number)
{
    int [] array = BuildArrayFromNumers(number);
    int summ = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        summ += array[i]; 
    }
    return summ;
}

int[] BuildArrayFromNumers(int number)
{
    int length = SizeNubmer(number);

    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = number % 10;
        number = number / 10;
    }
    return array;
}

int SizeNubmer(int number)
{
    int i = 0;

    while (number != 0)
    {
        number /= 10;
        i++;
    }

    return i;
}