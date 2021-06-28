using System;

namespace test
{
    class Program
    {
        public static void Main(string[] args)
        {     
            Console.WriteLine("**Array Manipulation**:\n"); 
            Console.WriteLine("Enter the Array size and No. of Operation Performed:");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]);
            int b  = int.Parse(input[1]);
            if(a <= 4)
            {
                Console.WriteLine("Error: Array size must be more than 4.");
                return;
            }
            Console.WriteLine("Enter the {0} Array element with white-space seperate:",+a);
            string[] arrstr = Console.ReadLine().Split(' ');
            int[] arr = new int[arrstr.Length];          
            if(arrstr.Length != a)
            {
                Console.WriteLine("Error: Please enter Array element as defined Lenght.");
                return;
            }
            for(int i= 0;i<arrstr.Length;i++)
            {
               arr[i] = int.Parse(arrstr[i]);
            }
            Console.WriteLine("Enter 3 different Indexs at which Array will be divided into Sub-Array");
            string[] index = Console.ReadLine().Split(' ');
            int x = int.Parse(index[0]);
            int y = int.Parse(index[1]);
            int z = int.Parse(index[2]);

            if(x==y || y==z || x==z)
            {
                Console.WriteLine("Error: Index should be Different.");
                return;
            }

            if( x > a || y > a || z > a)
            {
               Console.WriteLine("Error: Index should be less than Size of Defined array.");
               return; 
            }
               
            GenerateSubArray(arr,x,y,z);   
        }

        public static void GenerateSubArray(int[] arry,int idx1,int idx2,int idx3)
        {
            int j = 0;
            int[] temparr1 = new int[idx1+1];
            int[] temparr2 = new int[idx2-idx1];
            int[] temparr3 = new int[idx3-idx2];
            int[] temparr4 = new int[(arry.Length-1)-idx3];
            for(int i=0;i<temparr1.Length;i++)
            {
               temparr1[i] = arry[j];
               Console.WriteLine("1st subarray:" +temparr1[i]);
               j++;
            }
            for(int i=0;i<temparr2.Length;i++)
            {
               temparr2[i] = arry[j];
                Console.WriteLine("2nd subarray:" +temparr2[i]);
               j++;
            }
            for(int i=0;i<temparr3.Length;i++)
            {
               temparr3[i] = arry[j];
                Console.WriteLine("3rd subarray:" +temparr3[i]);
               j++;
            }
            for(int i=0;i<temparr4.Length;i++)
            {
               temparr4[i] = arry[j];
                Console.WriteLine("4th subarray:" +temparr4[i]);
               j++;
            } 

           int[] finalArr1 = swapArray1(temparr1,temparr2);
           int[] finalArr2 = swapArray2(temparr3,temparr4);     

            int[] FinalArray = new int[finalArr1.Length+finalArr2.Length];

            finalArr1.CopyTo(FinalArray,0);
            finalArr2.CopyTo(FinalArray,finalArr1.Length);   

            for(int i = 0;i<FinalArray.Length;i++)
            {
                Console.WriteLine("FinalArray:"+FinalArray[i]);
            } 
        }

        public static int[] swapArray1(int[] Array1, int[] Array2)
        {           
            bool loop1 = false;
            int index = 0;
            int temp = 0;
            int arr1len = Array1.Length;
            int arr2len = Array2.Length;
            int[] z = new int[arr1len+arr2len];
            if(arr1len == arr2len)
            {
               for (int i = 0; i < arr1len; i++)
               {
                    temp  = Array1[i];
                    Array1[i] = Array2[i];
                    Array2[i] = temp;
               }
                Array1.CopyTo(z, 0);
                Array2.CopyTo(z, Array1.Length);
            }
            else
            {
                int[] newArr1 = new int[arr2len];
                int[] newArr2 = new int[arr1len];
                if(arr1len > arr2len)
                    loop1 = true;
                if(loop1)
                {
                    index = arr1len;
                }
                else
                {
                    index = arr2len;  
                }
                for (int i = 0; i < index; i++)
                {
                    if(i<arr1len)
                    {
                    temp  = Array1[i];
                    newArr2[i] = temp;
                    }
                    if(i<arr2len)
                    newArr1[i] = Array2[i];
                }
                newArr1.CopyTo(z, 0);
                newArr2.CopyTo(z, newArr1.Length);
            }        
            return z;
        }

        public static int[] swapArray2(int[] Array3, int[] Array4)
        {
            bool loop2 = false;
            int index = 0;
            int temp = 0;
            int arr3len = Array3.Length;
            int arr4len = Array4.Length;
            int[] z = new int[arr3len+arr4len];
            if(arr3len == arr4len)
            {
               for (int i = 0; i < arr3len; i++)
               {
                    temp  = Array3[i];
                    Array3[i] = Array4[i];
                    Array4[i] = temp;
               }
                Array3.CopyTo(z, 0);
                Array4.CopyTo(z, Array3.Length);
            }
            else
            {
                int[] newArr3 = new int[arr4len];
                int[] newArr4 = new int[arr3len];
                if(arr3len > arr4len)
                    loop2 = true;
                if(loop2)
                {
                    index = arr3len;
                }
                else
                {
                    index = arr4len;  
                }
                for (int i = 0; i < index; i++)
                {
                    if(i<arr3len)
                    {
                     temp  = Array3[i];
                     newArr4[i] = temp;
                    }
                    if(i<arr4len)
                    newArr3[i] = Array4[i];
                }
                newArr3.CopyTo(z, 0);
                newArr4.CopyTo(z, newArr3.Length);
            }           
            return z;
        }
    }
}
