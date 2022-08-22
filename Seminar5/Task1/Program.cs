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


// int[] startArray = GetArray(123, 0, 1000);
// WriteLine($"Êîëè÷åñòâî ýëåìåíòîâ â îòðåçêå [10;99] = {GetCountElements(startArray, 10, 99)}");

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// int GetCountElements(int[] array, int leftRange, int rigthRange)
// {
//     int count = 0;
//     foreach (var item in array)
//     {
//         if (item >= leftRange && item <= rigthRange) count++;
//     }
//     return count;
// }