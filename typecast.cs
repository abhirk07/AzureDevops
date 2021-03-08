using System;

namespace Conversion
{
    class typecast
    {
        public static void Main2(string[] args)
        {
            byte a = 1;
            int b = a;
            System.Console.WriteLine(b);

            int c=1;
            byte d = (byte)c;
            System.Console.WriteLine(d);

            string e = "12345";
            int f = Convert.ToInt32(e);
            System.Console.WriteLine(f);

            try
            {

            string g = "123456";
            byte h = Convert.ToByte(g);
            System.Console.WriteLine(h);

            }
            catch (Exception)
            {
                 System.Console.WriteLine("Cannot convert");
            }

            string i = "true";
            bool j = Convert.ToBoolean(i);
            System.Console.WriteLine(j);

            int alpha =  123456;
            string bet = alpha.ToString();
            System.Console.WriteLine(bet);

            

            

        }
    }
}
