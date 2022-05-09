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
    public partial class Alumnos_form : Form
    {
        public Alumnos_form()
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
            Administradores_form admin = new Administradores_form();
            admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profesores_form pro = new Profesores_form();
            pro.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_form men = new Menu_form();
            men.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            AñadAlumno_form añalum = new AñadAlumno_form();
            añalum.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (ColegioEntities1 col = new ColegioEntities1())
            {
                IQueryable<Alumnos> alum = from al in col.Alumnos
                                           select al;

                List<Alumnos> listadoAlu = alum.ToList();

                tablaDatosAlum.DataSource = listadoAlu;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string datoAlum = idAlum.Text;
            int id_Alum = Int32.Parse(datoAlum);

            using (ColegioEntities1 col = new ColegioEntities1())
            {

                Alumnos query = (from al in col.Alumnos
                                 where al.id == id_Alum
                                 select al).First();

                try
                {
                    col.Alumnos.Remove(query);
                    col.SaveChanges();
                    MessageBox.Show("Dato Eliminado");
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Ha fallado: " + Ex);
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ModAlumno_form modalum = new ModAlumno_form();
            modalum.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form logi = new Login_form();
            logi.Show();
        }
    }
}
