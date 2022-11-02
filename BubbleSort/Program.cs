// Пузырчатая сортировка.

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    System.Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Изначальный массив:  [" + string.Join(", ", array) + "]");

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temporary = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temporary;
        }
    }
    Console.WriteLine(i +  "[" + string.Join(", ", array) + "]");
}