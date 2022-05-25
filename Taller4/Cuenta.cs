using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller4
{
    class Cuenta
    {
        private double saldo = 50;

        public void ConsultarSaldo()
        {   
            if (saldo < 0)
            {
                Console.WriteLine("\nSALDO NEGATIVO");
            }
            Console.WriteLine("El saldo de la cuenta es {0}", saldo);
        }

        public void RetirarEfectivo(int cantidad)
        {
            if (cantidad < 0)
            {
                Console.WriteLine("\nEl monto a retirar es inválido");
                return;
            }
            if (saldo < 0)
            {
                Console.WriteLine("Tiene un saldo negativo, no puede realizar retiros");
                return;
            }
            saldo -= cantidad;
            Console.WriteLine("Retiro realizado con éxito");
            ConsultarSaldo();
        }

        public void ConsignarEfectivo(int efectivo)
        {
            saldo += efectivo;
            Console.WriteLine("\nConsignación realizada con éxito");
            ConsultarSaldo();
        }
    }
}
