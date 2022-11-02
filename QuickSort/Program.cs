// Быстрая сотртировка.   (QuickSort) (Рекурсия)

int[] array = { 0, -5, 2, 3, 5, 9, -1, 7 };
int[] res = QuickSort(array, 0, array.Length - 1);
Console.Write("Отсортированный массив: [" + string.Join(", ", res) + "]");

int[] QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return inputArray;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return inputArray;
}

int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}

void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temporary = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temporary;
}