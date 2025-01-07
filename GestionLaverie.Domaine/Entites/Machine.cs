using System.Reflection.PortableExecutable;
using System.Reflection;

namespace GestionLaverie.Domaine.Entities
{
    public class Machine
    {
        public int IdMachine { get; set; }  
        public string Marque { get; set; }
        public string Modele { get; set; }
        public int Etat { get; set; }

        public List<Cycle> Cycles { get; set; }
        
        public Machine(int idMachine, string marque, string modele, int etat, List<Cycle> cycles)
        {
            IdMachine = idMachine;
            Marque = marque;
            Modele = modele;
            Etat = etat;
            Cycles = cycles;
        }

        public Machine() 
        {
            IdMachine = 0;
            Marque = "";
            Modele = "";
            Etat = 0;
            Cycles = new List<Cycle>();

        }
    }
}
