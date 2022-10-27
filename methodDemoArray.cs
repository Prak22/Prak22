using System;

namespace methodDemoArray
{
    class methodDemoArray
    {
        
        public void printArray(int[] arr)
        {

            Console.WriteLine("Printing array elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


        }
         static void Main(string[] args)
        {

            methodDemoArray obj = new methodDemoArray();
            int[] arr = { 1, 2, 3, 4, 5 };
            obj.printArray(arr);//passing array to function  
            
        }
    }
}
