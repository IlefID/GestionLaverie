using System;
namespace GestionLaverie.Domaine.Entities
{
    
        public class Laverie
        {
            public int Id { get; set; }
            public string Nom { get; set; }
            public string Adresse { get; set; }
            public List<Machine> Machines { get; set; } 

            public Laverie() 
            {
                Id = 0;
                Nom = "";
                Adresse = "";
                Machines = new List<Machine>();

            }

            public Laverie(int id, string nom, string adresse)
            {
                Id = id;
                Nom = nom;
                Adresse = adresse;
                Machines = new List<Machine>();

            }
        }

}
