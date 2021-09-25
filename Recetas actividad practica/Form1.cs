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
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Nombre de la receta");
            dt.Columns.Add("Precio de la receta");
            dt.Columns.Add("Tipo de la receta");
            dt.Columns.Add("Igredientes de la receta");
            dt.Columns.Add("Autor de la receta");
            dgvrecetas.DataSource = dt;
            //Recetas object1 = new Recetas("pastel de papaya", 5, "postre", "Papaya, leche, huevos, harina, azucar.", "chef arturo.");
            //Recetas object2 = new Recetas("carne con papas", 7, "almuerzo", "carne, papas, tomate, pimientos, especias.", "chef maira.");

            //MessageBox.Show(object1.getRecetaName() + object1.getRecetaPrecio().ToString() + object1.getrecetatipo() + object1.getrecetaingredientes() + object1.Recetaautor);

            //receta.setRecetaName("pastel");
            //receta.setRecetaPrecio(4);
            //receta.setRecetaTipo("postre");
            //receta.setrecetaingredientes("harina, huevos, leche, azucar");

            //MessageBox.Show(receta.getRecetaName() + receta.getrecetatipo() + receta.getrecetaingredientes() + receta.getRecetaPrecio());

            //receta.recetaautor = "mama pastelera";

            //MessageBox.Show(receta.recetaautor);
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            fillbutton();
        }

        private void fillbutton()
        {


            Recetas receta = new Recetas();
            receta.Recetaname = txtbname.Text;
            receta.Recetaprecio = txbprecio.Text;
            receta.Recetatipo = txbtipo.Text;
            receta.Recetaingredientes = txbingredientes.Text;
            receta.Recetaautor = txbautor.Text;

            DataRow row = dt.NewRow();

            row["Nombre de la receta"] = receta.Recetaname;
            row["Precio de la receta"] = receta.Recetaprecio;
            row["Tipo de la receta"] = receta.Recetatipo;
            row["Igredientes de la receta"] = receta.Recetaingredientes;
            row["Autor de la receta"] = receta.Recetaautor;
            dt.Rows.Add(row);

            txtbname.Text = "";
            txbautor.Text = "";
            txbprecio.Text = "";
            txbtipo.Text = "";
            txbingredientes.Text = "";
        }

    }
}
