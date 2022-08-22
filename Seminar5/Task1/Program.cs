//Задайте одномерный массив из 123 случайных чисел
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] numbers = new int[123];

static int[] createArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1, 1000);
    }
    return numbers;
}

createArray(numbers);

int Count = 0;
for (int i = 0; i < numbers.Length; i++)
if (numbers[i] > 10 && numbers[i] < 99)
Count++;

Console.WriteLine("Count of numbers between 10 & 99 is " + Count);

