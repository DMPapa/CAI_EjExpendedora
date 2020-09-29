using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<Lata> _lata;
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


        public Expendedora(string prov)
        {
            this._proveedor = prov;
            this._capacidad = 0;
            this._dinero = 0;
            this.Encendida = false;
            this._lata = new List<Lata>();

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
