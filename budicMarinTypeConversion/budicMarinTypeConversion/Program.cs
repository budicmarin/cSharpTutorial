using System;

namespace budicMarinTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b;
            Console.WriteLine(i);
            int j= 1000;
            byte by = (byte)j;
            Console.WriteLine(by);
            try
            {
                string str = "true";
                bool bo = Convert.ToBoolean(str);
                Console.WriteLine(bo);
            }
            catch(Exception)
            {
                Console.WriteLine("The number canot be convertet to byte");
            }
        }
    }
}
