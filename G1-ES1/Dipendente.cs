namespace G1_ES1
{
    internal class Dipendente
    {
        public string nome;
        public string cognome;
        public int eta;
        public string lavoro;

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
        public string LAVORO
        {
            get { return lavoro; }
            set { lavoro = value; }
        }

        public void getDipendente()
        {
            Console.WriteLine($"Ciao sono {nome} {cognome}, ho {eta} e gioco a {lavoro}");
        }
    }
}