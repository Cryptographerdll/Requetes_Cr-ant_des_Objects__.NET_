using System;
using System.Threading.Tasks;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Requêtes_Créant_des_Objects__.NET_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Personne> Personnes = new List<Personne>
            {
                new Personne("John","Wick",false),
                new Personne("Adam","Alone",false),
                new Personne("Samanta","James",false),
                new Personne("Jack","paul",true),
                new Personne("Jonny","Sins",false),
                new Personne("Marry","Emma",true),
                new Personne("Daniel","Dubov",false)
            };

            // People == Engineers

            var query = from p
                        in Personnes
                        where p.Est_Ingénieur
                        orderby p.Nom , p.Prenom
                        select new Ingénieur(p.Nom + p.Prenom);

            foreach (var i in query)
                Console.WriteLine(i.Nom + " " + i.Prenom);

            Console.WriteLine("-----------------------------------------");

            // Sorting people ! Engineers

            var queryTechniciens = from p
                                   in Personnes
                                   where !p.Est_Ingénieur
                                   orderby p.Nom, p.Prenom
                                   select new Technicien(p.Nom + p.Prenom);

            foreach (var item in queryTechniciens)
                Console.WriteLine(item.Nom + " " + item.Prenom);

            Console.WriteLine("-----------------------------------------");

            // créer une requête qui renvoie des objets anonymes .

            var queryAnonymous = from a
                                 in Personnes
                                 select new { Nom = a.Nom, Prenom = a.Prenom };

            foreach (var item in queryAnonymous)
                Console.WriteLine(item.Nom + " " + item.Prenom);
        }
    }

    class Ingénieur
    {
        private string nom;
        private string prenom;
        private string specialiste;

        public Ingénieur(string v)
        {
            nom = v;
        }

        public Ingénieur (string Nom, string Prenom)
        {
            nom = Nom;
            prenom = Prenom;
        }
        public Ingénieur(string nom, string prenom, string specialiste) 
        {
            this.nom = nom;
            this.prenom = prenom;
            this.specialiste = specialiste;
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }
            set
            {
                this.prenom = value;
            }
        }

        public string Specialiste
        {
            get
            {
                return this.specialiste;
            }
            set
            {
                this.specialiste = value;
            }
        }
    }

    class Personne
    {
        private string nom;
        private string prenom;
        private bool est_Ingénieur;

        public Personne(string nom, string prenom, bool est_Ingénieur)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.est_Ingénieur = est_Ingénieur;
        }

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                this.prenom = value;
            }
        }

        public bool Est_Ingénieur
        {
            get
            {
                return est_Ingénieur;
            }
            set
            {
                this.est_Ingénieur = value;
            }
        }
    }

    class Technicien
    {
        private string nom;
        private string prenom;
        private string v;

        public Technicien(string v)
        {
            nom = v;
        }

        public Technicien(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Nom
        {
            get
            {
                return nom;
            }
            set
            {
                this.nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }
            set
            {
                this.prenom = value;
            }
        }
    }
}
