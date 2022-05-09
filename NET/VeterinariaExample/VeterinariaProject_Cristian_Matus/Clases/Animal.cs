using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaProject_Cristian_Matus.Clases
{
    class Animal
    {
        private int id;
        private string raza;
        private string color;
        private double altura;
        private double peso;

        public Animal()
        {
            id = 0;
            raza = "Pekines";
            color = "Cafe";
            altura = 1.20;
            peso = 23;
        }

        public Animal (int id, string raza, string color, double altura, double peso)
        {
            this.id = id;
            this.raza = raza;
            this.color = color;
            this.altura = altura;
            this.peso = peso;
        }

        public int getId()
        {
            return id;
        }

        public string getRaza()
        {
            return raza;
        }

        public string getColor()
        {
            return color;
        }

        public double getAltura()
        {
            return altura;
        }

        public double getPeso()
        {
            return peso;
        }


        public void setId(int id)
        {
            this.id = id;
        }

        public void setRaza (string raza)
        {
            this.raza = raza;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setAltura (double altura)
        {
            this.altura = altura;
        }

        public void setPeso (double peso)
        {
            this.peso = peso;
        }
    }

}
