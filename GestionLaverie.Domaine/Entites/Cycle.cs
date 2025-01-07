using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLaverie.Domaine.Entities
{
    public class Cycle
    {
        public int Id { get; set; }
        public float Cout { get; set; }
        public TimeSpan Duree { get; set; }  
        public Cycle() { }

        public Cycle(int id,float cout,TimeSpan duree)
        {
            Id = id;
            Cout = cout;
            Duree = duree;
        }
    }
}

