namespace ES3_G3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Specifica le dimensioni dell'array che vuoi creare:\n");
            x = int.Parse(Console.ReadLine());
            int[] num = new int[x];

            int i;
            int somma = 0; 
            for(i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Inserisci un numero finchè non riempi la dimensione dell'array:\n");
                num[i] = int.Parse(Console.ReadLine());  
            }
            for(i= 0; i < num.Length; i++)
            {
                somma += num[i];
            }

            Console.WriteLine($"La somma dei numeri inseriti all'interno dell'array è: {somma}");
            Console.WriteLine($"La media dei numeri inseriti all'interno dell'array è: {somma / x}");
            Console.ReadLine();
        }
    }
}
