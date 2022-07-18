//1. Bucketsort
//Реализовать Bucketsort, проверить корректность работы.
//2. External sort (доп задание)
//Реализовать External sort, проверить корректность работы.
//Реализовать можно на основе Bucketsort,
//но не обязательно.

Console.WriteLine("Введите размер сортируемого массива");
int NumInts = Convert.ToInt32(Console.ReadLine());

int[] arrayToSort = new int[NumInts];
Random random = new Random();

for (int i = 0; i < arrayToSort.Length; i++)
{
    arrayToSort[i] = (int)random.NextInt64(0, 10000);
}

Console.WriteLine($"Несортированный массив: \n {string.Join(" , ", arrayToSort)}");
var sortedList = BucketSortMethod.BucketSort(arrayToSort, 3);

Console.WriteLine($"Отсортированный массива: \n {string.Join(" , ", sortedList)}");



