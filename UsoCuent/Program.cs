using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoCuent
{
    internal class CuentaCorrienteValidada
    {
        //Encapsular variables
        private double Saldo;
        private string NombreTitular;
        private long NumeroCuenta;

        //Contructor
        public CuentaCorrienteValidada(string NombreTitular, double Saldo)
        {
            this.Saldo = Saldo;
            this.NombreTitular = NombreTitular;

            Random GeneradorCuenta = new Random();
            NumeroCuenta = Math.Abs(GeneradorCuenta.Next());
           
        }

        public void SetIngreso(double Ingreso)
        {
            if(Ingreso < 0)
            {
                Console.WriteLine("No se pueden ingresar negativos");
            }
            else
            {
                Saldo += Ingreso;
            }
        }

        private void SetReingreso(double ReIngreso)
        {
            Saldo -= ReIngreso;
        }

        public string GetSaldo()
        {
            return "El saldo es de" + Saldo;
        }

        public string GetDatosCuenta()
        {
            return "el nombre del titular es:" +NombreTitular+ "el numero de cuenta es:" + NumeroCuenta + "el saldo de la cuenta es:" + Saldo;
        }

        public static void Transferencia(CuentaCorrienteValidada Titul1, CuentaCorrienteValidada Titul2, double Cantidad)
        {
            if (Titul1 != null && Titul2 != null)
            {
                if (Titul1.Saldo >= Cantidad)
                {
                    Titul1.Saldo -= Cantidad;
                    Titul2.Saldo += Cantidad;
                    Console.WriteLine("Transferencia Exitoso");
                }
                else
                {
                    Console.WriteLine("No tienes dinero suficiente");
                }
            }
            else
            {
                Console.WriteLine("Una o ambas cuentas no existen");
            }
        }


    }
}


