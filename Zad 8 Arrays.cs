using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] sums = new int[nums.Length];



            for (int j = 0; j < nums.Length-1; j++)
            {
                for (int i = 0; i < nums.Length - 1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }
                nums[nums.Length - j-1] = 0;
            }
                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[0]);
                }
            


            
        }
    }
}