using System;
using System.Globalization;
using System.Text;

class program
{
    public static string MergeString(string word1, string word2)
    {
        StringBuilder merged = new StringBuilder();
        int i = 0;
        int j = 0;

        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                merged.Append(word1[i]);
                i++;
            }
            if (j < word2.Length)
            {
                merged.Append(word2[j]);
                j++;


            }
        }

        return merged.ToString();
    }

    static void Main(string[] args)
    {

        Console.WriteLine("Enter Word 1: ");
        string word1 = Console.ReadLine();

        Console.WriteLine("Enter Word 2: ");
        string word2 = Console.ReadLine();

        Console.WriteLine("merged string:" + MergeString(word1, word2));
    }
}