using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Objetos
{
    internal class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precioCompra;
        private double _precioVenta;
        private string _categoria;
        private double _monto {  get; set; }    


        public int Codigo 
        { 
            get 
            { 
                //Lectura (Modificable)
                return _codigo; 

            } 
            set //Escritura (Valor fijo no modificable)
            { _codigo = value; 
            
            } 
        }

        public string Descripcion
        {
            get
            {
                //Lectura (Modificable)
                return _descripcion;

            }
            set //Escritura (Valor fijo no modificable)
            {
                _descripcion = value;

            }
        }

        public double PrecioCompra
        {
            get
            {
                //Lectura (Modificable)
                return _precioCompra;

            }
            set //Escritura (Valor fijo no modificable)
            {
                _precioCompra = value;

            }
        }

        public double PrecioVenta
        {
            get
            {
                //Lectura (Modificable)
                return _precioVenta;

            }
            set //Escritura (Valor fijo no modificable)
            {
                _precioVenta = value;

            }
        }

        //Propiedad de SOLO LECTURA
        public string Categoria
        {
            get
            {
                //Lectura (Modificable)
                return _categoria;

            }
            
        }








        public Producto()
        {
            _codigo = 0;
            _descripcion = string.Empty;
            _precioCompra = 0;
            _precioVenta = 0;
            _categoria = string.Empty;

        }


        public Producto(int codigo, string descripcion, double precioCompra, double precioVenta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precioCompra = precioCompra;
            this._precioVenta = precioVenta;
            this._categoria = categoria;
        }

        public bool HayPreciodeVenta()
        {
            return this._precioVenta > 0;
        }




































    }
}
