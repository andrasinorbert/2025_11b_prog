namespace _20260114_agazati
{
    struct PinginAdat
    {
        int napsorszam;
        string pingvin_nev;
        string halnev;
        int haldb;

        public string getHalnev()
        {
            return halnev;
        }

        public string getNev()
        {
            return pingvin_nev;
        }

        public int getHalDb() {
            return haldb;
        }

        public PinginAdat(int nap, string nev, string halnev, int haldb)
        {
            this.napsorszam = nap;
            this.pingvin_nev = nev;
            this.halnev = halnev;
            this.haldb = haldb;
        }

        public override string ToString()
        {
            return $"{this.napsorszam}: {this.pingvin_nev} {this.halnev} {this.haldb}";
        }
    }



    class PingvinAdatLista { 
        List<PinginAdat> lista;

        public PingvinAdatLista(List<PinginAdat> param)
        {
            lista = param;
        }
    }
    internal class Program
    {
        static string filename = "halak.txt";

        static List<PinginAdat> adatokBeolvasasa(string filename)
        {
            string[] sorok = System.IO.File.ReadAllLines(filename, System.Text.Encoding.UTF8);

            List<PinginAdat> lista= new List<PinginAdat>();

            /*
            for(int i = 0; i < sorok.Length; i++)
            {
                Console.WriteLine(sorok[i]);
                string[] egysor = sorok[i].Split(' ');
            */
            foreach (string s in sorok)
            {
                Console.WriteLine(s);
                string[] egysor = s.Split(' ');

                /*
                PinginAdat a = new PinginAdat(
                    Convert.ToInt32(egysor[0]), 
                    egysor[1], 
                    egysor[2], 
                    Convert.ToInt32(egysor[3]));
                lista.Add(a);*/
                lista.Add(
                    new PinginAdat(
                        Convert.ToInt32(egysor[0]),
                        egysor[1],
                        egysor[2],
                        Convert.ToInt32(egysor[3])
                        )
                    );
            }
            

            //foreach(PinginAdat a in lista) Console.WriteLine(a);

            return lista;
        }

        static List<string> fajtak(List<PinginAdat> lista)
        {
            List<string> halak= new List<string>();

            foreach(PinginAdat a in lista)
            {
                if (! halak.Contains(a.getHalnev()))
                {
                    halak.Add(a.getHalnev());
                }
            }

            foreach(string s in halak) Console.WriteLine(s);

            return halak;
        }

        static List<string> nevek(List<PinginAdat> lista)
        {
            List<string> nevek = new List<string>();
            foreach (PinginAdat a in lista)
                if (!nevek.Contains(a.getNev()))
                    nevek.Add(a.getNev());
            return nevek;
        }

        static void stat(List<PinginAdat> lista, string pingvinnev)
        {
            Console.WriteLine($"A keresett pingvin neve: {pingvinnev}");

            int counter = 0;
            int megevettHalakSzama = 0;

            foreach(PinginAdat a in lista)
            {
                if(a.getNev() == pingvinnev)
                {
                    counter++;
                    megevettHalakSzama+=a.getHalDb();
                }
            }
            Console.WriteLine($"Előfordulások száma: {counter}");
            Console.WriteLine($"Megevett halak száma: {megevettHalakSzama}");
        } 
        static void Main(string[] args)
        {
            /*
            List<PinginAdat> etetes = adatokBeolvasasa(filename);
            List<string> f=fajtak(etetes);

            List<string> nevekLista = nevek(etetes); 

            string bekertnev ="";

            do
            {
                if(bekertnev != "")
                    Console.WriteLine("A megadott név nem szerepel az adatbázisban! Próbáld újra...");
                Console.Write("Add meg a pingvin nevét: ");
                bekertnev = Console.ReadLine();
            } while (! nevekLista.Contains(bekertnev));

            // Console.WriteLine($"bekert nev: {bekertnev}");

            stat(etetes, bekertnev);

            Console.WriteLine("Hello, World!");
            */

            PingvinAdatLista lista = new PingvinAdatLista(adatokBeolvasasa(filename));
        }
    }
}
