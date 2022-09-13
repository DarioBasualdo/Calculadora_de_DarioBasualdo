using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class PonerNumeros
    {

        // esta clase pone los numeros en el txt_box


        // variable  principal 
        static public string escrito;
        static public string historial;


        public string borrar()
        {
            escrito = escrito.Substring(0, escrito.Length - 1);
            historial = historial.Substring(0, historial.Length - 1);
            return escrito;
        }
        public string poner_0()
        {
            historial = historial + 0;
            escrito = escrito + 0;

            return escrito;
        }

        public string poner_1()
        {
            historial = historial + 1;
            escrito = escrito + 1;

            return escrito;
        }
        public string poner_2()
        {
            historial = historial + 2;
            escrito = escrito + 2;

            return escrito;
        }

        public string poner_3()
        {
            historial = historial + 3;
            escrito = escrito + 3;

            return escrito;
        }
        public string poner_4()
        {
            historial = historial + 4;
            escrito = escrito + 4;

            return escrito;
        }

        public string poner_5()
        {
            historial = historial + 5;
            escrito = escrito + 5;

            return escrito;
        }
        public string poner_6()
        {
            historial = historial + 6;
            escrito = escrito + 6;

            return escrito;
        }

        public string poner_7()
        {
            historial = historial + 7;
            escrito = escrito + 7;

            return escrito;
        }
        public string poner_8()
        {
            historial = historial + 8;
            escrito = escrito + 8;

            return escrito;
        }

        public string poner_9()
        {
            historial = historial + 9;
            escrito = escrito + 9;

            return escrito;
        }




        // estas funciones ponen el string de cada operacion
        public string poner_suma()
        {
            historial = historial + " + ";


            return historial;
        }

        public string poner_resta()
        {
            historial = historial + " - ";


            return historial;
        }

        public string poner_division()
        {
            historial = historial + " / ";


            return historial;
        }

        public string poner_multiplicacion()
        {
            historial = historial + " * ";


            return historial;
        }


        // esta funcion pone la variable escrito y historial en null 

        public string escrito_vacio()
        {
            escrito = "";
            return escrito;
        }

        public string historial_vacio()
        {
            historial = "";
            return historial;
        }

    }

}
