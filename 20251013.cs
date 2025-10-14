namespace _20251013
{
    internal class Program
    {
        enum Nem { FERFI, NO}
        struct Ember
        {
            public int kor;
            public int szulEv;
            private Nem neme;
            public char[] nev;

            public void setNeme(Nem neme)
            {
                this.neme = neme;
            }

            public void kiir() {
                for (int i = 0; i < nev.Length; i++)
                {
                    Console.Write(nev[i]);
                }
                Console.WriteLine($"({szulEv}): {kor}, {neme}");
            }
            public Ember()
            {
                kor = 5;
                szulEv = 1990;
                neme = Nem.NO;
                nev = new char[] { 'S', 'E', 'N', 'K', 'I' };
            }
            public Ember(int kor, int szulev, char[] nev, Nem neme)
            {
                this.kor = kor;
                this.nev = nev;
                this.szulEv = szulev;
                this.neme = neme;
            }
        }
        static void Main(string[] args)
        {
            Ember e= new Ember();
            e.kor = 20;
            e.kiir();

            Console.WriteLine("Hello, World!");
        }
    }
}
