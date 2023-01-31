// Напишите программу, которая выводит массив из N элементов,
// заполненный нулями и единицами в случайном порядке.
// Самое левое число != 0
// Данный массив есть двоичное представление десятичного числа.

int GetNumberByUser(string text)  // Метод введения числа
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size) // Метод создания массива
{
    return new int[size];
}

void FillArray(int[] matr)   //Метод заполнения массива случайными 0 и 1
{
    for (int i = 1; i < matr.Length; i++)
    {
        matr[i] = new Random().Next(0, 2);
    }
    matr[0] = 1;
}

void PrintArray(int[] collection) // Метод печати массива
{
    for (int i = 0; i < collection.Length; i++)
    {
        Console.Write(collection[i]);
    }
    Console.WriteLine();
}

void DecNumber(int[] col) // Метод перевода из двоичной системы в десятичную. 
{
    double result = 0;
    for (int i = 0; i < col.Length; i++)
    {
        result = result + col[i] * Math.Pow(2, (col.Length - i - 1));
    }
    Console.WriteLine($"Десятичное число = {result}");
}


int number = GetNumberByUser("Веедите число N: ");
int[] list = CreateArray(number);
FillArray(list);
PrintArray(list);
DecNumber(list);


