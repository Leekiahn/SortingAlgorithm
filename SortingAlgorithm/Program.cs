using System.Diagnostics;
namespace SortingAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        // 10,000개의 랜덤 값으로 배열 생성
        int n = 10000;
        Random rand = new Random();
        int[] baseArray = new int[n];
        for (int i = 0; i < n; i++)
            baseArray[i] = rand.Next(0, 100000);

        Stopwatch stopwatch = new Stopwatch();

        // BubbleSort
        int[] array = (int[])baseArray.Clone();
        stopwatch.Restart();
        BubbleSort.AscendingSort(array);
        stopwatch.Stop();
        Console.WriteLine($"버블 정렬 소요 시간: {stopwatch.ElapsedMilliseconds} ms");

        // InsertionSort
        array = (int[])baseArray.Clone();
        stopwatch.Restart();
        InsertionSort.AscendingSort(array);
        stopwatch.Stop();
        Console.WriteLine($"삽입 정렬 소요 시간: {stopwatch.ElapsedMilliseconds} ms");

        // SelectionSort
        array = (int[])baseArray.Clone();
        stopwatch.Restart();
        SelectionSort.AscendingSort(array);
        stopwatch.Stop();
        Console.WriteLine($"선택 정렬 소요 시간: {stopwatch.ElapsedMilliseconds} ms");

        // QuickSort
        array = (int[])baseArray.Clone();
        stopwatch.Restart();
        QuickSort.AscendingSort(array, 0, array.Length - 1);
        stopwatch.Stop();
        Console.WriteLine($"퀵 정렬 소요 시간: {stopwatch.ElapsedMilliseconds} ms");

        // MergeSort
        array = (int[])baseArray.Clone();
        stopwatch.Restart();
        MergeSort.AscendingSort(array, 0, array.Length - 1);
        stopwatch.Stop();
        Console.WriteLine($"병합 정렬 소요 시간: {stopwatch.ElapsedMilliseconds} ms");

        // HeapSort
        array = (int[])baseArray.Clone();
        stopwatch.Restart();
        HeapSort.AscendingSort(array);
        stopwatch.Stop();
        Console.WriteLine($"힙 정렬 소요 시간: {stopwatch.ElapsedMilliseconds} ms");
    }
}