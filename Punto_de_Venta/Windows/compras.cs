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
    public partial class compras : Form
    {
        public conexion _conecc = null;
        string _sId;

        DataTable dtDatos = null;
        //Conexion con la base de datos

        public compras(conexion _conect1, string sId)
        {
            InitializeComponent();
            _conecc = _conect1;
            _sId = sId;
           
        }
        private void compras_Load(object sender, EventArgs e)
        {
            Actualizar();
            lbl_listo.Visible = true;
            rbtn_nombre.Checked = true;
            rbtnpor_unidad.Checked = true;  
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
            //Actualizar();
        }

        private void bar_btn_productos_Click(object sender, EventArgs e)
        {
            this.Hide();
            productos abrir = new productos(_conecc, "0");
            abrir.Show();
        }

        private void bar_btn_clientes_Click(object sender, EventArgs e)
        {
            clientes abrir = new clientes(_conecc, "0");
            abrir.Show();
        }
       
         private void Actualizar()
        {
            string aC = "select producto.id as ID, producto.codigo, producto.descripcion, producto.precio_unidad, producto.precio_mayoreo, producto.departamento, producto.categoria, producto.estatus " + "from producto";
            dtDatos = _conecc.llenarTablas(aC);
            dta_compras.DataSource = dtDatos;
            if (lbl_listo.Visible==true)
            {
                
            }
            string aB = "select comprass.id as ID, comprass.codigo, comprass.producto, comprass.p_unidad, comprass.p_mayoreo, comprass.departamento, comprass.categoria, comprass.cantidad " + "from comprass";
            dtDatos = _conecc.llenarTablas(aB);
            dtDatos1.DataSource = dtDatos;
            //Mostrar tablas
        }
        
        
        

         private void btnguardar_Click(object sender, EventArgs e)
         {
            if (lbl_id.Text == " ") //Si el label id es igual a vacio
            {
                MessageBox.Show("Producto no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }
            else //si no esta vacio hace lo siguiente
            {
                if (lblno_disponible.Visible == true) //Si el label no dispobible es visible muestra un mensaje
                {
                    MessageBox.Show("Producto no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                }
                else //si no hace lo siguiente
                {
                    if (lbl_cantidad.Text == "") //Si el label cantidad es vacio muestra un mensaje
                    {
                        MessageBox.Show("Por favor ingrese un valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbcantidad.Focus();
                    }
                    else //Si ha logrado pasar todas las condiciones anteriores realizara la siguiente consulta a la base de datos
                    {
                        if (rbtnpor_unidad.Checked == true) //Si el boton unidad esta activo
                        {
                            MySql.Data.MySqlClient.MySqlCommand comando = null;
                            try
                            {
                                string insertar = "insert into comprass(codigo, producto, p_unidad,departamento, categoria, cantidad)" +
                                    "values (@codigo, @producto, @p_unidad, @departamento, @categoria, @cantidad)";
                                using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                                {
                                    MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                                    agregar.Parameters.AddWithValue("@codigo", lbl_codigo.Text);
                                    agregar.Parameters.AddWithValue("@producto", lbl_nombre.Text);
                                    agregar.Parameters.AddWithValue("@p_unidad", lbl_unidad.Text);
                                    agregar.Parameters.AddWithValue("@categoria", lbl_categoria.Text);
                                    agregar.Parameters.AddWithValue("@departamento", lbl_departamento.Text);
                                    agregar.Parameters.AddWithValue("@cantidad", lbl_cantidad.Text);


                                    _conecc.InsertCon(agregar);
                                    Limpiar();
                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                        }
                        else
                        {
                            if (rbtnpor_mayoreo.Checked == true) //si el boton mayoreo esta activo
                            {
                                MySql.Data.MySqlClient.MySqlCommand comando = null;
                                try
                                {
                                    string insertar = "insert into comprass(codigo, producto, p_mayoreo,departamento, categoria, cantidad)" +
                                        "values (@codigo, @producto, @p_mayoreo, @departamento, @categoria, @cantidad)";
                                    using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                                    {
                                        MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                                        agregar.Parameters.AddWithValue("@codigo", lbl_codigo.Text);
                                        agregar.Parameters.AddWithValue("@producto", lbl_nombre.Text);
                                        agregar.Parameters.AddWithValue("@p_mayoreo", lbl_mayoreo.Text);
                                        agregar.Parameters.AddWithValue("@categoria", lbl_categoria.Text);
                                        agregar.Parameters.AddWithValue("@departamento", lbl_departamento.Text);
                                        agregar.Parameters.AddWithValue("@cantidad", lbl_cantidad.Text);


                                        _conecc.InsertCon(agregar);
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

            }
           //Actualiza las tablas
            Actualizar();
        }

         private void dta_compras_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
         {
            
         }
        private void Limpiar()
         {
            tbcantidad.Clear();
            lbl_id.Text = "";
            lbl_codigo.Text = "";
            lbl_nombre.Text = "";
            lbl_unidad.Text = "";
            lbl_mayoreo.Text = "";
            lbl_departamento.Text = "";
            lbl_categoria.Text = "";
            lbl_cantidad.Text = "";
            dtDatos1.ClearSelection();
        }

        private void dta_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = dta_compras.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                lbl_id.Text = dta_compras.CurrentRow.Cells[0].Value.ToString();
                lbl_codigo.Text = dta_compras.CurrentRow.Cells[1].Value.ToString();
                lbl_nombre.Text = dta_compras.CurrentRow.Cells[2].Value.ToString();
                lbl_unidad.Text = dta_compras.CurrentRow.Cells[3].Value.ToString();
                lbl_mayoreo.Text = dta_compras.CurrentRow.Cells[4].Value.ToString();
                lbl_departamento.Text = dta_compras.CurrentRow.Cells[5].Value.ToString();
                lbl_categoria.Text = dta_compras.CurrentRow.Cells[6].Value.ToString();
                tb_estatus.Text = dta_compras.CurrentRow.Cells[7].Value.ToString();
                //LLena labels invisbles con la informacion seleccionada
            }
            string estatus;
            estatus = Convert.ToString(tb_estatus.Text);
            switch (estatus)
            {
                case "True":
                    lbl_estatus.Text = "True";
                    break;
                default:
                    lbl_estatus.Text = "False";
                    break;
                case "":
                    lbl_estatus.Text = "";
                    break;
            }
            if (lbl_estatus.Text == "True")
            {
                lbl_disponible.Visible = true;
                lblno_disponible.Visible = false;
            }
            else
            {
                lblno_disponible.Visible = true;
                lbl_disponible.Visible = false;
            }
        }

        private void dta_compras_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;

            lbl_cantidad.Text = tbcantidad.Text;


        }

        private void tbcantidad_Enter(object sender, EventArgs e)
        {
        }

        private void tbcantidad_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void tbcantidad_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand comando2 = null;
            try
            {
                string insertar = "delete from comprass where id='" + lbl_id2.Text + "' ";
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

        private void tbbuscar_KeyPress(object sender, KeyPressEventArgs e)
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
            dta_compras.DataSource = dtDatos;

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lbl_disponible_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            dtDatos1.SelectAll();

            DialogResult result1 = MessageBox.Show("¿Desea cancelar esta operacion? todos los datos se perderan.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if(result1 == DialogResult.Yes)
            {
                Limpiar();
                MySql.Data.MySqlClient.MySqlCommand comando = null;
                try
                {
                    string insertar = "truncate table comprass";
                    using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
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
                dtDatos1.ClearSelection();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
        }

        private void tbbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtDatos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = dtDatos1.Rows[e.RowIndex].Cells[0].Value.ToString();

                lbl_id2.Text = dtDatos1.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
           
            ventas abrir = new ventas(_conecc, "0");
            abrir.Show();
            this.Close();


        }
    }
}
