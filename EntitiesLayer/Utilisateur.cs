using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Utilisateur : EntityObject
    {
        public string Login
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public string Nom
        {
            get;
            set;
        }

        public string Prenom
        {
            get;
            set;
        }

        public int Points
        {
            get;
            set;
        }


        public Utilisateur()
        {
            this.Id = 1;
            this.Login = "bob";
            this.Password = "bleu";
            this.Points = 1000;
        }

        public Utilisateur(int id, string login, string password, string nom, string prenom, int points)
        {
            this.Id = id;
            this.Login = login;
            this.Password = password;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Points = points;
        }

    }
}
