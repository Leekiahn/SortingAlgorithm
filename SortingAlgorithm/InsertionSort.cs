namespace SortingAlgorithm;

public class InsertionSort
{
    public static int[] AscendingSort(int[] array)
    {
        for(int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;  // key의 바로 앞 요소 인덱스

            // key보다 큰 요소들을 한 칸씩 뒤로 이동
            while(j >= 0 && array[j] > key) // key보다 크면
            {
                array[j + 1] = array[j];    // 요소를 한 칸 뒤로 이동
                j--;    // 다음 요소로 이동
            }
            array[j + 1] = key;
        }
        return array;
    }

    public static int[] DescendingSort(int[] array)
    {
        for(int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;  // key의 바로 앞 요소 인덱스

            // key보다 큰 요소들을 한 칸씩 뒤로 이동
            while(j >= 0 && array[j] < key) // key보다 크면
            {
                array[j + 1] = array[j];    // 요소를 한 칸 뒤로 이동
                j--;    // 다음 요소로 이동
            }
            array[j + 1] = key;
        }

        return array;
    }
}