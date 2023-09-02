namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many array elements do you want?");
            int elements = Int32.Parse(Console.ReadLine());
            Console.Clear();

            int[] arr = CreateArray(elements);

            int temp;
            int iterations = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        // swap
                        temp = arr[j+1];

                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
                    iterations++;
                }
            }

            int num = 0;
            foreach(int x in arr)
            {
                Console.WriteLine(arr[num]);
                num++;
            }

            Console.WriteLine("Number of iterations:\n" + iterations);
        }

        static int[] CreateArray(int arrayLength)
        {
            Random rnd = new Random();
            int[] arr = new int[arrayLength];
            int num;

            for (int i = 0; i < arrayLength; i++)
            {
                num = rnd.Next(1, 1000);
                arr[i] = num;
            }

            return arr;
        }
    }
}