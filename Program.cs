using System;
using System.Security.Principal;

namespace generic_demo
{
    class genericDemo
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to generic demo");
            int [] int_arr1 = {1,2,3};
            int[] int_arr2 = { 1, 3, 2 };
            int[] int_arr3 = {3,2,1};

            Console.WriteLine("max of array1: " + genericDemo.getMaxOfArray(int_arr1, 3));
            Console.WriteLine("max of array2: " + genericDemo.getMaxOfArray(int_arr2, 3));
            Console.WriteLine("max of array3: " + genericDemo.getMaxOfArray(int_arr3, 3));


            float[] float_arr1 = {1.2f, 2.2f, 3.2f };
            float[] float_arr2 = { 1.2f, 3.2f, 2.2f };
            float[] float_arr3 = { 3.2f, 2.2f, 1.2f };

            Console.WriteLine("max of array1: " + genericDemo.getMaxOfArray(float_arr1, 3));
            Console.WriteLine("max of array2: " + genericDemo.getMaxOfArray(float_arr2, 3));
            Console.WriteLine("max of array3: " + genericDemo.getMaxOfArray(float_arr3, 3));

            string[] string_arr1 = { "apple", "peach", "banana" };
            string[] string_arr2 = { "apple", "banana", "peach" };
            string[] string_arr3 = { "banana", "peach", "apple" };

            Console.WriteLine("max of array1: " + genericDemo.getMaxOfArray(string_arr1, 3));
            Console.WriteLine("max of array2: " + genericDemo.getMaxOfArray(string_arr2, 3));
            Console.WriteLine("max of array3: " + genericDemo.getMaxOfArray(string_arr3, 3));

            int[] arr_new_size = { 1, 2, 3, 4, 6 };
            Console.WriteLine("max of array_n_size: " + genericDemo.getMaxOfArray(arr_new_size, 5));



        }

        public static var getMaxOfArray<var>(var []arr, int n_arr)
        {

            var mx = arr[0];

            for(int i = 1; i<n_arr; i++)
            {
                if(Comparer<var>.Default.Compare(arr[i], mx) > 0)
                {
                    mx = arr[i];
                }
            }

            return mx;
        }
        

    }   
}
