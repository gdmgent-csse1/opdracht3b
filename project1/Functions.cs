using System;

namespace project1
{
    public static class Functions
    {
        // Generate a word.
        public static string GenerateWord(int length, int min, int max)
        {
            string word = "";
            Random rnd = new Random(0);
            for (int i = 0; i < length; i++)
            {
                int number = rnd.Next(min, max);
                word += Convert.ToChar(number);
            }
            return word;
        }
    }
}