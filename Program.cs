namespace AnaliseAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20] { 5, 2, 9, 1, 5, 6, 7, 3, 8, 4, 0, 10, 12, 11, 14, 13, 15, 17, 16, 18 };
            int[] arr2 = new int[20] { 5, 2, 9, 1, 5, 6, 7, 3, 8, 4, 0, 10, 12, 11, 14, 13, 15, 17, 16, 18 };

            OrdenacaoAlgoritmos.BubbleSort(arr);
            OrdenacaoAlgoritmos.inSort(arr2);
        }
    }

    public class OrdenacaoAlgoritmos
    {
        static public void inSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int chave = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > chave)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = chave;
            }
        }

        // Método de ordenação BubbleSort
        static public void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}