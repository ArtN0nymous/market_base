using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Punto_de_Venta
{
    public partial class login : Form
    {

        int contador = 0;
        DataTable dtDatos = new DataTable();
        public conexion conect1 = new conexion();

        public login()
        {
            InitializeComponent();
            conect1.conectando();
        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

      

        private void btnlogin_Click(object sender, EventArgs e)
        {
            Registro();
        }
        public void Registro()
        {
            if (combousuario.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show("Llene los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
            }
            else
            {
                MySqlCommand consultar = new MySqlCommand("select * from usuario where usuario='" + combousuario.Text + "'and password ='" + txtpassword.Text + "'", conect1.conn);
                MySqlDataReader Ejecuta = consultar.ExecuteReader();


                if (Ejecuta.Read() == true)
                {
                    MessageBox.Show("Bienvenido " + combousuario.Text, "Market Base", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.Hide();

                            Menu abrir = new Menu(conect1);
                    abrir.Show();
                }
                else
                {
                    MessageBox.Show(" Usuario o contraseña incorrecto", "intente de nuevo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtpassword.Clear();
                    combousuario.Text = "";
                    txtpassword.Focus();
                    contador = contador + 1;


                }
                if (contador >= 3)
                {
                    MessageBox.Show("!ERROR DE USUARIO O CONTRASEÑA, DEMACIADOS INTENTOS...CERRANDO!", "AVISO");
                    Application.Exit();
                }
                Ejecuta.Close();
            }
        }
        public void LlenarCombo()
        {
            conect1.getCombo("usuario", "", ref combousuario);
        }

        private void login_Load(object sender, EventArgs e)
        {
            LlenarCombo();
        }
    }
}

