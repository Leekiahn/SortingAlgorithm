namespace SortingAlgorithm;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 64, 34, 25, 12, 22, 11, 90 };
        
        Console.WriteLine(string.Join(", ", BubbleSort.Sort(array)));
    }
}