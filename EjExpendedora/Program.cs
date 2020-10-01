using EjExpendedora.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EjExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construcción de la Expendedora

            int eleccion;
            
            Expendedora e1;
            List<Lata> listaLatas = new List<Lata>();
            e1 = new Expendedora("Miguelito");
            e1.ListaLatas = listaLatas;

            listaLatas.Add(new Lata("CO1", "Coca Cola", "Regular"));
            listaLatas.Add(new Lata("CO2", "Coca Cola", "Zero"));
            listaLatas.Add(new Lata("SP1", "Sprite", "Regular"));
            listaLatas.Add(new Lata("SP2", "Sprite", "Zero"));
            listaLatas.Add(new Lata("FA1", "Fanta", "Regular"));
            listaLatas.Add(new Lata("FA2", "Fanta", "Zero"));

            
            
            // Aquí comienza la aplicación

            ConsolaHelper.PedirTexto("Bienvenido a la expendedora de: " + e1.Proveedor + ". Encienda la maquina presionando ENTER   ");
            e1.Encendida = true;

            if (e1.Encendida == true)
                do
                {
                    eleccion = ConsolaHelper.PedirNumero("Selecione opción: \n1- Listado disponible \n2- Insertar lata \n3- Pedir lata \n4- Conocer balance \n5- Conocer stock y descripción \n6- Apagar \n");

                    if (eleccion > 6 || eleccion < 0)
                        ConsolaHelper.PedirNumero ("\n--Debe ingresar una opción válida--\n");

                    else
                    switch (eleccion)
                         {
                            case 1:     ConsolaHelper.PedirTexto(e1.GetLatas() + "\nPresione ENTER para volver al menú\n");
                                break;
                            case 2:
                                        string eleccion2 = ConsolaHelper.PedirTexto(e1.GetLatas());
                                        e1.AgregarLata(eleccion2);
                                    
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
