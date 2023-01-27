using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] array = new string[] { "code", "doce", "ecod", "framer", "frame" };

        List<string> list = new List<string>(array);
        string[] res = NewArray(list);

        Array.Sort(res);
        for (int i = 0; i < res.Length; i++) Console.WriteLine(res[i]);
    }
    public static string[] NewArray(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                bool exam = Exam(list[i], list[j]);

                if (exam == true)
                {
                    list.RemoveAt(j);
                    j--;
                }
            }
        }

        return list.ToArray();
    }

    public static bool Exam(string first, string second)
    {
        List<char> firstWord = first.ToList();
        List<char> secondWord = second.ToList();
        int firstCount = firstWord.Count;
        int secondCount = secondWord.Count;
        int count = 0;

        if (firstCount != secondCount) return false;    

        for (int i = 0; i < firstCount; i++)
        {
            char symbol = firstWord[i];

            if (secondWord.Contains(symbol))
            {
                secondWord.Remove(symbol);
                count++;
            }
        }

        if (firstCount == count && secondCount == count) return true;

        else return false;
    }

}