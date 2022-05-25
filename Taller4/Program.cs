using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Cuenta cuenta = new Cuenta();

            opcion = SeleccionarOpcion();

            while (opcion != 4)
            {
                switch (opcion)
                {
                    case 1:
                        cuenta.ConsultarSaldo();
                        break;
                    case 2:
                        Console.Write("\nIngrese el monto a retirar: ");
                        int monto;
                        try
                        {
                            monto = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            break;
                        }
                        cuenta.RetirarEfectivo(monto);
                        break;
                    case 3:
                        Console.Write("\nIngrese el dinero a consignar: ");
                        int efectivo;
                        try
                        {
                            efectivo = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            break;
                        }
                        cuenta.ConsignarEfectivo(efectivo);
                        break;
                    case 4:
                        Console.WriteLine("Mensaje despedida");
                        return;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
                opcion = SeleccionarOpcion();
            }
            Console.ReadKey();
        }

        private static int SeleccionarOpcion()
        {
            try
            {
                Console.WriteLine("\nBANCO GRUPO R-15");
                Console.WriteLine("Cajero automático");
                Console.WriteLine("Seleccione Transacción");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Retiro de efectivo");
                Console.WriteLine("3. Consignar efectivo");
                Console.WriteLine("4. Terminar");
                Console.Write("Su opción: ");
                return int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
