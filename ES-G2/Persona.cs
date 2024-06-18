using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_G2
{
    internal class Persona
    {
        public string _nome;
        public string _cognome;
        public int _eta;

        public Persona(string nome,string cognome,int eta)
        {  
            _nome = nome;
            _cognome = cognome;
            _eta = eta;
        }

        public void getNome()
        {
            Console.WriteLine(_nome);
        }
        public void getCognome() { 
            Console.WriteLine(_cognome);

        }
        public void getEta() {
            Console.WriteLine(_eta);

        }

        public void getAllPersona()
        {
            Console.WriteLine($"{_nome} {_cognome} {_eta}");
        }
    }
}
