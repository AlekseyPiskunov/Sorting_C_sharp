// Сотртировка подсчётом. (CountingSort)  ! Для цифр от [0 до 10) !

// int[] array = {5, 2, 0, 1, 7, 9, 8, 3, 1, 0, 1, 7};

// CountingSort(array);
// Console.WriteLine($"Массив отсортированный:  [{string.Join(", ", array)}]");

// void CountingSort(int[] inputArray)
// {
//     int[] counters = new int[10];

//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         //counters[inputArray[i]]++;
//         int ourNumber = inputArray[i];
//         counters[ourNumber]++;
//     }

//     int index = 0;
//     for (int i = 0; i < counters.Length; i++)
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }
// }


//_______________________________________________________________________________
// Сотртировка подсчётом. (CountingSort)  ! Для чисел от 0 и до более 10 !

// int[] array = {11, 5, 23, 30, 1, 17, 6, 9, 8, 23, 1, 0, 21, 7};

// CountingSort(array);
// Console.WriteLine($"Массив отсортированный:  [{string.Join(", ", array)}]");

// void CountingSort(int[] inputArray)
// {
//     int max = inputArray.Max();

//     int[] counters = new int[max + 1];

//     for (int i = 0; i < inputArray.Length; i++)
//     {
//         counters[inputArray[i]]++;
//     }

//     int index = 0;
//     for (int i = 0; i < counters.Length; i++)
//     {
//         for (int j = 0; j < counters[i]; j++)
//         {
//             inputArray[index] = i;
//             index++;
//         }
//     }
// }


//_______________________________________________________________________________
// Сотртировка подсчётом. (CountingSort)  ! Для любых чисел !

//int[] array = { -11, 5, 23, 30, 1, 17, -6, 9, 8, 0, 23, 1, 0, -21, 7 };
Random random = new Random();
int[] array = new int[15].Select(i => random.Next(-10,10)).ToArray();

CountingSort(array);
Console.WriteLine($"Массив отсортированный:  [{string.Join(", ", array)}]");

void CountingSort(int[] inputArray)
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}