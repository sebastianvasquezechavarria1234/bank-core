using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuent
{
    internal class Logica
    {
        static void Main(string[] arg)
        {
            //Creamos la instancia
            CuentaCorrienteValidada Cuenta1 = new CuentaCorrienteValidada("Sebastian", 100);
            CuentaCorrienteValidada Cuenta2 = new CuentaCorrienteValidada("Jairo", 2000);


            CuentaCorrienteValidada.Transferencia(Cuenta1, Cuenta2, 100);

            Console.WriteLine(Cuenta1.GetDatosCuenta());
            Console.WriteLine(Cuenta2.GetDatosCuenta());
        }
    }
}
