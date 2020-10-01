using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjExpendedora
{
    public static class ConsolaHelper
    {

        public static string PedirTexto(string ingreso)
        {
            Console.WriteLine(ingreso);
            return Console.ReadLine();
        }
        public static int PedirNumero(string texto)
        {
            bool esnumero = false;
            int numero;
            do
            {
                Console.WriteLine(texto);
                if (int.TryParse(Console.ReadLine(), out numero) == true)
                    esnumero = true;
                else Console.WriteLine("\n--Lo ingresado no es número --\n");
            } while (esnumero == false);
            return numero;
        }

        public static void Mensaje(string msj)
        {
            Console.WriteLine(msj);
        }
    }
}
