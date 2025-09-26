namespace SortingAlgorithm;

public class MergeSort
{
    public static int[] AscendingSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;   // 중간 인덱스 계산

            // 왼쪽 절반 정렬
            AscendingSort(array, left, mid);
            // 오른쪽 절반 정렬
            AscendingSort(array, mid + 1, right);
            // 정렬된 두 절반 병합
            AscendingMerge(array, left, mid, right);
        }
        return array;
    }
    
    private static void AscendingMerge(int[] array, int left, int mid, int right)
    {
        int leftSize = mid - left + 1; // 왼쪽 부분 배열 크기
        int rightSize = right - mid;    // 오른쪽 부분 배열 크기

        int[] leftArray = new int[leftSize];    // 추가 배열 (왼쪽 부분)
        int[] rightArray = new int[rightSize];  // 추가 배열 (오른쪽 부분)

        // 왼쪽 부분 배열 복사
        for (int i = 0; i < leftSize; i++)
        {
            leftArray[i] = array[left + i];
        }

        // 오른쪽 부분 배열 복사
        for (int j = 0; j < rightSize; j++)
        {
            rightArray[j] = array[mid + 1 + j];
        }

        int leftIndex = 0, rightIndex = 0;
        int mergedIndex = left;

        // 두 부분 배열을 병합
        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArray[leftIndex] <= rightArray[rightIndex])
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        // 왼쪽 부분 배열에 남은 요소 복사
        while (leftIndex < leftSize)
        {
            array[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // 오른쪽 부분 배열에 남은 요소 복사
        while (rightIndex < rightSize)
        {
            array[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }
    
    public static int[] DescendingSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;   // 중간 인덱스 계산

            // 왼쪽 절반 정렬
            DescendingSort(array, left, mid);
            // 오른쪽 절반 정렬
            DescendingSort(array, mid + 1, right);
            // 정렬된 두 절반 병합
            DescendingMerge(array, left, mid, right);
        }
        return array;
    }
    
    private static void DescendingMerge(int[] array, int left, int mid, int right)
    {
        int leftSize = mid - left + 1; // 왼쪽 부분 배열 크기
        int rightSize = right - mid;    // 오른쪽 부분 배열 크기

        int[] leftArray = new int[leftSize];    // 추가 배열 (왼쪽 부분)
        int[] rightArray = new int[rightSize];  // 추가 배열 (오른쪽 부분)

        // 왼쪽 부분 배열 복사
        for (int i = 0; i < leftSize; i++)
        {
            leftArray[i] = array[left + i];
        }

        // 오른쪽 부분 배열 복사
        for (int j = 0; j < rightSize; j++)
        {
            rightArray[j] = array[mid + 1 + j];
        }

        int leftIndex = 0, rightIndex = 0;
        int mergedIndex = left;

        // 두 부분 배열을 병합
        while (leftIndex < leftSize && rightIndex < rightSize)
        {
            if (leftArray[leftIndex] >= rightArray[rightIndex])
            {
                array[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
            }
            else
            {
                array[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
            }
            mergedIndex++;
        }

        // 왼쪽 부분 배열에 남은 요소 복사
        while (leftIndex < leftSize)
        {
            array[mergedIndex] = leftArray[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // 오른쪽 부분 배열에 남은 요소 복사
        while (rightIndex < rightSize)
        {
            array[mergedIndex] = rightArray[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }
}