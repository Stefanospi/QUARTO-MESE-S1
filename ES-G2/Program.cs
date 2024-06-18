namespace ES_G2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Stefano","Spitaleri",23);

            persona.getNome();
            persona.getCognome();
            persona.getEta();
            persona.getAllPersona();

        }
    }
}
