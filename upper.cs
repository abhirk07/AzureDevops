using System;

namespace MyNamespace
{
    class upper
    {
        public static void Main17(string[] args)
        {
            string str = "C SHARP";
            string lower =  str.ToLower();
            System.Console.WriteLine(lower);

            string str1 = " hello world";
            string upper = str1.ToUpper();
            System.Console.WriteLine(upper);

            string str2 = "         abhinandan";
            System.Console.WriteLine("Before Trim {0}",str2);
            string trim = str2.Trim();
            System.Console.WriteLine(trim);

            string str3 = "Abhinandan";
            char[] arr = {'A','b'};
            System.Console.WriteLine("Trimming {0}", str3.Trim(arr));

            string str4 = "way down we go";
            System.Console.WriteLine(str4.Length);
            string sub = str4.Substring(3,6);//Substring(startIndex, Length Onwards)
            System.Console.WriteLine(sub);

            string str5 = "  ede dina haa nenne naale ee kaali haale!   ";
            string challenge = str5.Trim();
            System.Console.WriteLine(challenge);
            System.Console.WriteLine(challenge.Length);
            string subStr = challenge.Substring(25, challenge.Trim().Length-26);
            System.Console.WriteLine(subStr);

        }
    }
}