using System;

namespace CaseSol
{
    class Program
    {
        //SortArray method part
        public static void SortArray(int[] numbers,int a,int b)
        {
            //create new length
            int new_length = a-b;
            //current array is divided into 2 arrays
            int[] first_array = new int[b];
            int[] second_array = new int[a - b];

            //create first array
            for(int i=0;i<b;i++){
                first_array[i] = numbers[i];
            }

            //create second array
            for (int i = b; i < a; i++){
                second_array[i-b] = numbers[i];
            }

            //sort from index b-1 to index 0
            Array.Sort(first_array, b, 0);

            //sort from index a-b-1 to index b
            Array.Sort(second_array, a-b,0);

            //combine two new arrays into one array 
            //locate numbers according to b number
            for (int i = 0; i < a; i++)
            {
                if (i < b){
                    numbers[i] = first_array[i];
                }else{
                    numbers[i] = second_array[new_length - 1];
                    new_length--;
                }
            }

            // print the new combined array
            for (int i = 0; i < a; i++){
                Console.Write(numbers[i] + " ");
            }
            
        }

        //Main part
        public static void Main(string[] args)
        {
            //define "numbers" integer array
            int[] numbers = { 4, 13, 8, 9, 7, 1, 6 };
            
            //show input array
            Console.Write("Input: [");
            foreach (int number in numbers){
                Console.Write(number+" ");
            }
            Console.Write("] \n");
            //define length and first b number
            int a = numbers.Length;
            int b = 3;
            //show output array
            Console.Write("Output: [");
            //sort "numbers" array and print
            SortArray(numbers, a, b);
            Console.Write("]");
        }
    }
}
