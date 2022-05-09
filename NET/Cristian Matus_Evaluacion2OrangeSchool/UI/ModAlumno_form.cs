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
    public partial class ModAlumno_form : Form
    {
        public ModAlumno_form()
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
            string idDato = idAlum.Text;
            int id_Alumno = Int32.Parse(idDato);

            string varNomAlum = modNom.Text;
            string varApeAlum = modApe.Text;
            string varEdAlum = modEd.Text;
            string varEsAlum = modEst.Text;
            string varSitAlum = modSit.Text;

            using (ColegioEntities1 col = new ColegioEntities1())
            {
                var query = (from mod in col.Alumnos
                             where mod.id == id_Alumno
                             select mod).First();

                query.nombre = varNomAlum;
                query.apellido = varApeAlum;
                query.edad = varEdAlum;
                query.estado = varEsAlum;
                query.situacion = varSitAlum;

                col.SaveChanges();
                this.Hide();
                Alumnos_form alum = new Alumnos_form();
                alum.Show();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
