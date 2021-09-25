using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recetas_actividad_practica
{
    class Recetas
    {
        //definir miembros de la calse
        // propiedades - atributos - datos
        /*
        private string RecetaName;
        private int RecetaPrecio;
        private string Recetatipo;
        private string RecetaIngredientes;
        */

        public string Recetaname { get; set; }
        public string Recetaprecio { get; set; }
        public string Recetatipo { get; set; }
        public string Recetaingredientes { get; set; }
        public string Recetaautor { get; set; }

        //metodos de propiedad

        //metodo constructor
        /*
        public Recetas(string recname, int recprecio, string rectipo, string recingredientes, string recautor)
        {
            RecetaName = recname;
            RecetaPrecio = recprecio;
            Recetatipo = rectipo;
            RecetaIngredientes = recingredientes;
            Recetaautor = recautor;
        }
        */
        /*
        public void setRecetaName(string RName)
        {
            RecetaName = RName;
        }

        public string getRecetaName()
        {
            return RecetaName;
        }

        public void setRecetaPrecio(int Rprecio)
        {
            RecetaPrecio = Rprecio;
        }

        public int getRecetaPrecio()
        {
            return RecetaPrecio;
        }

        public void setRecetaTipo(string rtipo)
        {
            Recetatipo = rtipo;
        }
        public string getrecetatipo()
        {
            return Recetatipo;
        }

        public void setrecetaingredientes(string Ringredientes)
        {
            RecetaIngredientes = Ringredientes;
        }
        public string getrecetaingredientes()
        {
            return RecetaIngredientes;
        }
        */
    }
}
