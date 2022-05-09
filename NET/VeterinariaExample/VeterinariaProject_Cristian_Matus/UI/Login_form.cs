using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinariaProject_Cristian_Matus.Clases;
using VeterinariaProject_Cristian_Matus.UI;

namespace VeterinariaProject_Cristian_Matus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Gato g = new Gato();
            string raza = g.getRaza(); //obtienes la raza
            g.setRaza("Albino"); //Modificas la raza

            texto1.text = "" + raza;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_form men = new Menu_form();
            men.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
