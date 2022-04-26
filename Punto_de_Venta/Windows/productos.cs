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
    public partial class productos : Form
    {
        public conexion _conecc = null;
        string _sId;

        DataTable dtDatos = null;
        public productos(conexion _conect1, string sId)
        {
            InitializeComponent();
            _conecc = _conect1;
            _sId = sId;

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerca_de abrir = new acerca_de();
            abrir.Show();
        }

        private void bar_btn_ventas_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventas abrir = new ventas(_conecc, "0");
            abrir.Show();
        }

        private void bar_btn_compras_Click(object sender, EventArgs e)
        {
            this.Hide();
            compras abrir = new compras(_conecc, "0");
            abrir.Show();
        }

        private void bar_btn_productos_Click(object sender, EventArgs e)
        {

        }

        private void bar_btn_clientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            clientes abrir = new clientes(_conecc, "0");
            abrir.Show();
        }

        private void productos_Load(object sender, EventArgs e)
        {
            Actualizar();
            LoadCombo();
            rbtn_nombre.Checked = true;
        }
       
        private void Limpiar()
        {
            tbcodigo.Clear();
            tbdescripcion.Clear();
            tbprecio_unidad.Clear();
            tbprecio_mayoreo.Clear();
            txtid.Text= "";
        }   

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (tbcodigo.Text == "")
            {
                MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (tbdescripcion.Text == "")
                {
                    MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (tbprecio_unidad.Text == "")
                    {
                        MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if ( tbprecio_mayoreo.Text == "")
                        {
                            MessageBox.Show("Por favor llene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else //si se cumplen las condiciones anteriores realiza una consulta                       
                        {
                            MySql.Data.MySqlClient.MySqlCommand comando = null;
                            try
                            {
                                string insertar = "insert into producto(codigo, descripcion, precio_unidad, precio_mayoreo,departamento, categoria, estatus)" +
                                    "values (@codigo, @descripcion, @precio_unidad, @precio_mayoreo, @departamento, @categoria, @estatus)";
                                using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                                {
                                    MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                                    agregar.Parameters.AddWithValue("@codigo", tbcodigo.Text);
                                    agregar.Parameters.AddWithValue("@descripcion", tbdescripcion.Text);
                                    agregar.Parameters.AddWithValue("@precio_unidad", tbprecio_unidad.Text);
                                    agregar.Parameters.AddWithValue("@precio_mayoreo", tbprecio_mayoreo.Text);
                                    agregar.Parameters.AddWithValue("@categoria", tb_categoria.Text);
                                    agregar.Parameters.AddWithValue("@departamento", tb_departamento.Text);
                                    agregar.Parameters.AddWithValue("@estatus", 1);


                                    _conecc.InsertCon(agregar);
                                    MessageBox.Show("Producto nuevo guardado correctamente", "Productos");
                                    Limpiar();
                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                    }
                }
            }
          

            Actualizar();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Actualizar()
        {
            string aC = "select producto.id as ID, producto.codigo, producto.descripcion, producto.precio_unidad, producto.precio_mayoreo, producto.departamento, producto.categoria, producto.estatus " + "from producto";
            dtDatos = _conecc.llenarTablas(aC);
            dt_producto1.DataSource = dtDatos;
        }

        private void lblbuscar_Click(object sender, EventArgs e)
        {

        }
        public void LoadCombo()
        {
            _conecc.Combodepartamento("departamentos", "", ref tb_departamento);
            _conecc.ComboCategoria("categorias", "", ref tb_categoria);

        }

        private void tbbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
     
        }

        private void tbbuscar_Click(object sender, EventArgs e)
        {

        }

        private void dt_producto1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string modificar = "update producto set codigo=" + tbcodigo.Text + "',descripcion='" + tbdescripcion.Text + "',precio_unidad='" + tbprecio_unidad.Text + "',precio_mayoreo='" + tbprecio_mayoreo.Text + "',departamento='" + tb_departamento.Text + "',categoria='" + tb_categoria.Text +
                " where id='" + txtid.Text + "'";
            _conecc.Modificar(modificar);

            Limpiar();
            Actualizar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_departamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dt_producto1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = dt_producto1.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtid.Text = dt_producto1.CurrentRow.Cells[0].Value.ToString();
                tbcodigo.Text = dt_producto1.CurrentRow.Cells[1].Value.ToString();
                tbdescripcion.Text = dt_producto1.CurrentRow.Cells[2].Value.ToString();
                tbprecio_unidad.Text = dt_producto1.CurrentRow.Cells[3].Value.ToString();
                tbprecio_mayoreo.Text = dt_producto1.CurrentRow.Cells[4].Value.ToString();
                tb_departamento.Text = dt_producto1.CurrentRow.Cells[5].Value.ToString();
                tb_categoria.Text = dt_producto1.CurrentRow.Cells[6].Value.ToString();
                Actualizar();
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand comando2 = null;
            try
            {
                string insertar = "delete from producto where id='" + txtid.Text + "' ";
                using (comando2 = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn)) ;
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

        private void disponible_Click(object sender, EventArgs e)
        {
            string eliminar = "update producto set estatus='1' where id='" + txtid.Text + "'";
            _conecc.Eliminar(eliminar);

            Limpiar();
            Actualizar();
        }

        private void no_disponible_Click_1(object sender, EventArgs e)
        {
            string eliminar = "update producto set estatus='0' where id='" + txtid.Text + "'";
            _conecc.Eliminar(eliminar);

            Limpiar();
            Actualizar();
        }

        private void tbbuscar_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            string sC;
            string sAux;
            string swhere = "";

            sAux = tbbuscar.Text + e.KeyChar;
            if (rbtn_nombre.Checked == true)
            {
                swhere = " Where producto.descripcion Like '%" + sAux + "%' ";

            }
            if (rbtn_codigo.Checked == true)
            {
                swhere = " Where producto.codigo Like '%" + sAux + "%' ";

            }
            if (sAux.Trim() == null || e.KeyChar == 8)
            {
                sC = " select producto.id as ID, producto.codigo, producto.descripcion, producto.precio_unidad, producto.precio_mayoreo, producto.departamento, producto.categoria, producto.estatus " + "from producto";
            }
            else
            {
                sC = " select producto.id as ID, producto.codigo, producto.descripcion, producto.precio_unidad, producto.precio_mayoreo, producto.departamento, producto.categoria, producto.estatus " + "from producto" + swhere;
            }
            dtDatos = _conecc.llenarTablas(sC);
            dt_producto1.DataSource = dtDatos;
        }

        private void tbcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbprecio_mayoreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
