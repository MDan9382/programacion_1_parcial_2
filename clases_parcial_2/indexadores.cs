using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_parcial_2.clases_parcial_2
{
    internal class indexadores
    {
        private string[] estudiantes = new string[50];

        public string[] estudiante_pub
        {
            get { return estudiantes; } set { estudiantes = value; }
        }

        public string this[int i]
        {
            get => estudiantes[i]; set { estudiantes[i] = value; }
        }
    }

}
