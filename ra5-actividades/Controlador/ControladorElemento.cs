using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ra5_actividades.Controlador
{
    internal class ControladorElemento
    {
        public static List<Elemento> lista = new List<Elemento>();
        public static void cargar()
        {
            lista.Add(new Elemento(1, "Marcos", "Bermejo", 3000, 2000));
            lista.Add(new Elemento(2, "Sara", "Bermejo", 2000, 1000));
            lista.Add(new Elemento(3, "Noa", "Diaz", 1000, 3000));
        }
    }
}
