using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_de_Interface
{
    public class ÁreaRectangulo : IArea
    {
        public double incognita1; public double incognita2; public double resultado;
        
        double IArea.Incognita1 { get { return incognita1; } set { incognita1 = value; } }
        double IArea.Incognita2 { get { return incognita2; } set { incognita2 = value; } }
        double IArea.Resultado { get { return resultado; } set { resultado = value; } }

        public void calcularArea()
        {
            resultado = incognita1 * incognita2;
        }
    }

    public class ÁreaTriangulo: IArea
    {
        public double incognita1; public double incognita2; public double resultado;

        double IArea.Incognita1 { get { return incognita1; } set { incognita1 = value; } }
        double IArea.Incognita2 { get { return incognita2; } set { incognita2 = value; } }
        double IArea.Resultado { get { return resultado; } set { resultado = value; } }

        public void calcularArea()
        {
            resultado = (incognita1 * incognita2) / 2;
        }
    }


    public class ÁreaCuadrado : IArea
    {
        public double incognita1; public double resultado;

        double IArea.Incognita1 { get { return incognita1; } set { incognita1 = value; } }
        double IArea.Incognita2 { get { return incognita1; } set { incognita1 = value; } }
        double IArea.Resultado { get { return resultado; } set { resultado = value; } }

        void IArea.calcularArea()
        {
            resultado = incognita1 * incognita1;
        }
    }


    //Interfaz principal, se pueden implementar y combinar todas las interfaces las veces que se deseen, una vez cumplan 
    //el requisito mínimo o mejor dicho el "Contrato" todo funcionara perfectamente.
    public interface IArea
    {
        double Incognita1 { get; set; }
        double Incognita2 { get; set; }
        double Resultado { get; set; }
        
        void calcularArea();
    }

    
}
