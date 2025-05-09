namespace AnaliseAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[6] { 3, 2, 6, 4, 7, 9 }; // Cria um array para ser organizado
            inSort(vetor);

            foreach (int i in vetor)
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
    }
}