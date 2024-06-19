using System.Security;

namespace ES2_G3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nomi = { "Stefano", "Flavio", "Andrea", "Francesco","Adriano" };

            string nomeDaCercare;
            bool verifica = false;

            Console.WriteLine("Che nome vuoi cercare nell'array?\n");
            nomeDaCercare = Console.ReadLine();

            for (int i = 0; i < nomi.Length; i++) {
                if (nomi[i] == nomeDaCercare)
                {
                    Console.WriteLine("Il nome risulta nella lista dell'array!\n");
                    verifica = true;
                }
            }
                if (verifica == false) {
                    Console.WriteLine("Il nome non risulta nella lista dell'array!\n");
                }
        }
    }
}
