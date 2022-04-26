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
    public partial class Administracion : Form
    {
        public conexion _conecc = null;
        string _sId;
        DataTable dtDatos = null;

        public Administracion(conexion _conect1, string sId)
        {
            InitializeComponent();
            _conecc = _conect1;
            _sId = sId;
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
        private void Actualizar()
        {
            string aB = "select usuario.id as ID, usuario.usuario, usuario.password, usuario.estatus " + " from usuario";
            dtDatos = _conecc.llenarTablas(aB);
            dt_admin.DataSource = dtDatos;
        }
        private void Limpiar()
        {
            tb_pass.Clear();
            tb_usuario.Clear();
            lbl_id2.Text = "";
            tb_usuario.Focus();
        }
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand comando = null;
            try
            {
                string insertar = "insert into usuario(usuario, password, estatus)" +
                    "values (@usuario, @password, @estatus)";
                using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                {
                    MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                    agregar.Parameters.AddWithValue("@usuario", tb_usuario.Text);
                    agregar.Parameters.AddWithValue("@password", tb_pass.Text);

                    agregar.Parameters.AddWithValue("@estatus", 1);


                    _conecc.InsertCon(agregar);
                    MessageBox.Show("Información guardada correctamente", "Clientes");
                    Limpiar();
                }
                Actualizar();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
              MySql.Data.MySqlClient.MySqlCommand comando2 = null;
            try
            {
                string insertar = "delete from usuario where id='" + lbl_id2.Text + "' ";
                using (comando2 = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn));
                {
                    MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);
                    _conecc.InsertCon(agregar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Actualizar();
        }

        private void dt_admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = dt_admin.Rows[e.RowIndex].Cells[0].Value.ToString();
           

                lbl_id2.Text = dt_admin.CurrentRow.Cells[0].Value.ToString();
                tb_usuario.Text = dt_admin.CurrentRow.Cells[1].Value.ToString();
                tb_pass.Text = dt_admin.CurrentRow.Cells[2].Value.ToString();

            }
        }

        private void btn_estatus_Click(object sender, EventArgs e)
        {
            string eliminar = "update usuario set estatus='1' where id='" + lbl_id2.Text + "'";
            _conecc.Eliminar(eliminar);

            Limpiar();
            Actualizar();
        }

        private void btn_deshabilitar_Click(object sender, EventArgs e)
        {
            string eliminar = "update usuario set estatus='0' where id='" + lbl_id2.Text + "'";
            _conecc.Eliminar(eliminar);

            Limpiar();
            Actualizar();
        }
    }
}
