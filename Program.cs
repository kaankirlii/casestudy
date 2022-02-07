using System;

namespace CaseSol
{
    class Program
    {
        public static void SortArray(int[] arr_numbers,int a,int b)
        {
            //create new length
            int new_length = a-b;
            //current array is divided into 2 arrays
            int[] first_array = new int[b];
            int[] second_array = new int[a - b];

            //create first array
            for(int i=0;i<b;i++){
                first_array[i] = arr_numbers[i];
            }

            //create second array
            for (int i = b; i < a; i++){
                second_array[i-b] = arr_numbers[i];
            }

            //sort from index b-1 to index 0
            Array.Sort(first_array, b, 0);

            //sort from index a-b-1 to index b
            Array.Sort(second_array, a-b,0);

            //combine two new arrays into one array 
            for (int i = 0; i < a; i++)
            {
                if (i < b){
                    arr_numbers[i] = first_array[i];
                }else{
                    arr_numbers[i] = second_array[new_length - 1];
                    new_length--;
                }
            }

            // print the new combined array
            for (int i = 0; i < a; i++){
                Console.Write(arr_numbers[i] + " ");
            }
            
        }

        public static void Main(string[] args)
        {
            int[] arr_numbers = { 4, 13, 8, 9, 7, 1, 6 };
            //int[] arr_numbers = { 16, 23, 7, 11, 3, 14};
            int a = arr_numbers.Length;
            int b = 3;
            SortArray(arr_numbers, a, b);
        }
    }
}
