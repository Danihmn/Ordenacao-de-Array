namespace AnaliseAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6] { 3, 2, 6, 4, 7, 9 }; // Cria um array para ser organizado
            inSort(vetor); // Chama o método de ordenação

            foreach (int i in vetor)
            {
                Console.Write(i + " ");
            }

            int[] vetor2 = new int[] { 3, 2, 6, 4, 7, 9 }; // Cria um segundo array para ser organizado
            BubbleSort(vetor2); // Chama o método de ordenação

            // Array depois de ordenado
            foreach (int i in vetor2)
            {
                Console.Write(i + " ");
            }
        }

        static void inSort(int[] arr)
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
        static void BubbleSort(int[] arr)
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