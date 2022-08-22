// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] numbers = new int[6];

static int[] createArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 10);
    }
    return numbers;
}

static void writeArray(int[] numbers)
{
    foreach(int number in numbers)
    {
        Console.Write(number + " ");
    }
}

writeArray(createArray(numbers));
Console.WriteLine();

int product = 0;
int min = 0;
int max = numbers.Length-1;

while(min < max)
{
    product = numbers[min] * numbers[max];
    min++;
    max--;
    Console.Write(product + " ");
}

// решение работает только для четного числа элементов массива(((