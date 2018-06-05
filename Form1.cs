using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCalificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGraficar_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            txtCalificaciones.Clear();
            for (int alumno =1;alumno<=10;alumno++) {
                int calificacion = objRandom.Next(1, 11);
                txtCalificaciones.AppendText("Alumno "+alumno+"   \tCalificacion: "+calificacion+"\n");
                
            }
            
        }
    }
}
