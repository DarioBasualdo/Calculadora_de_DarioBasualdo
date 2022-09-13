using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackEnd;



namespace FronEnd
{
    public partial class Calculadora : Form
    {
        //variable principales
            public int  numero1;
            public int  numero2;
            public int  resultado;

        //variable para el switch 
            public int opcion;
       


        operaciones opera = new operaciones();
        PonerNumeros poner_barra = new PonerNumeros();


        public Calculadora()
        {
            InitializeComponent();

        }

        // pone los numeros en el txt_box
        private void btborrar_Click(object sender, EventArgs e)
        {
                    
            txtmostrar.Text = poner_barra.borrar();
            
        }
        private void bt0_Click(object sender, EventArgs e)
        {


            txtmostrar.Text = poner_barra.poner_0();

        }
        private void bt1_Click(object sender, EventArgs e)
        {
            
            txtmostrar.Text = poner_barra.poner_1();

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            
            txtmostrar.Text = poner_barra.poner_2();

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = poner_barra.poner_3();

        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = poner_barra.poner_4();

        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = poner_barra.poner_5();
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = poner_barra.poner_6();
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = poner_barra.poner_7();
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = poner_barra.poner_8();
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtmostrar.Text = poner_barra.poner_9();
        }



        // operaciones matematicas
        private void btsumar_Click(object sender, EventArgs e)
        {
            
            lbmostrar_c.Text = poner_barra.poner_suma();

            opcion = 4;
            numero1 = System.Convert.ToInt32(PonerNumeros.escrito);
            txtmostrar.Text = poner_barra.escrito_vacio();
        }

        private void btrestar_Click(object sender, EventArgs e)
        {
            lbmostrar_c.Text = poner_barra.poner_resta();

            opcion = 3;
            numero1 = System.Convert.ToInt32(PonerNumeros.escrito);
            txtmostrar.Text = poner_barra.escrito_vacio();
        }

        private void btdividir_Click(object sender, EventArgs e)
        {
            
            lbmostrar_c.Text = poner_barra.poner_division();

            opcion = 2;
            numero1 = System.Convert.ToInt32(PonerNumeros.escrito);
            txtmostrar.Text = poner_barra.escrito_vacio();



        }

        private void btmultiplicar_Click(object sender, EventArgs e)
        {
            
            lbmostrar_c.Text = poner_barra.poner_multiplicacion();

            opcion = 1;
            numero1 = System.Convert.ToInt32(PonerNumeros.escrito);
            txtmostrar.Text = poner_barra.escrito_vacio();


        }

        private void btigual_Click(object sender, EventArgs e)
        {


            numero2 = System.Convert.ToInt32(PonerNumeros.escrito);
            txtmostrar.Text = poner_barra.escrito_vacio();


            switch (opcion){

                case 1:
                    resultado = opera.multiplicados(numero1, numero2);


                    break;
                case 2:
                    resultado = opera.dividedos(numero1, numero2);

                    break;
                case 3:
                    resultado = opera.restados(numero1, numero2);

                    break;
                case 4:
                   resultado = opera.sumados(numero1, numero2);
                   

                    break;
            }
            
            txtmostrar.Text = System.Convert.ToString(resultado);
            lbmostrar_c.Text = PonerNumeros.historial + " = " + System.Convert.ToString(resultado);
            poner_barra.historial_vacio();
        }

        // timer1 va a funcionar como la estructura de repeticion
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lb_bienvenido.BackColor == Color.Black)
            {
                lb_bienvenido.BackColor = Color.White;
                Refresh();
            }
            else if (lb_bienvenido.BackColor == Color.White)
            {
                lb_bienvenido.BackColor = Color.Black;
                Refresh();
            }
            

        }

        private void Calculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false; 
        }
    }
}
