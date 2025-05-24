using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static string ProcessAction(string[] parts)
    {
        string action = parts[0];
        string ingredients = "";

        // �������� �����������
        for (int i = 1; i < parts.Length; i++)
        {
            if (int.TryParse(parts[i], out int actionNumber))
            {
                // ���� ��� ������ �� ���������� ��������
                ingredients += actions[actionNumber - 1];
            }
            else
            {
                // ���� ��� �������� �����������
                ingredients += parts[i];
            }
        }

        // ��������� ����� � ����������� �� ��������
        switch (action)
        {
            case "MIX":
                return "MX" + ingredients + "XM";
            case "WATER":
                return "WT" + ingredients + "TW";
            case "DUST":
                return "DT" + ingredients + "TD";
            case "FIRE":
                return "FR" + ingredients + "RF";
            default:
                return "";
        }
    }

    static List<string> actions = new List<string>();

    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");

        // ������������ ������ ��������
        foreach (string line in lines)
        {
            string[] parts = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = ProcessAction(parts);
            actions.Add(result);
        }

        // ���������� ��������� �������� ��� ���������
        File.WriteAllText("output.txt", actions[actions.Count - 1]);
    }
}