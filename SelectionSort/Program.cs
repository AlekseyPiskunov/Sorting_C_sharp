// Сортировка выбором.

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    System.Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Изначальный массив:  [" + string.Join(", ", array) + "]");
for (int i = 0; i < n - 1; i++)
{
    int minPosition = i;
    for (int j = i + 1; j < n; j++)
    {
        if(array[j] < array[minPosition]) minPosition = j;
    }
    int temporary = array[minPosition];
    array[minPosition] = array[i];
    array[i] = temporary;
}
Console.WriteLine("Отсортированный массив:  [" + string.Join(", ", array) + "]");