using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TombokIsmetles
{
    class Program
    {
        static int[] SzamTomb = new int[10];
        static void Main(string[] args)
        {
            Feladat1TombFeltotl(); Console.WriteLine("\n----------------------\n");
            Feladat2Kiiratas(); Console.WriteLine("\n----------------------\n");
            Feladat3OsszegzeseiTetel(); Console.WriteLine("\n----------------------\n");
            Feladat4MinimumKivalasztas(); Console.WriteLine("\n----------------------\n");
            Feladat5MaximumKivalasztas(); Console.WriteLine("\n----------------------\n");
            Feladat6Eldontes();
            Console.ReadKey();
        }

        private static void Feladat6Eldontes()
        {
            Console.WriteLine("Feladat 6: Keresés");
            Console.Write("Kérem adja meg milyen számot keres: ");
            int KeresesiErtek = int.Parse(Console.ReadLine());
            int Szamlalo = 0;
            while (Szamlalo<SzamTomb.Length && KeresesiErtek != SzamTomb[Szamlalo])
            {
                Szamlalo++;
            }
            if(Szamlalo==SzamTomb.Length)
            {
                Console.WriteLine("Nincs találat az adott keresésre");
            }
            else
            {
                Console.WriteLine("Van ilyen elem, mégpedig a tömb :{0} elem", Szamlalo+1);
            }
        }

        private static void Feladat5MaximumKivalasztas()
        {
            Console.WriteLine("Feladat 5: Maximum kiválasztási tétel");
            int MaximumErtek = int.MinValue;
            int MaxHely = 0;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                if(MaximumErtek<SzamTomb[i])
                {
                    MaximumErtek = SzamTomb[i];
                    MaxHely = i + 1;
                }
            }
            Console.WriteLine("A tömb legnagyobb értéke: {0}", MaximumErtek);
            Console.WriteLine("A maximum érték helye a tömbben: {0}", MaxHely);
        }

        private static void Feladat4MinimumKivalasztas()
        {
            Console.WriteLine("Feladat 4: Tömb minimum értélkének kiválasztása");
            int MinimumErtek = int.MaxValue;
            int MinimumHely = 0;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                if(SzamTomb[i]<MinimumErtek)
                {
                    MinimumErtek = SzamTomb[i];
                    MinimumHely = i+1;
                }
            }
            Console.WriteLine("A tömb legkisebb értéke: {0}", MinimumErtek);
            Console.WriteLine("A minimum hely a tömbön belül: {0}",MinimumHely);
        }

        private static void Feladat3OsszegzeseiTetel()
        {
            Console.WriteLine("Feladat 3. Összegzési tétel");
            int Szum = 0;
            //int Osszeg=0;
            double Atlag = 0;
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                Szum += SzamTomb[i];
            }
            Atlag = (double)Szum / SzamTomb.Length;
            Console.WriteLine("Tömb elemeinek összege: {0}", Szum);
            Console.WriteLine("Tömb elemeinek átlaga: {0}",Atlag);
        }

        private static void Feladat2Kiiratas()
        {
            Console.WriteLine("Feladat 2: Tömb elemeinek kiiratása");
            Console.WriteLine("\tAz ötödik elem : {0}", SzamTomb[4]);
            Console.WriteLine("\tA tömb 10. eleme: {0}", SzamTomb[9]);
            for (int i = 0; i < SzamTomb.Length; i++)
            {
                Console.WriteLine("A tömb {0:00}. eleme = {1}", i+1,SzamTomb[i]);
            }
        }

        private static void Feladat1TombFeltotl()
        {
            Console.WriteLine("Feladat 1: Szám tömb feltöltése");
            SzamTomb = new int[10] {1,5,15,-25,35,-99,88,72,42,35};
        }
    }
}
