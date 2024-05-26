using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasView
{
    public partial class Form1 : Form
    {
        int total = 0; //cantidad de elementos en cola
        Random numeros = new Random(); //los valores seran random
        public Form1()
        {
            InitializeComponent();
            txttotal.Text = Convert.ToString(total); //en textbox superior se mostrara el conteo de total
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (total == 5)
            { MessageBox.Show("La cola esa llena");
            } 
            else
            {
                total++; //incrementamos cantidad de elementos en cola
                txttotal.Text = Convert.ToString(total);

                switch(total) //dependiendo de cuantos numeros hay en cola
                {
                    case 1: 
                        textBox2.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox2.Visible = true;
                        break;

                    case 2:
                        textBox3.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox3.Visible = true;
                        break;

                    case 3:
                        textBox4.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox4.Visible = true;
                        break;

                    case 4:
                        textBox5.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox5.Visible = true;
                        break;

                    case 5:
                        textBox6.Text = Convert.ToString(numeros.Next(1, 99));
                        textBox6.Visible = true;
                        break;

                    default:
                        MessageBox.Show("Error en al cola");
                        break;
                }
                timer1.Enabled = true;
            }
        }

        private void btnextraer_Click(object sender, EventArgs e)
        {
            if (total == 0)
            { 
                MessageBox.Show("Cola vacia, no puede eliminar datos"); 
            }
            else
            {//en realidad pasamos la informacion de un cuadro a otro
                textBox2.Text = textBox3.Text;
                textBox3.Text = textBox4.Text;
                textBox4.Text = textBox5.Text;
                textBox5.Text = textBox6.Text;

                //descartamos los nodos que no usamos, los dejamos no visibles
                if (total == 1) textBox2.Visible = false;
                if (total == 2) textBox3.Visible = false;
                if (total == 3) textBox4.Visible = false;
                if (total == 4) textBox5.Visible = false;
                if (total == 5) textBox6.Visible = false;
                total--;
                txttotal.Text = Convert.ToString(total);
                timer2.Enabled = true;                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btningresar.Enabled = false; //deshabilitamos boton ingresar

            if (total == 1) 
            {
                pictureBox1.Left = pictureBox1.Left + 5; //hacemos que se desplace de 5 en 5
                if (pictureBox1.Left >= 300) timer1.Enabled = false; //detenemos el timer cuando llegue a 300
            }
            if (total == 2)
            {
                pictureBox2.Left = pictureBox2.Left + 5;
                if (pictureBox2.Left >= 250) timer1.Enabled = false; //detenemos el timer cuando llegue a 250
            }
            if (total == 3)
            {
                pictureBox3.Left = pictureBox3.Left + 5;
                if (pictureBox3.Left >= 200) timer1.Enabled = false; //detenemos el timer cuando llegue a 200
            }
            if (total == 4)
            {
                pictureBox4.Left = pictureBox4.Left + 5;
                if (pictureBox4.Left >= 150) timer1.Enabled = false; //detenemos el timer cuando llegue a 150
            }
            if (total == 5)
            {
                pictureBox5.Left = pictureBox5.Left + 5;
                if (pictureBox5.Left >= 100) timer1.Enabled = false; //detenemos el timer cuando llegue a 100
            }
            if (timer1.Enabled == false) btningresar.Enabled = true; //timer apagado, enciende boton
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            btnextraer.Enabled = false; //deshabilitamos boton extraer
            pictureBox1.Left = pictureBox1.Left + 5; //movemos imagen a la derecha
            if (pictureBox1.Left >=600)
            {
                pictureBox1.Left = 300; //regresamos el primer picturebox a la primera posicion
                if (total == 4) pictureBox5.Left = -50; //escondo el picturebox 5
                if (total == 3) pictureBox4.Left = -50; //escondo el picturebox 4
                if (total == 2) pictureBox3.Left = -50; //escondo el picturebox 3
                if (total == 1) pictureBox2.Left = -50; //escondo el picturebox 2
                if (total == 0) pictureBox1.Left = -50; //escondo el picturebox 1
                timer2.Enabled = false; //detenemos el timer
            }
            if (timer2.Enabled == false) btnextraer.Enabled = true; //habilito boton de nuevo
        }
    }
}
