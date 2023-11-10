namespace Clase28A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sport de = new Sport();
            de.Detalle(2023, "Luis");
            de.Deporte("Voley");
            de.VerTodo();
            Console.ReadKey();

        }
    }
}