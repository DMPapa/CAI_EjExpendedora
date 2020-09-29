using EjExpendedora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleccion;
            Expendedora e1;
            e1 = new Expendedora("Miguelito");

            ConsolaHelper.PedirTexto("Bienvenido a la expendedora de: " + e1.Proveedor + ". Encienda la maquina presionando ENTER   ");
            e1.Encendida = true;

            if (e1.Encendida == true)
                do
                {
                    eleccion = ConsolaHelper.PedirNumero("Selecione opción: \n1- Listado disponible \n2- Insetar lata \n3- Pedir lata \n4- Conocer balance \n5- Conocer stock y descripción \n6- Apagar \n");

                    if (eleccion > 6 || eleccion < 1)
                        ConsolaHelper.PedirNumero ("\n--Debe ingresar una opción válida--\n");

                    else
                    switch (eleccion)
                         {
                            case 1: e1.ToString();
                                break;
                            case 2:  e1.AgregarLata();
                                break;
                            case 3: e1.ExtraerLata();
                                break;
                            case 4: e1.GetBalance();
                                break;
                            case 5: e1.GetCapacidadRestante();
                                break;
                            case 6: e1.Encendida = false;
                                break;
                         }

                } while (e1.Encendida == true);
        }
    }
}
