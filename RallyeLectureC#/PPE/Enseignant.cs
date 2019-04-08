using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PPE
{
    class Enseignant
    {
        int id;
        string nom, prenom, login, hashPassWord;
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public Enseignant(int id,string nom, string prenom, string login, string hashPassWord) {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.login = login;
            this.hashPassWord = hashPassWord;
        }
    }
}
