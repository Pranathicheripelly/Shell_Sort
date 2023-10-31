using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shell_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                runApp();
            }

            static void runApp()
            {
                // Create an array of marks to be sorted
                int[] marks = { 75, 89, 42, 56, 67, 91, 33, 12, 80, 95 };
            Console.WriteLine("*******shell sort********");

                Console.WriteLine("order list:");
                PrintArray(marks);

                // Apply Shell Sort
                ShellSort(marks);

                Console.WriteLine("after sorting (Ascending Order):");
                PrintArray(marks);
            }

            static void ShellSort(int[] arr)
            {
                int n = arr.Length;
                int gap = n / 2;

                while (gap > 0)
                {
                    for (int i = gap; i < n; i++)
                    {
                        int temp = arr[i];
                        int j = i;

                        while (j >= gap && arr[j - gap] > temp)
                        {
                            arr[j] = arr[j - gap];
                            j -= gap;
                        }

                        arr[j] = temp;
                    }

                    gap /= 2;
                }
            }

            static void PrintArray(int[] arr)
            {
                foreach (int item in arr)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            Console.ReadLine();
            }
        }

    }
