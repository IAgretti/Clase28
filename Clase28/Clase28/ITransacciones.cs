using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase28
{
    public interface ITransacciones
    {
        void ShowTran();
        double MontoTotal();
    }
    public class Transaccion:ITransacciones
    {
        private string tCode, date;
        private double monto;

        public Transaccion()
        {
            tCode = "";
            date = "";
            monto = 0.0;
        }
        public Transaccion(string c, string d, double a)
        {
            tCode = c;
            date = d;
            monto = a;
        }
        public double MontoTotal()
        {
            return monto;
        } 
        public void ShowTran()
        {
            Console.WriteLine("Transacción: " + tCode);
            Console.WriteLine("Fecha: " + date);
            Console.WriteLine("Monto: " + MontoTotal() + "\n");
        }
    }
    
}
