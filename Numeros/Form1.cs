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

namespace Numeros
{
    public partial class Form1 : Form
    {
        Random rdn = new Random();

        int one = 0;
        int two = 0;
        int three = 0;
        int four = 0;
        int five = 0;
        int six = 0;
        int seven = 0;
        int eight = 0;
        int nine = 0;
        int ten = 12;

        public Form1()
        {
            InitializeComponent();
        }

        void Principal(int valor)
        {
            for (int i = 0; i < valor; i++)
            {
                box1.Text = one.ToString();
                box2.Text = two.ToString();
                box3.Text = three.ToString();
                box4.Text = four.ToString();
                box5.Text = five.ToString();
                box6.Text = six.ToString();
                box7.Text = seven.ToString();
                box8.Text = eight.ToString();
                box9.Text = nine.ToString();
                box10.Text = ten.ToString();

                int numeroSorteado = rdn.Next(1, 11);

                switch (numeroSorteado)
                {
                    case 1:
                        one++;
                        box1.Text = one.ToString();
                        break;

                    case 2:
                        two++;
                        box2.Text = two.ToString();
                        break;

                    case 3:
                        three++;
                        box3.Text = three.ToString();
                        break;

                    case 4:
                        four++;
                        box4.Text = four.ToString();
                        break;

                    case 5:
                        five++;
                        box5.Text = five.ToString();
                        break;

                    case 6:
                        six++;
                        box6.Text = six.ToString();
                        break;

                    case 7:
                        seven++;
                        box7.Text = seven.ToString();
                        break;

                    case 8:
                        eight++;
                        box8.Text = eight.ToString();
                        break;

                    case 9:
                        nine++;
                        box9.Text = nine.ToString();
                        break;

                    case 10:
                        ten++;
                        box10.Text = ten.ToString();
                        break;
                }
            }
        }
        void Start_Click(object sender, EventArgs e)
        {
            int valor = 0;
            if(checkBox1.Checked)
            {
                valor = 100;
            }
            if(checkBox2.Checked)
            {
                valor = 500;
            }
            if(checkBox3.Checked)
            {
                valor = 10000;
            }
            if(checkBox4.Checked)
            {
                valor = 20000;
            }
            Principal(valor);
        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }


        //Fazer o botao clear
        //Colocar qual textbox tem mais pontos
        //Colocar o contador
    }
}
