using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cristian_Matus_Evaluacion2OrangeSchool.UI
{
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administradores_form admin = new Administradores_form();
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumnos_form alum = new Alumnos_form();
            alum.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profesores_form pro = new Profesores_form();
            pro.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form logi = new Login_form();
            logi.Show();
        }
    }
}
