using _210120PraktineUzduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210120PraktineUzduotis.InitialData
{
    public class ProfessionData
    {
        public List<Profession> DataSeed => new List<Profession>
        {
            new Profession{Text ="Programuotojas"},
            new Profession{Text ="Gaisrininkas"},
            new Profession{Text ="Vairuotojas"},
            new Profession{Text ="Medikas"},
            new Profession{Text ="Pardavejas"},
            new Profession{Text ="Veterinaras"},
            new Profession{Text ="Sportininkas"},
            new Profession{Text ="Statybininkas"},
            new Profession{Text ="Vyrejas"},
            new Profession{Text ="Sefas"},
            new Profession{Text ="Stalius"},
            new Profession{Text ="Valytojas"},
            new Profession{Text ="Kasininkas"},
            new Profession{Text ="Sandelininkas"},
            new Profession{Text ="Vadybininkas"},


        };
    }
}
