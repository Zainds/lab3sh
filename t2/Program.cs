using System;

namespace t2
{
    internal class Program
    {
        public static void fillArr(int[] arr, int n){
            Random rnd = new Random();
            for (int i = 0; i < n; i ++){
                arr[i] = rnd.Next(-30, 30+1);
            }
        }
        public static void printArr(int[] arr, int n){
            for (int i = 0; i < n; i ++){
                Console.WriteLine(i+1 + " элемент массива:  " + arr[i] );
            }
        }
        public static void checkArr(int[] arr, int n){
            int min_ind = 0;
            double sr = 0; int k = 0;
            for (int i = 0; i < n; i ++){
                if (arr[i] < arr[min_ind]){
                    min_ind = i;
                }
            }
            for (int i = 0; i< min_ind; i++){
                sr += arr[i];
                k++;
            }
            Console.WriteLine("Ответ:  " + sr/k);
        }
        public static void Main(string[] args)
        {
            int n = 6;
            int[] arr = new int[n];
            fillArr(arr, n);
            printArr(arr, n);
            checkArr(arr, n);
        }
    }
}