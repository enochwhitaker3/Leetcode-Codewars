namespace codewars
{
    public class Leet3
    {
        string s = "pwwkew";
        //answer should be 'wke' and have an answer of 3
        public static void LengthOfLongestSubstring(string s)
        {
            char[] ch = s.ToCharArray();
            int counter = 1;


            for (int i = 0; i < ch.Length; i++)
            {
                foreach(char c in ch) 
                {
                    if (ch[i] == c)
                    {

                    }
                    else
                    {
                        counter++;
                    }

                }
            }
            Console.WriteLine(counter);
        }
    }
}
