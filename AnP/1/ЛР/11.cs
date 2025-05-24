using System;

public class MyClass
{
    private int _value1;
    private int _value2;

    // ����������� ��� ����������
    public MyClass()
    {
        _value1 = 0;
        _value2 = 0;
    }

    // ����������� � ����� ����������
    public MyClass(int value1)
    {
        _value1 = value1;
        _value2 = 0;
    }

    // ����������� � ����� �����������
    public MyClass(int value1, int value2)
    {
        _value1 = value1;
        _value2 = value2;
    }

    // ����� ��� �������� ���� �����
    public int Sum()
    {
        return _value1 + _value2;
    }

    // ����� ��� �������� ������� � ������� ����
    public int Difference()
    {
        return _value1 - _value2;
    }

    // ����� ��� ������������ ���� �����
    public int Product()
    {
        return _value1 * _value2;
    }

    // ����� ��� ������� ������� ���� �� ������
    public double Division()
    {
        if (_value2 == 0)
        {
            Console.WriteLine("������: ������� �� ���� ����������.");
            return double.NaN; // ���������� "�� �����" ��� ������� �� ����
        }
        return (double)_value1 / _value2;
    }
}

class Program
{
    static void Main()
    {
        // �������� �������� � �������������� ������ �������������
        MyClass obj1 = new MyClass();
        MyClass obj2 = new MyClass(5);
        MyClass obj3 = new MyClass(10, 2);

        // ���������� ������� ��� ������� �������
        Console.WriteLine("������ 1:");
        Console.WriteLine("�����: " + obj1.Sum());
        Console.WriteLine("��������: " + obj1.Difference());
        Console.WriteLine("������������: " + obj1.Product());
        Console.WriteLine("�������: " + obj1.Division());

        // ���������� ������� ��� ������� �������
        Console.WriteLine("\n������ 2:");
        Console.WriteLine("�����: " + obj2.Sum());
        Console.WriteLine("��������: " + obj2.Difference());
        Console.WriteLine("������������: " + obj2.Product());
        Console.WriteLine("�������: " + obj2.Division());

        // ���������� ������� ��� �������� �������
        Console.WriteLine("\n������ 3:");
        Console.WriteLine("�����: " + obj3.Sum());
        Console.WriteLine("��������: " + obj3.Difference());
        Console.WriteLine("������������: " + obj3.Product());
        Console.WriteLine("�������: " + obj3.Division());
    }
}