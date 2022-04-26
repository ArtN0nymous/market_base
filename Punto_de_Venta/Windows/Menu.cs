using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    public partial class Menu : Form
    {
        public conexion _conecc = null;
        DataTable dtDatos = null;

        public Menu(conexion _conect1)
        {
            InitializeComponent();
            _conecc = _conect1;
            


            if (_conecc.conectando() == false)
            {
                MessageBox.Show("conexion fallida", "ERROR");
                System.Environment.Exit(0);
            }
            else
            {
            }
            _conecc = _conect1;
            Actualizar();
        }
        private void Actualizar()
        {

        }
        public Menu()
        {
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            string aB = "select registro.id as ID, registro.nombre, registro.apellido, registro.direccion, registro.telefono,registro.total, registro.fecha " + " from registro";
            dtDatos = _conecc.llenarTablas(aB);
            dataGridView1.DataSource = dtDatos;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventas abrir = new ventas(_conecc, "0");
            abrir.Show();
        }

        private void ico_compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            compras abrir = new compras(_conecc, "0");
            abrir.Show();
        }

        private void ico_productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            productos abrir = new productos(_conecc, "0");
            abrir.Show();
        }

        private void ico_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes abrir = new clientes(_conecc, "0");
            abrir.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public byte[] imageToNyte(System.Drawing.Image imageIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        public Image ByteToImage(byte[] byteArrayIn)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returImage = Image.FromStream(ms);
            return returImage;
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerca_de abrir = new acerca_de();
            abrir.Show();
        }
    }
}
