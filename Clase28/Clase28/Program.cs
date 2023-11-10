namespace Clase28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transaccion t1 = new Transaccion("001","8/10/2023", 78900.00);
            Transaccion t2 = new Transaccion("025", "9/11/2023", 142025.30);
            Console.Write("Ingrese el código: ");
            string cod = Console.ReadLine();
            Console.Write("Ingrese la fecha: ");
            string fecha = Console.ReadLine();
            Console.Write("Ingrese el monto: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            Transaccion t3 = new Transaccion(cod, fecha, monto);

            t1.ShowTran();
            t2.ShowTran();
            t3.ShowTran();

            Console.ReadKey();
        }
    }
}