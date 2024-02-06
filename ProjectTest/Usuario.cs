using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTest
{
    public class Usuario
    {
        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contrasenia;
        private string _mail;



        public int Id
            
        {
            get { return _id; } 
            set { _id = value; }
        }

        public string Nombre

        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido

        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string NombreUsuario

        {
            get { return _nombreUsuario; }
            set { _nombreUsuario = value; }
        }

        public string Contrasenia

        {
            get { return _contrasenia; }
            set { _contrasenia = value; }
        }

        public string Mail

        {
            get { return _mail; }
            set { _mail = value; }
        }

        public Usuario()
        {
            _id = 0;
            _nombre = string.Empty;
            _apellido = string.Empty;
            _nombreUsuario = string.Empty;
            _contrasenia = string.Empty;
            _mail = string.Empty;

        }

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            this._id = id;
            this._nombre = nombre; 
            this._apellido = apellido;
            this._nombreUsuario = nombreUsuario;
            this._contrasenia = contrasenia;
            this._mail = mail;



        }

    }
}

