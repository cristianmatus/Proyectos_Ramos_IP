using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JSON_Example.Models
{
    public class Clientes
    {
        public string nombre;
        public string apellido;
        public string direccion;
        public int edad;

        public Clientes()
        {
            Nombre = "Cristian";
            Apellido = "Matus";
            Direccion = "Macul";
            Edad = 29;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}