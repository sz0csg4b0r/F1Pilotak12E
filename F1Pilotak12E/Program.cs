using F1Pilotak12E.Model;

namespace F1Pilotak12E
{
    internal class Program
    {
        public static List<Pilota> pilotak = new List<Pilota>();

        static void Main(string[] args)
        {
            Beolvas("pilotak.csv");
            //Teszt(pilotak);
            PilotakSzama(pilotak);
            UtolsoPilotaNeve(pilotak);
            T9SzazadPilotai(pilotak);

        }

        private static void T9SzazadPilotai(List<Pilota> pilotak)
        {
            Console.WriteLine("3. feladat: A tizenkilencedik század pilótái: "  );
            foreach(Pilota pilota in pilotak)
            {
                if(pilota.SzuletesiDatum.Substring(0, 2) == "18")
                {
                    cw
                }
            }
        }

        private static void UtolsoPilotaNeve(List<Pilota> pilotak)
        {
            Console.WriteLine($"2. A listában az utolsó pilóta neve?\n\tPilóta neve: {pilotak[^1].Nev}");
        }

        private static void PilotakSzama(List<Pilota> pilotak)
        {
            Console.WriteLine($"1. feladat: Hány pilóta adat van a fájlban?\n\tPiloták száma: {pilotak.Count}");
        }

        private static void Teszt(List<Pilota> pilotak)
        {
            Console.WriteLine(pilotak.Count);
        }

        private static void Beolvas(string fajlnev)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fajlnev))
                {
                    string line = "";

                    if ((line = reader.ReadLine()) == null)
                    {
                        Console.WriteLine("A fájl üres vagy nincs fejléc");
                        return;
                    }
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] parts = line.Split(';');
                        if (parts.Length == 4)
                        {
                            Pilota pilota = new Pilota();
                            pilota.Nev = parts[0];
                            pilota.SzuletesiDatum = parts[1];
                            pilota.Nemzetiseg = parts[2];
                            pilota.Rajtszam = parts[3];
                            pilotak.Add(pilota);
                        }
                        else
                        {
                            Console.WriteLine("Hibás sor formátum/szerkezet");
                        }
                    }
                }
            }
            catch (FileNotFoundException error)
            {
                Console.WriteLine($"A fájl nem található: {error.Message}");
            }
            catch (IOException error)
            {
                Console.WriteLine($"I/O hiba: {error.Message}");
            }
            catch (Exception error)
            {
                Console.WriteLine($"Általános hiba: {error.Message}");
            }
        }
    }
}
