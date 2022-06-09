// Author : Andrei C.
// Aveți la dispoziție un șir a[0], a[1],..., a[n-1] de numere naturale.
// Un element a[i] (1 ≤ i < n - 1) îl numim LR dacă a[i] are toate elementele
// din șir aflate la stânga sa mai mici sau egale și toate elementele din dreapta sa mai mari sau egale cu a[i].
// De exemplu, în șirul a = (6, 3, 1, 2, 6, 10, 7, 11, 16) sunt două elemente LR, valorile 6 și 11 de la pozițiile 5 și 8.

namespace OOP_Problema_LR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LR = 0;
            int n = 0;

            int.TryParse(Console.ReadLine(), out n);

            int[] arr = new int[n];

            string[] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(input[i]);
            }

            for (int i = 1; i < n - 1; i++)
            {
                if (Left(arr[i], i, arr) && Right(arr[i], i , arr))
                {
                    LR++;
                    Console.WriteLine(arr[i]);
                }   
            }

            Console.WriteLine($"There are {LR} LR numbers in the array.");

            Console.ReadKey();
        }

        static bool Left(int LR,int k, int[] arr)
        {
            int toggle = 0;

            for (int i = 0; i < k; i++)
            {
                if (LR >= arr[i])
                    toggle++;
            }
            if (toggle == k)
                return true;
            else
                return false;
        }

        static bool Right(int LR, int k, int[] arr)
        {
            int toggle = 0;

            for (int i = k; i < arr.Length; i++)
            {
                if (LR <= arr[i])
                    toggle++;
            }
            if (toggle == arr.Length - k)
                return true;
            else
                return false;
        }

    }
}