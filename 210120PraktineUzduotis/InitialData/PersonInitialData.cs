using _210120PraktineUzduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _210120PraktineUzduotis.InitialData
{
    public class PersonInitialData
    {
        public List<Person> DataSeed => new List<Person>
        {
            new Person {FirstName = "Jonas", LastName = "Jonaitis", BirthDate = new DateTime(1999,2,3) },
            new Person {FirstName = "Jonas", LastName = "Berankis", BirthDate = new DateTime(1999,2,3) },
            new Person {FirstName = "Tomas", LastName = "Trumparegii", BirthDate = new DateTime(1985,2,6) },
            new Person {FirstName = "Linas", LastName = "Daugaitis", BirthDate = new DateTime(1978,10,3) },
            new Person {FirstName = "Lukas", LastName = "Povilaitis", BirthDate = new DateTime(1992,9,6)},
            new Person {FirstName = "Petras", LastName = "Jovas", BirthDate = new DateTime(1999,2,3)},
            new Person {FirstName = "Giedrius", LastName = "Povas", BirthDate = new DateTime(1999,5,3)},
            new Person {FirstName = "Simas", LastName = "Kaunas", BirthDate = new DateTime(1999,2,3)},
            new Person {FirstName = "Gytis", LastName = "Jomys", BirthDate = new DateTime(2000,6,3)},
            new Person {FirstName = "Lukas", LastName = "Laureckas", BirthDate = new DateTime(2005,7,3)},
            new Person {FirstName = "Gustovas", LastName = "Jarutis", BirthDate = new DateTime(1968,9,4)},
            new Person {FirstName = "Rimas", LastName = "Birutis", BirthDate = new DateTime(1999,8,3)},
            new Person {FirstName = "Natas", LastName = "Sabonis", BirthDate = new DateTime(1997,2,3)},
            new Person {FirstName = "Azuolas", LastName = "Vanagas", BirthDate = new DateTime(2005,1,10) },
            new Person {FirstName = "Laurynas", LastName = "Jonaitis", BirthDate = new DateTime(2010,5,10) }
        };
    }
}
