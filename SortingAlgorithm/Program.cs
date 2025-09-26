namespace SortingAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        
        // BubbleSort
        Console.WriteLine("버블 정렬 오름차순 : " +string.Join(", ", BubbleSort.AscendingSort(array)));
        Console.WriteLine("버블 정렬 내림차순 : " + string.Join(", ", BubbleSort.DescendingSort(array)));
        
        // InsertionSort
        Console.WriteLine("삽입 정렬 오름차순 : " + string.Join(", ", InsertionSort.AscendingSort(array)));
        Console.WriteLine("삽입 정렬 내림차순 : " + string.Join(", ", InsertionSort.DescendingSort(array)));
        
        // SelectionSort
        Console.WriteLine("선택 정렬 오름차순 : " + string.Join(", ", SelectionSort.AscendingSort(array)));
        Console.WriteLine("선택 정렬 내림차순 : " + string.Join(", ", SelectionSort.DescendingSort(array)));
        
        // QuickSort
        Console.WriteLine("퀵 정렬 오름차순 : " + string.Join(", ", QuickSort.AscendingSort(array, 0, array.Length - 1)));
        Console.WriteLine("퀵 정렬 내림차순 : " + string.Join(", ", QuickSort.DescendingSort(array, 0, array.Length - 1)));
        
        
        
        
    }
}