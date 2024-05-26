using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasView2
{
    public partial class Form1 : Form
    {
        Queue<Empleados> Trabajadores = new Queue<Empleados>();
        //creamos objeto de la clase cola, del tipo de la clase empleado (lo que almacena son objetos)
        public Form1()
        {
            InitializeComponent();   
        }

        private void salarioLbl_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void registrarBtn_Click(object sender, EventArgs e)
        {
            Empleados empleado = new Empleados(); //creamos instancia de la clase empleado
            //capturamos los datos del empleado
            empleado.Carnet = carnetTxt.Text;
            empleado.Nombre = nombreTxt.Text;
            empleado.Salario = Decimal.Parse(salarioTxt.Text);
            empleado.Fecha = fechaDateTimePicker.Value;
            Trabajadores.Enqueue(empleado); //llamamos al metodo encolar para meter a la estructura.
            dataGridView1.DataSource = null; //iniciamos el datagridview con null
            dataGridView1.DataSource = Trabajadores.ToArray(); //para pasarlo al dgv convertimos la cola en arreglo
            Limpiar(); //se limpian los textbox
            carnetTxt.Focus(); //se pone el foco en el primer textbox
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (Trabajadores.Count != 0) //mientras haya trabajadores en la cola
            {
                Empleados empleado = new Empleados(); //instanciamos la clase empleado
                /*este objeto se usa para poder recuperar los datos y mostrarlos en los textbox
                 al momento de ser eliminados de la cola*/
                empleado = Trabajadores.Dequeue(); //llamamos al metodo desencolar
                //colocamos los datos en los textbox
                carnetTxt.Text = empleado.Carnet;
                nombreTxt.Text = empleado.Nombre;
                salarioTxt.Text = empleado.Salario.ToString();
                fechaDateTimePicker.Value = empleado.Fecha;
                //la estructura convertida en lista se le pasa al dgv (ahora tiene un empleado menos)
                dataGridView1.DataSource = Trabajadores.ToList();
                MessageBox.Show("Se elimino el registro en cola", "AVISO");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No hay empleados en cola", "AVISO");
                Limpiar();
            }
            carnetTxt.Focus();
        }

        public void Limpiar()
        {
            carnetTxt.Clear();
            nombreTxt.Clear();
            salarioTxt.Clear();
            fechaDateTimePicker.Value = DateTime.Now;
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); //salir de la aplicacion
        }
    }
}
