using System;

namespace Project
{
    class Program
    {
        static void Main()
        {
            // ���������� ����������
            int n, input;
            int max = int.MinValue, secondMax = int.MinValue;
            int localMaxCount = 0, endsWithFiveCount = 0;
            bool allOdd = true;

            // ���� ���������� �����
            Console.WriteLine("������� �������� n: ");
            n = Convert.ToInt32(Console.ReadLine());

            // ���������� ��� �������� ���������� ��������
            int previous = int.MinValue, beforePrevious = int.MinValue;

            // ���� ��� ����� � ��������� �����
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"������� {i + 1} �����: ");
                input = Convert.ToInt32(Console.ReadLine());

                // �������� �� ������� ������� �����
                if (input % 2 == 0)
                {
                    allOdd = false;
                }

                // �������� �����, ��������������� �� 5
                if (Math.Abs(input) % 10 == 5)
                {
                    endsWithFiveCount++;
                }

                // ����������� ������������� � ������� ������������� ��������
                if (input > max)
                {
                    secondMax = max;
                    max = input;
                }
                else if (input > secondMax)
                {
                    secondMax = input;
                }

                // ������� ��������� ����������
                if (i > 1 && beforePrevious <= previous && previous >= input)
                {
                    localMaxCount++;
                }

                // ���������� ���������� ��������
                beforePrevious = previous;
                previous = input;
            }

            // ����� �����������
            Console.WriteLine($"��������� ���������: {localMaxCount}");
            Console.WriteLine($"��� ����� ��������: {allOdd}");
            Console.WriteLine($"������ ������������ ��������: {secondMax}");
            Console.WriteLine($"�����, ��������������� �� 5: {endsWithFiveCount}");
        }
    }
}