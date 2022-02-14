using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestJR1402.Models
{
    public class Personne
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string datedenaissance { get; set; }



        public ICollection<Cours> LesCours { get; }
    }
}

