namespace SortingAlgorithm;

public class SelectionSort
{
    public static int[] AscendingSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i; // 현재 위치를 최소값 인덱스로 설정
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex]) // 더 작은 값 발견 시
                {
                    minIndex = j; // 최소값 인덱스 업데이트
                }
            }
            // 최소값과 현재 위치의 값 교환
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
        return array;
    }
    
    public static int[] DescendingSort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int maxIndex = i; // 현재 위치를 최대값 인덱스로 설정
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[maxIndex]) // 더 큰 값 발견 시
                {
                    maxIndex = j; // 최대값 인덱스 업데이트
                }
            }
            // 최대값과 현재 위치의 값 교환
            int temp = array[i];
            array[i] = array[maxIndex];
            array[maxIndex] = temp;
        }
        return array;
    }
}