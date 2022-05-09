using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeterinariaProject_Cristian_Matus.UI
{
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuarios_form user = new Usuarios_form();
            user.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animales_form anim = new Animales_form();
            anim.Show();
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {

        }
    }
}
