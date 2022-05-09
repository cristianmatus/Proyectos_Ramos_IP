using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProject_Cristian_Matus.Clases
{
    class Perro:Iperro
    {
        private string nombre;
        private int canpatas;
        private string enfermedad;
        private bool urgencia;


        public Perro()
        {
            nombre = "Sam";
            canpatas = 4;
            enfermedad = "tumor";
            urgencia = true;
        }

        public Perro(string nombre, int canpatas, string enfermedad, bool urgencia)
        {
            this.nombre = nombre;
            this.canpatas = canpatas;
            this.enfermedad = enfermedad;
            this.urgencia = urgencia;
    }

        public string getNombre()
        {
            return nombre;
        }

        public int getCanpatas()
        {
            return canpatas;
        }

        public string getEnfermedad()
        {
            return enfermedad;
        }

        public bool getUrgencia()
        {
            return urgencia;
        }


        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void setCanpatas(int canpatas)
        {
            this.canpatas = canpatas;
        }

        public void setEnfermedad(string enfermedad)
        {
            this.enfermedad = enfermedad;
        }

        public void setUrgencia(bool urgencia)
        {
            this.urgencia = urgencia;
        }

        //Reglas de negocio Iperro

        public string Caminar(float distancia)
        {
            return "La distancia es : " + distancia;
        }

        public string Acostarse(float tiempo)
        {
            return "El tiempo es " + tiempo; 
        }

        public string Dormir(float descanso)
        {
            return "El descanso es: " + descanso;
        }
    }



}
