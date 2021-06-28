using System;

namespace AmzingTriplet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**Amazing Triplet**:\n"); 
            Console.WriteLine("Enter the size of Array:");
            string arrsize = Console.ReadLine();
            int n = int.Parse(arrsize);
            if(n > 105)
            {
                Console.WriteLine("Error: Test cases should not be gratet than 105");
                return;
            }
            Console.WriteLine("Enter the elements of Array:");
            string[] arrstr = Console.ReadLine().Split(' ');
            int[] arr = new int[arrstr.Length]; 
            if(arrstr.Length != n)
            {
                Console.WriteLine("Error: Please enter Array element as defined Lenght.");
                return;
            }
            for(int i= 0;i<arrstr.Length;i++)
            {
               arr[i] = int.Parse(arrstr[i]);
            }
            
            Console.WriteLine("Max Of Amazing triplet:" +AmzingTriplet(arr, n));
        }

        static int AmzingTriplet(int[] arr, int n)
        {
            int ans = 0;
            for (int i = 1; i < n - 1; ++i)
            {
                int max1 = 0, max2 = 0;
                for (int j = 0; j < i; ++j)
                    if (arr[j] < arr[i])
                        max1 = Math.Max(max1, arr[j]);

                for (int j = i + 1; j < n; ++j)
                    if (arr[j] > arr[i])
                        max2 = Math.Max(max2, arr[j]);
    
                if(max1 > 0 && max2 > 0)
                {
                    ans = Math.Max(ans, arr[i] + (arr[i-1] * arr[i+1]));
                }                
            }
            if(ans == 0)
            {
                return -1;
            }
    
            return ans;
        }
 
    }
}
