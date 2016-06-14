using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTP.Models
{
    public class Usuario
    {
        private string nombre;
        private string password;
        private string email;

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Password
        {
            set { password = value; }
            get { return password; }
        }

        public string Email
        {
            set { email = value; }
            get { return email; }
        }

        public Usuario()
        {
            this.nombre = "";
            this.password = "";
            this.email = "";
        }

        public Usuario(string nombre, string password, string email)
        {
            this.nombre = nombre;
            this.password = password;
            this.email = email;
        }
    }
}