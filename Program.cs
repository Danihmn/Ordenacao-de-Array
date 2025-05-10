namespace AnaliseAlgoritmos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 9, 1, 5, 6, 7, 3, 8, 4, 0, 10, 12, 11, 14, 13, 15, 17, 16, 18 };

            // Exibir o array original
            Console.WriteLine("Array original:");
            Exibir(arr);

            Console.WriteLine("Array ordenado com Insertion Sort:");
            Algoritmos.inSort(arr);
            Exibir(arr);

            int[] arr2 = { 5, 2, 9, 1, 5, 6, 7, 3, 8, 4, 0, 10, 12, 11, 14, 13, 15, 17, 16, 18 };

            // Exibir o array original
            Console.WriteLine("Array original:");
            Exibir(arr2);

            Console.WriteLine("\n\nArray ordenado com Bubble Sort:");
            Algoritmos.BubbleSort(arr2);
            Exibir(arr2);

            Console.WriteLine("\n---------------------------------------\n");

            // Busca sequencial e binária
            Algoritmos.BuscaSequencial(arr, 5);

            // Busca binária
            int resultado = Algoritmos.BuscaBinaria(arr, 5);

            if (resultado != -1)
            {
                Console.WriteLine("Valor encontrado na posição: " + resultado);
            }
            else
            {
                Console.WriteLine("Valor não encontrado");
            }

            static void Exibir(int[] arr)
            {
                // Exibir os arrays ordenados
                foreach (int i in arr)
                {
                    Console.Write(i + " ");
                }
            }
        }

        public class Algoritmos
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

            static public void BuscaSequencial(int[] arr, int valor)
            {
                try
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == valor)
                        {
                            Console.WriteLine("Valor encontrado na posição: " + i);
                            return;
                        }
                        Console.WriteLine("Valor não encontrado");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
            }

            static public int BuscaBinaria(int[] lista, int valor)
            {
                int inicio = 0;
                int fim = lista.Length - 1;

                while (inicio <= fim)
                {
                    int meio = inicio + (fim - inicio) / 2;

                    if (lista[meio] == valor) // Se o meio da lista for igual ao valor procurado
                    {
                        return meio; // No loop, quando o valor for encontrado, retornará a sua posição
                    }
                    else if (lista[meio] < valor) // Se o meio for menor que o valor procurado
                    {
                        inicio = meio + 1; // Foca a procura na metade direita
                    }
                    else // Se o meio for maior que o valor procurado
                    {
                        fim = meio - 1; // Foca a procura na metade esquerda
                    }
                }
                return -1; // Valor não encontrado
            }
        }
    }
}