using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace function_challenges.src
{
    public class ReverseWord
    {
        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(" ");
            string[] reversedWords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                reversedWords[i] = new string(charArray);
            }
            return string.Join(" ", reversedWords);
        }
    }
}