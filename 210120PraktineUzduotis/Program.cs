using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210120PraktineUzduotis
{
    class Program
    {
        static List<string> miestai = new List<string> { "Vilnius", "Kaunas", "Klaipeda", "Alytus" };

        static List<int> skaiciai = new List<int> { 3, 3, 5, 7, 8, 10 };

        static void Main(string[] args)
        {


            var miestaiIsK = miestai.Where(n => n.StartsWith("K")).ToList();

            foreach (var i in miestaiIsK)
                Console.WriteLine("Miestas: {0}", i);

            Console.WriteLine("Miestas {0}", string.Join(", ", miestai));
            Console.WriteLine("____________________________");

            Console.WriteLine("Miestas {0}", string.Join(", ", miestai.Where(m => m.StartsWith("K"))));

            Console.WriteLine("Miestu kiekis i K - {0}", miestai.Count(m => m.StartsWith("K")));

            Console.WriteLine("Miestu kiekis i K - {0}", miestai.Where(m => m.StartsWith("K")).ToList().Count);

            Console.WriteLine("Ar yra miestas Kaunas? {0}", miestai.Any(n => n == "Kaunas") ? "Taip" : "Ne");

            var surusiuotiMiestaiNuoAIkiZ = miestai.OrderBy(z => z);
            Console.WriteLine("____________________________");
            Console.WriteLine("Surusiuoti miestai(nuo A iki Z) {0}", string.Join(", ", surusiuotiMiestaiNuoAIkiZ));
            var surusiuotiMiestaiNuoZIkiA = miestai.OrderByDescending(z => z);
            Console.WriteLine("Surusiuoti miestai(nuo A iki Z) {0}", string.Join(", ", surusiuotiMiestaiNuoZIkiA));
            Console.WriteLine("____________________________");

            Console.WriteLine("Skaiciu suma {0}", skaiciai.Sum());
            Console.WriteLine("Skaiciu minimali reiksme {0}", skaiciai.Min());
            Console.WriteLine("Skaiciu minimali reiksme {0}", skaiciai.Max());
            Console.WriteLine("Skaiciu vidurkis {0}", skaiciai.Average());

            Console.WriteLine("Skaiciu vidurkis {0}", skaiciai.Distinct().Average());
            Console.WriteLine("Unikaliu skaiciu vidurkis {0}", skaiciai.Distinct().Where(s => s < 5).Average());

            Console.ReadLine();

        }
    }
}
