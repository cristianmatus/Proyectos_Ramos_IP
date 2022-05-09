using Cristian_Matus_Evaluacion2OrangeSchool.UI;
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

namespace Cristian_Matus_Evaluacion2OrangeSchool
{
    public partial class Login_form : Form
    {
        public Login_form()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AñadAdministrador_form añadm = new AñadAdministrador_form();
            añadm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (ColegioEntities1 col = new ColegioEntities1())
            {
                var admin = from i in col.Administradores
                            where i.nombre == user.Text &&
                                  i.contrasena == cont.Text
                            select i;

                if (admin.Count() > 0)
                {
                    this.Hide();
                    Menu_form menu = new Menu_form();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("No existe cohincidencia");
                }
            }
        }
    }
}
