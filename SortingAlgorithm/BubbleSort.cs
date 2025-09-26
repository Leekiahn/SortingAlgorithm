namespace SortingAlgorithm;

// 버블 정렬 알고리즘
public class BubbleSort
{
    public static int[] Sort(int[] array)
    {
        int n = array.Length;

        // 배열 전체 반복
        for (int i = 0; i < n - 1; i++)
        {
            // 정렬된 맨 요소 제외
            for (int j = 0; j < n - i - 1; j++)
            {
                if(array[j] > array[j + 1]) // 인접한 두 요소 비교
                {
                    // 요소 교환
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
}