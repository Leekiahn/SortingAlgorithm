namespace SortingAlgorithm;

public class QuickSort
{
    public static int[] AscendingSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = AscendingPartition(array, left, right);
            AscendingSort(array, left, pivotIndex - 1);  // 피벗 왼쪽 부분 정렬
            AscendingSort(array, pivotIndex + 1, right); // 피벗 오른쪽 부분 정렬
        }

        return array;
    }

    public static int AscendingPartition(int[] array, int left, int right)
    {
        int pivot = array[left]; // 피벗을 배열의 첫 번째 요소로 설정
        int low = left + 1; // 왼쪽 포인터
        int high = right; // 오른쪽 포인터
        
        while (true)
        {
            // 왼쪽 포인터가 피벗보다 큰 값을 찾을 때까지 이동
            while (low <= high && array[low] <= pivot)
            {
                low++;
            }

            // 오른쪽 포인터가 피벗보다 작은 값을 찾을 때까지 이동
            while (low <= high && array[high] >= pivot)
            {
                high--;
            }

            if (low > high) // 포인터가 교차하면 종료
            {
                break;
            }
            
            // 포인터가 가리키는 두 요소 교환
            SwapUtil.Swap(ref array[low], ref array[high]);
        }
        
        // 피벗과 high 포인터가 가리키는 요소 교환
        SwapUtil.Swap(ref array[left], ref array[high]);
        return high; // 피벗의 최종 위치 반환
    }
    
    public static int[] DescendingSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Descendingartition(array, left, right);
            DescendingSort(array, left, pivotIndex - 1);  // 피벗 왼쪽 부분 정렬
            DescendingSort(array, pivotIndex + 1, right); // 피벗 오른쪽 부분 정렬
        }
        
        return array;
    }
    
    public static int Descendingartition(int[] array, int left, int right)
    {
        int pivot = array[left]; // 피벗을 배열의 첫 번째 요소로 설정
        int low = left + 1; // 왼쪽 포인터
        int high = right; // 오른쪽 포인터
        
        while (true)
        {
            // 왼쪽 포인터가 피벗보다 작은 값을 찾을 때까지 이동
            while (low <= high && array[low] >= pivot)
            {
                low++;
            }

            // 오른쪽 포인터가 피벗보다 큰 값을 찾을 때까지 이동
            while (low <= high && array[high] <= pivot)
            {
                high--;
            }

            if (low > high) // 포인터가 교차하면 종료
            {
                break;
            }
            
            // 포인터가 가리키는 두 요소 교환
            SwapUtil.Swap(ref array[low], ref array[high]);
        }
        
        // 피벗과 high 포인터가 가리키는 요소 교환
        SwapUtil.Swap(ref array[left], ref array[high]);
        return high; // 피벗의 최종 위치 반환
    }
}