using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_ES1
{
    internal class Atleta
    {
        public string nome;
        public string cognome;
        public int eta;
        public string sport;

        public string NOME
        {
            get { return nome; }
            set { nome = value; }

        }
        public string COGNOME
        {
            get { return cognome; }
            set { cognome = value; }
        }
        public int ETA
        {
            get { return eta; }
            set { eta = value; }
        }
        public string SPORT
        {
            get { return sport; }
            set { sport = value; }
        }

        public void getAtleta()
        {
            Console.WriteLine($"Ciao sono {nome} {cognome}, ho {eta} e gioco a {sport}");
        }
    }
}
