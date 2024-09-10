namespace MergeSort
    {
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 89, 12, 55, 70, 69, 420, 25, 24, 8};


            Console.WriteLine("Prev:");
            PrintArray(array);

            MergeSort(array, array.Length);
            
            Console.WriteLine("After:");
            PrintArray(array);
  
        }

        static void MergeSort(int[] array, int arrayLen)
        {
            if (arrayLen < 2)
            {
                return;
            }
            int arrayMiddle = arrayLen / 2;
            int[] leftArray = new int[arrayMiddle];
            int[] rightArray = new int[arrayLen - arrayMiddle];

            for (int i = 0; i < arrayMiddle; i++)
            {
                leftArray[i] = array[i];
            }
            for (int i = arrayMiddle; i < arrayLen; i++)
            {
                rightArray[i - arrayMiddle] = array[i];
            }

            MergeSort(leftArray, arrayMiddle);
            MergeSort(rightArray, arrayLen - arrayMiddle);

            Merge(array, leftArray, rightArray, arrayMiddle, arrayLen - arrayMiddle);
        }

        static void Merge(int[] array, int[] leftArray, int[] rightArray, int leftLenght, int rightLength)
        {
            int i = 0, j = 0, k = 0;

            while (i < leftLenght && j < rightLength)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    array[k++] = leftArray[i++];
                }
                else
                {
                    array[k++] = rightArray[j++];
                }
            }
            while (i < leftLenght)
            {
                array[k++] = leftArray[i++];
            }
            while (j < rightLength)
            {
                array[k++] = rightArray[j++];
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("Array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("[" + i + "] = " + array[i]);
            }
            Console.WriteLine("------------");
        }
    }
}
