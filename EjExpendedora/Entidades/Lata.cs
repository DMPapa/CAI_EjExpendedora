using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjExpendedora.Entidades
{
    class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _Volumen;

        public string Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        public string Codigo2
        {
            get
            {
                return this._codigo;
            }
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }
        public string Sabor
        {
            get
            {
                return this._sabor;
            }
            set
            {
                this._sabor = value;
            }
        }
    public double Precio
        {
            get
            {
                return this._precio;
            }
            set
            {
                this._precio = value;
            }
        }
        public double Volumen
        {
            get
            {
                return this._Volumen;
            }
            set
            {
                this._Volumen = value;
            }
        }

        public Lata(string cod, string nom, string sab, double precio, double vol)
        {
            this._codigo = cod;
            this._nombre = nom;
            this._sabor = sab;
            this._precio = precio;
            this._Volumen = vol;
        }

        public Lata (string cod, string nom)
        {
            this._codigo = cod;
            this._nombre = nom;
        }

        public double GetPrecioPorLitro()
        {
            return (this._precio * this.Volumen / 1000); 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
