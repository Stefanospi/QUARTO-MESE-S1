namespace G1_ES1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atleta atleta = new Atleta();
            atleta.NOME = "Stefano";
            atleta.COGNOME = "Spitaleri";
            atleta.ETA = 23;
            atleta.SPORT = "Calcio\n";
            atleta.getAtleta();

            Dipendente dipendente = new Dipendente();
            dipendente.NOME = "Stefano";
            dipendente.COGNOME = "Spitaleri";
            dipendente.ETA = 23;
            dipendente.LAVORO = "Programmatore\n";
            dipendente.getDipendente();

            Animale animale = new Animale();
            animale.NOME = "Bobby";
            animale.RAZZA = "Husky";
            animale.ETA = 7;
            animale.getAnimale();

            Veicolo veicolo = new Veicolo();
            veicolo.NOME = "Ferrari";
            veicolo.MODELLO = "450";
            veicolo.ANNO = 2012;
            veicolo.getVeicolo();
        }
    }
}
