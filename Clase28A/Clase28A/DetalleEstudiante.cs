using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase28A
{
    public class DetalleEstudiante
    {
        public int anio;
        public string nombre;

        public void Detalle(int a, string b)
        {
            anio = a;
            nombre = b;
        }
        public void Mostrar()
        {
            Console.WriteLine("El nombre del estudiante es: " + nombre + " y el anio es: " + anio);
        }
    }
    public interface ISports
    {
        void Deporte(string a);
        void VerDeporte();
    }
    public class Sport: DetalleEstudiante, ISports
    {
        public string nomDeporte;
        public void Deporte(string a)
        {
            nomDeporte = a;
        }
        public void VerDeporte()
        {
            Console.WriteLine("El deporte es: " + nomDeporte);
        }
        public void VerTodo()
        {
            Mostrar();
            VerDeporte();
        }
    }
}

