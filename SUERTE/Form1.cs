using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SUERTE
{
    public partial class Form1 : Form
    {
        int primero, segundo, tercero;
        public Form1()
        {
            InitializeComponent();
        }
        public void primerosacar()
        {
            Random primernumero = new Random();
            primero = primernumero.Next(0, 10);
        }
        public void segundosacar()
        {
            Random segundonumero = new Random();
            segundo = segundonumero.Next(0, 2);
        }
        public void tercerosacar()
        {
            Random terceronumero = new Random();
            tercero = terceronumero.Next(0, 100);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            textBoxResultado.Visible = false;
            labelPrimero.Visible = true;
            labelSegundo.Visible = true;
            labelSigno.Visible = true;
            primerosacar();
            segundosacar();
            tercerosacar();
            animacionGeneral();
            button1.Visible = true;
            textBoxResultado.Visible = true;
            labelPrimero.Visible = false;
            labelSegundo.Visible = false;
            labelSigno.Visible = false;
            if ((tercero % 2) == 0)
                textBoxResultado.Text = "TU ULTIMO RESULTADO ES: \n" + "+" + segundo + "" + primero;
            else
                textBoxResultado.Text = "TU ULTIMO RESULTADO ES: \n" + "-" + segundo + "" + primero;

        }
        public void animacionGeneral()
        {

            int cont = 0;

            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(i + 100);
                if (cont == 0)
                {
                    if(i <45)
                        labelPrimero.Text = "0";
                    if (i < 75)
                        labelSegundo.Text = "0";
                    if (i < 100)
                        labelSigno.Text = "+";
                    cont++;
                }
                else if (cont == 1)
                {
                    if (i < 45)
                        labelPrimero.Text = "1";
                    if (i < 75)
                        labelSegundo.Text = "1";
                    if (i < 100)
                        labelSigno.Text = "-";
                    cont++;
                }
                else if (cont == 2)
                {
                    if (i < 45)
                        labelPrimero.Text = "2";
                    if (i < 75)
                        labelSegundo.Text = "0";
                    if (i < 100)
                        labelSigno.Text = "+";
                    cont++;
                }
                else if (cont == 3)
                {
                    if (i < 45)
                        labelPrimero.Text = "3";
                    if (i < 75)
                        labelSegundo.Text = "1";
                    if (i < 100)
                        labelSigno.Text = "-";
                    cont++;
                }
                else if (cont == 4)
                {
                    if (i < 45)
                        labelPrimero.Text = "4";
                    if (i < 75)
                        labelSegundo.Text = "0";
                    if (i < 100)
                        labelSigno.Text = "+";
                    cont++;
                }
                else if (cont == 5)
                {
                    if (i < 45)
                        labelPrimero.Text = "5";
                    if (i < 75)
                        labelSegundo.Text = "1";
                    if (i < 100)
                        labelSigno.Text = "-";
                    cont++;
                }
                else if (cont == 6)
                {
                    if (i < 45)
                        labelPrimero.Text = "6";
                    if (i < 75)
                        labelSegundo.Text = "0";
                    if (i < 100)
                        labelSigno.Text = "+";
                    cont++;
                }
                else if (cont == 7)
                {
                    if (i < 45)
                        labelPrimero.Text = "7";
                    if (i < 75)
                        labelSegundo.Text = "1";
                    if (i < 100)
                        labelSigno.Text = "-";
                    cont++;
                }
                else if (cont == 8)
                {
                    if (i < 45)
                        labelPrimero.Text = "8";
                    if (i < 75)
                        labelSegundo.Text = "0";
                    if (i < 100)
                        labelSigno.Text = "+";
                    cont++;
                }
                else if (cont == 9)
                {
                    if (i < 45)
                        labelPrimero.Text = "9";
                    if (i < 75)
                        labelSegundo.Text = "1";
                    if (i < 100)
                        labelSigno.Text = "-";
                    cont = 0;
                }
                labelPrimero.Refresh();
                labelSegundo.Refresh();
                labelSigno.Refresh();
                if (i == 45)
                {
                    labelPrimero.Text = primero.ToString();
                    labelPrimero.Refresh();
                }
                else if (i == 75) 
                {
                    labelSegundo.Text = segundo.ToString();
                    labelSegundo.Refresh();
                }
                else if (i == 100)
                {
                    if ((tercero % 2) == 0)
                        labelSigno.Text = "+";
                    else
                        labelSigno.Text = "-";
                    labelSigno.Refresh();
                }
            }
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(i + 100);
            }
        }
    }
}
