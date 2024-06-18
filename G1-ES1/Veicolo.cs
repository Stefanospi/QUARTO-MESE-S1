namespace G1_ES1
{
    internal class Veicolo
    {
        public string nome;
        public string modello;
        public int anno;

        public string NOME
        {
            get { return nome; }
            set { nome = value; }

        }
        public string MODELLO
        {
            get { return modello; }
            set { modello = value; }
        }
        public int ANNO
        {
            get { return anno; }
            set { anno = value; }
        }

        public void getVeicolo()
        {
            Console.WriteLine($"Ecco il nome,modello e anno della macchina:{nome} {modello} {anno}");
        }
    }
}