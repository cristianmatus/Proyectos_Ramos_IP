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
    public partial class Administradores_form : Form
    {
        public Administradores_form()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_form menu = new Menu_form();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AñadAdmin_form añadim = new AñadAdmin_form();
            añadim.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (ColegioEntities1 col = new ColegioEntities1())
            {
                IQueryable<Administradores> admin = from i in col.Administradores
                                                    select i;

                List<Administradores> listado = admin.ToList();

                tablaDatos.DataSource = listado;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string dato = id.Text;
            int id_ingreso = Int32.Parse(dato);

            using (ColegioEntities1 col = new ColegioEntities1())
            {

                Administradores query = (from a in col.Administradores
                                         where a.id == id_ingreso
                                         select a).First();

                try
                {
                    col.Administradores.Remove(query);
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
            ActAdministrador_form actadm = new ActAdministrador_form();
            actadm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form logi = new Login_form();
            logi.Show();
        }
    }
}
