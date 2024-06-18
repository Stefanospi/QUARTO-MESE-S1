namespace G1_ES1
{
    internal class Animale
    {
        public string nome;
        public string razza;
        public int eta;

        public string NOME
        {
            get { return nome; }
            set { nome = value; }

        }
        public string RAZZA
        {
            get { return razza; }
            set { razza = value; }
        }
        public int ETA
        {
            get { return eta; }
            set { eta = value; }
        }

        public void getAnimale()
        {
            Console.WriteLine($"Ciao sono {nome} {razza}, ho {eta}");
        }
    }
}