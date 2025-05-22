    using System;

    class Program
    {
        static void FillArray(int[] array)
        {
            Console.WriteLine("������� �������� �������: ");
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write($"������� {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out array[i]))
                        break;
                    Console.WriteLine("����������, ������� ���������� ����� �����.");
                }
            }
        }

        static int FindMax(int[] array)
        {
            int max = array[0];
            foreach (var item in array)
            {
                if (item > max)
                {
                    max = item;
                }
            }
            return max;
        }

        static int FindMin(int[] array)
        {
            int min = array[0];
            foreach (var item in array)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }

        static void Main()
        {
            Console.Write("������� ���������� �����������: ");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("����������, ������� ������������� ����� �����.");
            }

            int[][] jaggedArray = new int[n][];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"������� ������ ������� {i + 1}: ");
                int size;

                while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
                {
                    Console.WriteLine("����������, ������� ������������� ����� �����.");
                }

                jaggedArray[i] = new int[size];
                FillArray(jaggedArray[i]);
            }

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int max = FindMax(jaggedArray[i]);
                int min = FindMin(jaggedArray[i]);
                Console.WriteLine($"������ {i + 1}, ��� (max, min) = ({max}, {min}).");
            }
        }
    }