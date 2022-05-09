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
    public partial class ActAdministrador_form : Form
    {
        public ActAdministrador_form()
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
            string varNombre = actUser.Text;
            string varApellido = actApe.Text;
            string varContraseña = actCont.Text;

            using (ColegioEntities1 col = new ColegioEntities1())
            {
                var query = (from a in col.Administradores
                             where a.nombre == varNombre
                             select a).First();

                query.nombre = varNombre;
                query.apellido = varApellido;
                query.contrasena = varContraseña;

                col.SaveChanges();
                this.Hide();
            }
        }
    }
}
