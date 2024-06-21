using System.Data;

namespace ES_G5
{
    public class utente
    {
        public string nome { get; set; }
        public string cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public decimal RedditoAnnuale { get; set; }

        public utente(string _nome,string _cognome, DateTime _DataNascita ,string _CodiceFiscale, string _Sesso, string _ComuneResidenza, decimal _RedditoAnnuale)
        {
            nome = _nome;
            cognome = _cognome;
            DataNascita = _DataNascita;
            CodiceFiscale = _CodiceFiscale;
            Sesso = _Sesso;
            ComuneResidenza = _ComuneResidenza;
            RedditoAnnuale = _RedditoAnnuale;
        }
        //calcolo dell'imposta
        public decimal CalcolaImposta()
        {
            decimal imposta = 0;

            // Definizione degli scaglioni di reddito e delle aliquote corrispondenti
            decimal[] scaglioni = { 15000, 28000, 55000, 75000 };
            decimal[] aliquote = { 0.23m, 0.27m, 0.38m, 0.41m, 0.43m };

            // Calcolo dell'imposta in base agli scaglioni
            if (RedditoAnnuale <= scaglioni[0])
            {
                imposta = RedditoAnnuale * aliquote[0];
            }
            else if (RedditoAnnuale <= scaglioni[1])
            {
                imposta = scaglioni[0] * aliquote[0] + (RedditoAnnuale - scaglioni[0]) * aliquote[1];
            }
            else if (RedditoAnnuale <= scaglioni[2])
            {
                imposta = scaglioni[0] * aliquote[0] + (scaglioni[1] - scaglioni[0]) * aliquote[1] + (RedditoAnnuale - scaglioni[1]) * aliquote[2];
            }
            else if (RedditoAnnuale <= scaglioni[3])
            {
                imposta = scaglioni[0] * aliquote[0] + (scaglioni[1] - scaglioni[0]) * aliquote[1] + (scaglioni[2] - scaglioni[1]) * aliquote[2] + (RedditoAnnuale - scaglioni[2]) * aliquote[3];
            }
            else
            {
                imposta = scaglioni[0] * aliquote[0] + (scaglioni[1] - scaglioni[0]) * aliquote[1] + (scaglioni[2] - scaglioni[1]) * aliquote[2] + (scaglioni[3] - scaglioni[2]) * aliquote[3] + (RedditoAnnuale - scaglioni[3]) * aliquote[4];
            }

            return imposta;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Inserisci nome:\n");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci cognome:\n");
                string cognome = Console.ReadLine();
                Console.WriteLine("Inserisci la data di nascita(yyyy-MM-dd):\n");
                DateTime dataNascita;
                while (!DateTime.TryParse(Console.ReadLine(), out dataNascita))
                {
                    Console.Write("Data non valida. Inserisci la data di nascita (yyyy-MM-dd): ");
                }
                Console.WriteLine("Inserisci codice fiscale:\n");
                string codiceFiscale = Console.ReadLine();
                Console.WriteLine("Inserisci il sesso(M/F):\n");
                string sesso = Console.ReadLine();
                Console.WriteLine("Inserisci comune di residenza:\n");
                string comuneResidenza = Console.ReadLine();
                Console.WriteLine("Insersci reddito annuale:\n");
                decimal redditoAnnuale = decimal.Parse(Console.ReadLine());
                

                // creo l'oggetto utente

                utente utente = new utente(nome,cognome,dataNascita,codiceFiscale,sesso,comuneResidenza,redditoAnnuale);
                decimal imposta = utente.CalcolaImposta();

                // Stampa del riepilogo
                Console.WriteLine("\nRiepilogo:");
                Console.WriteLine($"Nome: {utente.nome}");
                Console.WriteLine($"Cognome: {utente.cognome}");
                Console.WriteLine($"Data di Nascita: {utente.DataNascita.ToShortDateString()}");
                Console.WriteLine($"Codice Fiscale: {utente.CodiceFiscale}");
                Console.WriteLine($"Sesso: {utente.Sesso}");
                Console.WriteLine($"Comune di Residenza: {utente.ComuneResidenza}");
                Console.WriteLine($"Reddito Annuale: {utente.RedditoAnnuale}");
                Console.WriteLine($"Imposta da Pagare: {imposta}");

            }
        }
    }
}
