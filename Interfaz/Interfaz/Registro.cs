using AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Interfaz
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarClienteGrid();
        }

        private void CargarClienteGrid()
        {
            var db = new Clientes();
            dataGridView1.DataSource = db.Client.ToList(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                var db = new Clientes();
                var cliente = new Cliente { Nombre = textBox1.Text, Telefono = textBox2.Text };
                db.Client.Add(cliente);
                db.SaveChanges();
                CargarClienteGrid();
            }
            else MessageBox.Show("Ingrese un nombre y un numero de telefono","Error");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                

                var db = new Clientes();
                var usuario = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value;
                var cliente = db.Client.Find(usuario);
                db.Client.Remove(cliente);
                db.SaveChanges();
                CargarClienteGrid();

            }
            catch (Exception )
            {
                MessageBox.Show("Tiene que seleccionar un registro a eliminar", "Error");
            }

            }
            
            
    }
}
