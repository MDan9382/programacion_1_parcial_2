using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_parcial_2.clases_parcial_2
{
    public class tienda_de_discos
    {
        private string titulo;
        private int duracion; // en segundos
        private string descripcion;

        public string titulo_pub
        {
            get { return titulo; } set { titulo = value;}
        }

        public int duracion_pub
        {
            get { return duracion; } set { duracion = value; }
        }



        public string descripcion_pub
        {
            get { return descripcion; } set { descripcion = value; }
        }

        public virtual void mostrardatos()
        {
            
        }
    }
    
}
