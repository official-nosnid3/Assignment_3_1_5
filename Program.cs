namespace Assignment_3_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Assignment 3.1.5
             * Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
             * For e.g: Input : [0,2,1,1,9,1,1]
             * Output: [0,2,0,0,9,1,1]
            */

            Console.WriteLine("Modify an array");
            Console.WriteLine("\nThe first occurence of two consecutive 1s will be changed to 0s");
            Console.WriteLine("\nProvide the 10 integers that will make up the array:");
            
            string stringStoringInts = Console.ReadLine();
            int[] arr = new int[10];

            if (int.TryParse(stringStoringInts, out _) && stringStoringInts.Length == 10)
            {
                for (int i = 0; i < 10; i++)
                    arr[i] = Convert.ToInt32(stringStoringInts[i].ToString());

                    Console.WriteLine($"\nThe array given: ");
                foreach (int num in arr)
                    Console.Write(num + " ");

                ModifyArray(arr);
                
                Console.WriteLine($"\nThe array after it has been modified: ");
                foreach (int num in arr)
                    Console.Write(num + " ");

                Console.WriteLine();
            }
            else throw new ArgumentException("All numbers entered must be integers, and only 10 integers can be entered");
        }
        
        public static void ModifyArray(int[] ints)
        {
            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] == 1 && ints[i + 1] == 1)
                {
                    ints[i] = 0;
                    ints[i + 1] = 0;
                    break;
                }
            }
        }
    }
}
