using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacion_1_parcial_2
{
    internal class interfaces_ejemplos
    {
    }
    interface Iimprimir
    {
        void imprimir();
    }
    interface Iescanear
    {
        void escanear();
    }
    class fax : Iimprimir
    {
        public void imprimir()
        {
            Console.WriteLine("imprimiendo datos recividos");
        }
    }
    class escaner : Iescanear
    {
        public void escanear()
        {
            Console.WriteLine("los datos han sido escaneados");
        }
    }
    class fotocopiadora : Iescanear, Iimprimir
    {
        public void escanear()
        {
            Console.WriteLine("escaneando datos");
        }
        public void imprimir()
        {
            Console.WriteLine("imprimiendo los datos escaneados");
        }
    }
}
