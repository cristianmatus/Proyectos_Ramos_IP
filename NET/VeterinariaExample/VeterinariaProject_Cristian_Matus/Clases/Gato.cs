using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProject_Cristian_Matus.Clases
{
    //Gato hereda de animal
    class Gato : Animal
    {
        //Declaración
        private string nombre;
        private int canpatas;
        private string enfermedad;
        private bool urgencia;


        public Gato()
        {
            nombre = "Orión";
            canpatas = 4;
            enfermedad = "tumor";
            urgencia = true;
        }

        public Gato(string nombre, int canpatas, string enfermedad, bool urgencia)
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
    }
}
