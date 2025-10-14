namespace _20251006
{
    internal class Program
    {
        static int osszead(int a, int b)
        {
            return a + b;
        }


        static int osszegzes(int[] egeszek)
        {
            int s = 0;
            for (int i = 0; i < egeszek.Length; i++)
            {
                s += egeszek[i];
            }
            return s;
        }


        static int Main(string[] args)
        {
            int x = 1;
            switch (x)
            {
                case <0: Console.WriteLine(""); break;
                case 2: Console.WriteLine("B"); break;
                default: Console.WriteLine("C"); break;
            }

            string s = "alma";
            switch (s)
            {
                case "alma": Console.WriteLine(""); break;
                case "béla": Console.WriteLine("B"); break;
                default: Console.WriteLine("C"); break;
            }


            x = 1;
            int z = 3;
            int g = osszead(x, z);
            Console.WriteLine(g);
            Console.WriteLine(osszead(4,5));


            kiir("Szia");

            int[] t = { 1, 2, 3, };
            Console.WriteLine(osszegzes(t));

            return -1;
        }

        static void kiir(string s)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(s);
            Console.WriteLine("----------------------");
        }
    }
}
