using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollinAugustin_UAA14_chiens
{
    internal class Chien
    {
        //attributs
        private int _age; // age du chien 
        private string _nom; // nom du chien 
        private string _race; // race du chien 
        private int _poids; // poids du chien 

        //constructeur
        public Chien(int age, int poids, string nom, string race)
        {
            _nom = nom;
            _age = age;
            _race = race;
            _poids = poids; 
        }
        //methodes
        public string AfficheCaractéristiques()
        {
            return $"le chien a {_age} an(s) il sappelle {_nom} c'est un {_race} il pèse {_poids} killos" ;
        }
        public string Aboyer()
        {
            return "waf waf";
        }
        public void vieillir() 
        {
            _age += 1;
        }
    }
}
