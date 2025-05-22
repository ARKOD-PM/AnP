using System;

class Program
{
    static void Main()
    {
        int even = 0;
        bool odd = true;
        while (true)
        {
            Console.Write("������� �����: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= 0)
            {
                break;
            }
            while (input > 0)
            {
                int num = input % 10;
                if (num % 2 == 0)
                {
                    odd = false;
                    even = even * 10 + num;
                }
                input /= 10;
            }
        }
        if (odd)
        {
            Console.WriteLine("� ����� ���������� ������ �����.");
        }
        else
        {
            Console.WriteLine($"�����: {even}");
        }
    }
}