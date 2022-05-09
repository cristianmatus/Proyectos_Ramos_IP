using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cristian_Matus_Evaluacion2OrangeSchool.UI
{
    public partial class AñadAlumno_form : Form
    {
        public AñadAlumno_form()
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
                Alumnos alum = new Alumnos
                {
                    nombre = nomAlum.Text,
                    apellido = apeAlum.Text,
                    edad = edadAlum.Text,
                    estado = estAl.Text,
                    situacion = sitAl.Text
                };

                col.Alumnos.Add(alum);
                col.SaveChanges();

                MessageBox.Show("Alumno agregado exitosamente");

                this.Hide();
                Alumnos_form alumn = new Alumnos_form();
                alumn.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void estAlum_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
