/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/
/*
Console.WriteLine("Введите сторону треугольника 1");
int tmp1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону треугольника 2");
int tmp2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите сторону треугольника 3");
int tmp3 = int.Parse(Console.ReadLine());

Console.WriteLine(Find(tmp1, tmp2, tmp3));

string Find(int tmp1, int tmp2, int tmp3)
{
    string str;

    if (tmp1 < tmp2 + tmp3 && tmp2 < tmp1 + tmp3 && tmp3 < tmp1 + tmp2)
    {
        str = "Треугольник существует";
    }
    else
    {
        str = "Треугольник не существует";
    }

    return str;
}
*/


/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
/*
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;
}

Console.WriteLine(Translation(number));

string Translation(int number)
{
    string str = string.Empty;

    while(number != 0)
    {
        str = number%2 + str;
        number /= 2;
    }

    return str;
}
*/


/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/
/*
Console.WriteLine("Введите число");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;
}

int[] array = GenerateArray(number);

PrintArray(array);

int[] GenerateArray(int number)
{
    int[] array = new int[number];

    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            array[i] = 0;
        }
        else if (i == 1)
        {
            array[i] = 1;
        }
        else
        {
            array[i] = array[i-2] + array[i -1];
        }
    }

    return array;
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}
*/



/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

Console.WriteLine("Введите размер массива");
bool isParsed = int.TryParse(Console.ReadLine(), out int number);

if (!isParsed)
{
    Console.WriteLine("Введено не число");
    return;
}

int[] array = GenerateArray(number);
PrintArray(array);

int[] tmparray = array;

int[] copyarray = ArrayCopyTo(array);
PrintArray(copyarray);

Console.WriteLine(array == copyarray);

Console.WriteLine(array == tmparray);

// Вызываем метод создания массива и его заполнение случайными числами
int[] GenerateArray(int number)
{
    int[] array = new int[number]; // создание массива типа int и размером равным переданному параметру

    Random random = new Random(); // создание переменной типа Random

    for (int i = 0; i< number; i++) // цикл от i до length (размер массива)
    {
        array[i] = random.Next(0, 10); // запись в массив случайного числа
    }

    return array; // возврат массива как результат выполнения метода
}

int[] ArrayCopyTo(int[] array)
{
    int[] copyarray = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        copyarray[i] = array[i];
    }
    return copyarray;
}

// метод вывода массива в консоль
void PrintArray(int[] array)
{
    Console.WriteLine($"Массив: [{string.Join(", ", array)}]"); // вывод в консоль
}