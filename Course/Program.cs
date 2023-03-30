using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // keep this function call here
        Console.WriteLine(SearchingChallenge(Console.ReadLine()));

    }

    public static string SearchingChallenge(string str)
    {

        const string ChallengeToken = "zdupv70315";

        string[] words = str.Split(" ");

        string wordMostRepeat = "";
        int mostRepeat = 0;

        foreach (string word in words)
        {
            Dictionary<char, int> letterCounts = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (letterCounts.ContainsKey(c))
                {
                    letterCounts[c]++;
                }
                else
                {
                    letterCounts[c] = 1;
                }
            }

            int maxCount = 0;
            foreach (int count in letterCounts.Values)
            {
                if (count > 1 && count > maxCount)
                {
                    maxCount = count;
                }
            }

            if (maxCount > 0 && maxCount > mostRepeat)
            {
                wordMostRepeat = word;
                mostRepeat = maxCount;
            }
        }

        if (mostRepeat == 0)
        {
            return "---1--";
        }
        else
        {
            string output = wordMostRepeat.Replace(ChallengeToken, $"--[{ChallengeToken}]--");
            for (int i = 0; i < ChallengeToken.Length; i++)
            {
                output = output.Replace(ChallengeToken[i], '-');
            }
            return output;
        }
    }
}