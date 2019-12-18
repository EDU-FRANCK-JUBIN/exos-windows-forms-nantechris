using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databinding
{
    class Chanson
    {
        private string nomArtiste;
        private string titreChanson;

        public Chanson(string nomArtiste, string titreChanson)
        {
            this.nomArtiste = nomArtiste;
            this.titreChanson = titreChanson;
        }

        //Nom de l'artiste
        public string NomArtiste { get => nomArtiste; set => nomArtiste = value; }
        //Titre de la chanson
        public string TitreChanson { get => titreChanson; set => titreChanson = value; }
    }
}
