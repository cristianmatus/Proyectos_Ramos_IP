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
    public partial class AñadAdmin_form : Form
    {
        public AñadAdmin_form()
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
            using (ColegioEntities1 col = new ColegioEntities1())
            {
                Administradores admin = new Administradores
                {
                    nombre = ingreUseri.Text,
                    apellido = ingreApei.Text,
                    contrasena = ingreConi.Text
                };

                col.Administradores.Add(admin);
                col.SaveChanges();

                MessageBox.Show("Se ha ingresado con exito a la Base de Datos");

                this.Hide();
                Administradores_form admi = new Administradores_form();
                admi.Show();
            }
        }
    }
}
