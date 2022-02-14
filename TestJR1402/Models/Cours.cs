using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestJR1402.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Personne> LesPersonnes { get; }
    }
}


