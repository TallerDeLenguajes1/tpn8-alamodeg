using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Calculadora
    {
        private float numero1;
        private float numero2;

        //getters & setter para acceder a los elementos privados
        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        //metodos
        public float Sumar()
        {
            return numero1 + numero2;
        }
        public float Restar()
        {
            return numero1 - numero2;
        }
        public float Multiplicar()
        {
            return numero1 + numero2;
        }
        public float Dividir()
        {
            return numero1 / numero2;
        }
    }
}
