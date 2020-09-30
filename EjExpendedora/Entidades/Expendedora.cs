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


        public Expendedora(string prov, List<Lata> l)
        {
            this._proveedor = prov;
            this._capacidad = 0;
            this._dinero = 0;
            this.Encendida = false;
            this._latas = new List<Lata>(l);

        }

        public string GetLatas ()
        {
            string listado ="";
            foreach (Lata la in this._latas)
            {
                listado += la.Codigo + " - " + la.Nombre + "\n";
             
            }
            return listado;
        }

        public void AgregarLata ()
        {

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
