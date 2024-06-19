namespace ES_G3
{
    public class ContoCorrente
    {
        public string name { get; set; }
        public string surname { get; set; }
        public decimal saldo { get; set; }
        public bool conto { get; set; }

        public void apriConto()
        {
            Console.WriteLine("Inserisci il tuo nome:\n");
            name = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome:\n");
            surname = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo saldo iniziale:\n");
            saldo = decimal.Parse(Console.ReadLine());
            if (name != null)
            {
                conto = true;
                Console.WriteLine("Conto aperto con successo!");
            }
            mainMenu(); // Ritorna al menu principale dopo l'apertura del conto
        }

        public void effettuaVersamento()
        {
            string scelta;
            Console.WriteLine("Vuoi effettuare un versamento? (y or n)\n");
            scelta = Console.ReadLine();

            if (conto)
            {
                if (scelta == "y")
                {
                    Console.WriteLine("Inserisci l'importo da versare:\n");
                    decimal importo = decimal.Parse(Console.ReadLine());
                    saldo += importo;
                    Console.WriteLine($"Il tuo nuovo saldo è di {saldo}");
                }
                else if (scelta == "n")
                {
                    Console.WriteLine("Nessun versamento effettuato!\n");
                }
                mainMenu(); // Ritorna al menu principale dopo l'operazione
            }
            else
            {
                Console.WriteLine("Nessun conto trovato. Apri un conto prima di effettuare un versamento.");
                mainMenu();
            }
        }

        public void effettuaPrelievo()
        {
            string scelta;
            Console.WriteLine("Vuoi effettuare un prelievo? (y or n)\n");
            scelta = Console.ReadLine();

            if (conto)
            {
                if (scelta == "y")
                {
                    Console.WriteLine("Inserisci l'importo da prelevare:\n");
                    decimal prelievo = decimal.Parse(Console.ReadLine());
                    if (prelievo <= saldo)
                    {
                        saldo -= prelievo;
                        Console.WriteLine($"Il tuo nuovo saldo è di {saldo}");
                    }
                    else
                    {
                        Console.WriteLine("Saldo insufficiente.");
                    }
                }
                else if (scelta == "n")
                {
                    Console.WriteLine("Nessun prelievo effettuato!\n");
                }
                mainMenu(); // Ritorna al menu principale dopo l'operazione
            }
            else
            {
                Console.WriteLine("Nessun conto trovato. Apri un conto prima di effettuare un prelievo.");
                mainMenu();
            }
        }

        public void mainMenu()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("I N T E S A   S A N   M A R C O   B A N K");
            Console.WriteLine("==========================================");

            Console.WriteLine("\nScegli l'operazione da effettuare:");
            Console.WriteLine("1. APRI NUOVO CONTO CORRENTE");
            Console.WriteLine("2. EFFETTUA UN VERSAMENTO");
            Console.WriteLine("3. EFFETTUA UN PRELIEVO");
            Console.WriteLine("4. ESCI");

            int scelta = int.Parse(Console.ReadLine());
            switch (scelta)
            {
                case 1:
                    apriConto();
                    break;
                case 2:
                    effettuaVersamento();
                    break;
                case 3:
                    effettuaPrelievo();
                    break;
                case 4:
                    Console.WriteLine("Sei uscito dal conto!");
                    break;
                default:
                    Console.WriteLine("Scelta non valida. Riprova.");
                    mainMenu();
                    break;
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            ContoCorrente contoCorrente = new ContoCorrente();
            contoCorrente.mainMenu();
        }
    }
}
