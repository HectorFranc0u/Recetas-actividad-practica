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

        private string RecetaName;
        private int RecetaPrecio;
        private string Recetatipo;
        private string RecetaIngredientes;

        public string recetaautor { get; set; }

        //metodos de propiedad

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
    }
}
