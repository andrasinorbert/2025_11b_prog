namespace _20251008
{

    enum Napok { Hetfo, Kedd, Szerda, Csutortok, Pentek, Szombat, Vasarnap }
    internal class Program
    {
        static void Main(string[] args)
        {
            Napok d= Napok.Szerda;
            Console.WriteLine((int)d);

            Napok d2 = Napok.Kedd;
            Console.WriteLine((Napok)((int)d+(int)d2));
            Console.WriteLine( (Napok)5);
            Console.WriteLine((Napok)12);

            //int napszama= int.Parse(Console.ReadLine());
            int napszama;
            do
            {
                Console.WriteLine("Add meg a nap számát!");
            } while ( ! int.TryParse(Console.ReadLine(), out napszama));

            Console.WriteLine(  (Napok) (napszama%7));
        }
    }
}
