using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjExpendedora.Entidades
{
    class Expendedora
    {

        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;
        private List<Lata> _latas;
        public string Proveedor
        {
            get
            {
                return this._proveedor;
            }
            set
            {
                this._proveedor = value;
            }
        }

        public int Capacidad
        {
            get
            {
                return this._capacidad;
            }
            set
            {
                this._capacidad = value;
            }
        }

        public double Dinero
        {
            get
            {
                return this._dinero;
            }
            set
            {
                this._dinero = value;
            }
        }

        public bool Encendida
        {
            get
            {
                return this._encendida;
            }
            set
            {
                this._encendida = value;
            }
        }
        public List<Lata> ListaLatas
        {
            get
            {
                return this._latas;
            }
            set
            {
                this._latas = value;
            }
        }


        public Expendedora(string prov)
        {
            this._proveedor = prov;
            this._capacidad = 50;
            this._dinero = 0;
            this.Encendida = false;
            this._latas = new List<Lata>();

        }

        public string GetLatas ()
        {
            string listado ="";
            foreach (Lata la in this._latas)
            {
                listado += la.Codigo + " - " + la.Nombre + "\n" + la.Sabor + "\n";
             
            }
            return listado;
        }

        public void AgregarLata (string cod)
        {
            int a = 1;
            int b = 5;
            if (a < b)
                throw new Exception("ERROR: Codigo invalido");
            else
                if (this._latas.Any(x => x.GetCodigo == cod))
                foreach (Lata la in this._latas)
                {
                    if (la.GetCodigo == cod)
                        la.Precio = ConsolaHelper.PedirNumero("Ingrese precio de las latas");
                    la.Volumen = ConsolaHelper.PedirNumero("Ingrese cantidad de latas");
                    this._capacidad -= la.Volumen;
                }
                    
        }

        public void ExtraerLata ()
        {

        }

        public string GetBalance ()
        {
            return "algo";

        }
        
        public int GetCapacidadRestante()
        {
            return this.Capacidad;

        }

        public void EncenderMaquina()
        {
            if (this.Encendida ==true)
             this.Encendida = true;
        }
        public bool EstaVacia()
        {
            return true;
        }
    }
}
