using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GestionLaverie.Domaine.Entities
{
    public class Proprietaire
    {
         public int Id { get; set; }
        public string NomProprietaire { get; set; }

        public List<Laverie> Laveries { get; set; }


        [JsonConstructor]
        public Proprietaire(int id, string nomProprietaire)
        {
            Id = id;
            NomProprietaire = nomProprietaire;
            Laveries = new List<Laverie>();
        }
        [JsonConstructor]
        public Proprietaire()
        {
            Id=0;
            NomProprietaire = "";
            Laveries = new List<Laverie>();
        }

    }
}
