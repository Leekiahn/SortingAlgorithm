namespace SortingAlgorithm;

public class HeapSort
{
    public static int[] AscendingSort(int[] array)
    {
        int heapSize = array.Length;

        // 힙 구성 : 최대 힙
        for (int i = heapSize / 2 - 1; i >= 0; i--)
        {
            AscendingHeapify(array, heapSize, i);
        }

        // 힙에서 요소 하나씩 추출
        for (int i = heapSize - 1; i > 0; i--)
        {
            // 현재 루트(최대값)와 마지막 요소 교환
            SwapUtil.Swap(ref array[0], ref array[i]);

            // 감소된 힙에서 다시 힙 구성
            AscendingHeapify(array, i, 0);
        }

        return array;
    }

    private static void AscendingHeapify(int[] array, int heapSize, int rootIndex)
    {
        int largest = rootIndex; // 루트를 가장 큰 값으로 가정
        int leftChild = 2 * rootIndex + 1; // 왼쪽 자식 인덱스
        int rightChild = 2 * rootIndex + 2; // 오른쪽 자식
        
        // 왼쪽 자식이 루트보다 크면
        if (leftChild < heapSize && array[leftChild] > array[largest])
        {
            largest = leftChild;
        }
        
        // 오른쪽 자식이 현재 가장 큰 값보다 크면
        if (rightChild < heapSize && array[rightChild] > array[largest])
        {
            largest = rightChild;
        }
        
        // 가장 큰 값이 루트가 아니면 교환
        if (largest != rootIndex)
        {
            SwapUtil.Swap(ref array[rootIndex], ref array[largest]);
            
            // 교환 후 자식 노드에 대해 다시 힙 구성
            AscendingHeapify(array, heapSize, largest);
        }
    }

    public static int[] DescendingSort(int[] array)
    {
        int heapSize = array.Length;

        // 힙 구성 : 최대 힙
        for (int i = heapSize / 2 - 1; i >= 0; i--)
        {
            DescendingHeapify(array, heapSize, i);
        }

        // 힙에서 요소 하나씩 추출
        for (int i = heapSize - 1; i > 0; i--)
        {
            // 현재 루트(최대값)와 마지막 요소 교환
            SwapUtil.Swap(ref array[0], ref array[i]);

            // 감소된 힙에서 다시 힙 구성
            DescendingHeapify(array, i, 0);
        }

        return array;
    }

    private static void DescendingHeapify(int[] array, int heapSize, int rootIndex)
    {
        int largest = rootIndex; // 루트를 가장 큰 값으로 가정
        int leftChild = 2 * rootIndex + 1; // 왼쪽 자식
        int rightChild = 2 * rootIndex + 2; // 오른쪽 자식
        
        // 왼쪽 자식이 루트보다 작으면
        if (leftChild < heapSize && array[leftChild] < array[largest])
        {
            largest = leftChild;
        }
        
        // 오른쪽 자식이 현재 가장 큰 값보다 작으면
        if (rightChild < heapSize && array[rightChild] < array[largest])
        {
            largest = rightChild;
        }
        
        // 가장 큰 값이 루트가 아니면 교환
        if (largest != rootIndex)
        {
            SwapUtil.Swap(ref array[rootIndex], ref array[largest]);
            
            // 교환 후 자식 노드에 대해 다시 힙 구성
            DescendingHeapify(array, heapSize, largest);
        }
    }
}