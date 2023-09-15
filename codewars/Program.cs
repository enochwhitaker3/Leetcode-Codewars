using codewars;
using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

public static class Kata
{
    //public static string Disemvowel(string str)
    //{
    //    foreach (char c in str)
    //    {
    //        char d = Char.ToLower(c);
    //        if (d == 'a' || d == 'e' || d == 'i' || d == 'o' || d == 'u')
    //        {
    //            str = str.Replace(c.ToString(), "");
    //        }
    //    }
    //    Console.WriteLine(str);
    //    return str;
    //}

    public static bool IsPangram(string str)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string checker = "11111111111111111111111111";
        char[] array = alphabet.ToCharArray();
        foreach (char c in str.ToLower())
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (c == array[i])
                {
                    array[i] = '1';

                }
            }
        }
        string check = new string(array);
        bool factos = string.Equals(checker, check);
        return factos;


    }
    static public void Main(String[] args)
    {
        string s = "pwwkew";
        Leet3.LengthOfLongestSubstring(s);


    }
}
