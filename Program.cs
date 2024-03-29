namespace Arrays_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements to be stored in the array:");
            int n = int.Parse(Console.ReadLine()); // Ask user to input the number of elements

            int[] arr = new int[n]; // Create an integer array of size n

            Console.WriteLine("Enter the values for the array elements:");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine()); // Loop through array and assign values
            }

            int sum = 0;

            foreach (int num in arr)
            {
                sum += num; // Calculate sum of all elements in the array
            }

            Console.WriteLine($"Sum of all elements in the array: {sum}");

            Array.Sort(arr); // Sort the array in ascending order

            Console.WriteLine("Sorted array:");

            foreach (int num in arr)
            {
                Console.Write(num + " "); // Print sorted array
            }
        }
    }
}