using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingWSrc
{
    class Personne
    {
        private string nom, prenom;
        private DateTime dateNaiss;
        private int age;

        public Personne()
        {
            this.nom = "pas2Nom";
            this.Prenom = "pas2Prenom";
            this.dateNaiss = Convert.ToDateTime("03/04/2012");
        }

        public Personne(string nom)
        {
            this.nom = nom;
        }

        public Personne(string nom, string prenom, DateTime dateNaiss)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
        }

        public Personne(string nom, string prenom, DateTime dateNaiss, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaiss = dateNaiss;
            this.age = age;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }
        public int Age { get => age; set => age = value; }
    }
}
