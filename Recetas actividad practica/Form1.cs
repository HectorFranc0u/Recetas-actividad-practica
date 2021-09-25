using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recetas_actividad_practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Recetas receta = new Recetas();
            receta.setRecetaName("pastel");
            receta.setRecetaPrecio(4);
            receta.setRecetaTipo("postre");
            receta.setrecetaingredientes("harina, huevos, leche, azucar");

            MessageBox.Show(receta.getRecetaName() + receta.getrecetatipo() + receta.getrecetaingredientes() + receta.getRecetaPrecio());

            receta.recetaautor = "mama pastelera";

            MessageBox.Show(receta.recetaautor);
        }
    }
}
