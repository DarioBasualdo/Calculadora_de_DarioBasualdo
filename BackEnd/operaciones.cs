using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{

    public class operaciones
    {

        // esta clase hace las operaciones matematicas
        // y lleva un historial de los numeros
        public int sumados(int num1, int num2)
        {

            int resultado1;
            resultado1 = num1 + num2;

            return resultado1;
        }

        public int restados(int num1, int num2)
        {

            int resultado1;
            resultado1 = num1 - num2;

            return resultado1;
        }


        public int dividedos(int num1, int num2)
        {

            int resultado1;
            resultado1 = num1 / num2;

            return resultado1;
        }

        public int multiplicados(int num1, int num2)
        {

            int resultado1;
            resultado1 = num1 * num2;

            return resultado1;
        }
    }
}
