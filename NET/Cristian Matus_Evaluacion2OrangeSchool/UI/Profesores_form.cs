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
    public partial class Profesores_form : Form
    {
        public Profesores_form()
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumnos_form alum = new Alumnos_form();
            alum.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administradores_form admin = new Administradores_form();
            admin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_form men = new Menu_form();
            men.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string varNombre = NombrePro.Text;
            string varCur = cantCur.Text;
            int varCurso = Int32.Parse(varCur);
            string varHo =  CantHrs.Text;
            int varHoras = Int32.Parse(varHo);

            if ( varCurso <= 12)
            {
                if (varHoras <= 72)
                {
                    int SalarioFinal = varCurso * varHoras * 1000;

                    datosProfesor.Text = "Datos Docente: " + varNombre + "\r\n" + "El resultado es: " + varCurso * varHoras;

                    Resultado.Text = "Salario Final: $" + SalarioFinal;
                }

            }
            else
            {
                cantCur.Text = "Maximo 12 cursos";
                CantHrs.Text = "Maximo 72 horas";
                datosProfesor.Text = "Necesito solo dos caracteres o revise cantidad designada";
                Resultado.Text = "Excede el maximo designado";
            }

        }

        private void cantCur_TextChanged(object sender, EventArgs e)
        {
            cantCur.MaxLength = 2;
        }

        private void CantHrs_TextChanged(object sender, EventArgs e)
        {
            CantHrs.MaxLength = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_form logi = new Login_form();
            logi.Show();
        }
    }
}
