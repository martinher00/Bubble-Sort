namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2, 94, 43, 7, 1, 25, 42};
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
    }
}