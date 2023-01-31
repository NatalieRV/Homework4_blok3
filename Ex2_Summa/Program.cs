// принимает на вход число и выдаёт сумму цифр в числе.

int GetNumberByUser(string text)   // Метод введения числа
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Rank(int number)  // Метод определения разрядности числа
{
    int size = 1;
    while (number > 10)
    {
        number = number / 10;
        size = size + 1;
    }
    return size;
}

int[] CreateArray(int size) // Метод создания массива
{
    return new int[size];
}

int[] FillArrayByNumber(int[] matr, int number) // Метод для разделения введенного числа на цифры 
{                                               // и заполнение соответсвующего массива
    int val = 0;
    int i = 0;
    while (number != 0)
    {
        val = number % 10;
        matr[i] = val;
        number = number / 10;
        i++;
    }
    return matr;
}

void Summa(int[] arr)  // Метод вычисления суммы цифр
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        result = result + arr[i];
    }
    Console.WriteLine($"Сумма цифр = {result}");
}

int numberUser = GetNumberByUser("Введите число N: ");
int value = Rank(numberUser);
int[] array = CreateArray(value);
FillArrayByNumber(array, numberUser);
Summa(array);
