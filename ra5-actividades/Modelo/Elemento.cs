using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ra5_actividades
{
    public class Elemento
    {
        private int id;
        private String nombre;
        private string apllido;
        private int nivel;
        private double salario;

        public Elemento(int id, string nombre, string apllido, int nivel, double salario)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apllido = apllido;
            this.Nivel = nivel;
            this.Salario = salario;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apllido { get => apllido; set => apllido = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
