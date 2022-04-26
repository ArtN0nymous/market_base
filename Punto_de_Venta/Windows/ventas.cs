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
    public partial class ventas : Form
    {
        public conexion _conecc = null;
        string _sId;

        DataTable dtDatos = null;

        public ventas(conexion _conect1, string sId)
        {
            InitializeComponent();
            _conecc = _conect1;
            _sId = sId;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Suma()
        {
            
            double total;
            double b = 0;
            double a = 0;
            
            if (dta_ventas.Rows.Count == 0)
            {
            }
            else
            {
                foreach (DataGridViewRow row in dt_unidad_cantidad.Rows)
                {
                    a += Convert.ToDouble(row.Cells["total"].Value);
                }
            }
            if (dta_ventas.Rows.Count == 0)
            {
            }
            else
            {
                foreach (DataGridViewRow row in dt_mayoreo_cantidad.Rows)
                {
                    b += Convert.ToDouble(row.Cells["total"].Value);
                }
            }
            total = a + b;
            lblpagar.Text = (Convert.ToString(total.ToString("f2")));
        }

        private void ventas_Load(object sender, EventArgs e)
        {

            rbt_contado.Checked = true;
            check_nombre.Checked = true;
            actu();
            Suma();
            if (rbtcredito.Checked == true)
            {
                lbl_deuda_total.Text = lblpagar.Text;
            }
        }

        private void dta_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void actu()
        {
            string aB = "select comprass.id as ID, comprass.codigo, comprass.producto, comprass.p_unidad, comprass.p_mayoreo, comprass.departamento, comprass.categoria, comprass.cantidad " + "from comprass";
            dtDatos = _conecc.llenarTablas(aB);
            dta_ventas.DataSource = dtDatos;

            string Ac = "select p_unidad * cantidad as total" + " from comprass";
            dtDatos = _conecc.llenarTablas(Ac);
            dt_unidad_cantidad.DataSource = dtDatos;

            string Ab = "select p_mayoreo * cantidad as total" + " from comprass";
            dtDatos = _conecc.llenarTablas(Ab);
            dt_mayoreo_cantidad.DataSource = dtDatos;

            string aC = "select cliente.id as ID, cliente.nombre, cliente.apellido, cliente.direccion, cliente.telefono, cliente.deuda_actual, cliente.ultimo_pago, cliente.fecha, cliente.estatus" + " from cliente";
            dtDatos = _conecc.llenarTablas(aC);
            dt_clientes.DataSource = dtDatos;

        }

        private void bar_btn_ventas_Click(object sender, EventArgs e)
        {
    
        }

        private void bar_btn_compras_Click(object sender, EventArgs e)
        {
            this.Hide();

            compras abrir = new compras(_conecc, "0");
            abrir.Show();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerca_de abrir = new acerca_de();
            abrir.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            double cambio;
            double tot;
            double b = 0;
            double a = 0;
            double c = 0;
            try
            {
            
                    if (rbtcredito.Checked == true)
                    {
                        if (lblno_disponible.Visible == true)
                        {
                            MessageBox.Show("Informcaión de cliente no disponible","Aviso",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            lbl_deuda_total.Text = lblpagar.Text;
                            
                            //Hace un registro en la tabla de clientes
                            MySql.Data.MySqlClient.MySqlCommand comando = null;
                            try
                            {
                                string insertar = "insert into cliente(nombre, apellido, direccion, telefono, deuda_actual, ultimo_pago, fecha, estatus)" +
                                    "values (@nombre, @apellido, @direccion, @telefono, @deuda_actual, @ultimo_pago, @fecha, @estatus)";
                                using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                                {
                                    MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                                    agregar.Parameters.AddWithValue("@nombre", lbl_nombre.Text);
                                    agregar.Parameters.AddWithValue("@apellido", lbl_apellido.Text);
                                    agregar.Parameters.AddWithValue("@direccion", lbl_direccion.Text);
                                    agregar.Parameters.AddWithValue("@telefono", lbl_telefono.Text);
                                    agregar.Parameters.AddWithValue("@deuda_actual", lblpagar.Text);
                                    agregar.Parameters.AddWithValue("@ultimo_pago", tbpago_deudas.Text);
                                    agregar.Parameters.AddWithValue("@fecha", dtfecha.Value.ToString("yyyyMMdd"));
                                    agregar.Parameters.AddWithValue("@estatus", 1);


                                    _conecc.InsertCon(agregar);
                                    DialogResult result1 = MessageBox.Show("Operación exitosa ¿Desea volver a compras?.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                                    if (result1 == DialogResult.Yes)
                                    {
                                        MySql.Data.MySqlClient.MySqlCommand comando3 = null;
                                        try
                                        {
                                            string insert = "truncate table comprass";
                                            using (comando3 = new MySql.Data.MySqlClient.MySqlCommand(insert, _conecc.conn))
                                            {
                                                MySqlCommand add = new MySqlCommand(insertar, _conecc.conn);
                                                _conecc.InsertCon(add);
                                            }
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString());
                                        }

                                        this.Hide();
                                        compras abrir = new compras(_conecc, "0");
                                        abrir.Show();
                                    }

                            }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
         
                        MySql.Data.MySqlClient.MySqlCommand comando2 = null;
                        try
                        {
                            string insertar = "truncate table comprass";
                            using (comando2 = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                            {
                                MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);
                                _conecc.InsertCon(agregar);
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                      
                    }
                    else
                    { 
                        if (tb_pago.Text == "")
                        {
                            MessageBox.Show("Ingrese un valor valido", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            if (dt_unidad_cantidad.Rows.Count == 0)
                            {

                            }
                            else
                            {
                                foreach (DataGridViewRow row in dt_unidad_cantidad.Rows)
                                {
                                    a += Convert.ToDouble(row.Cells["total"].Value);
                                }

                            }
                            if (dt_mayoreo_cantidad.Rows.Count == 0)
                            {
 
                            }
                            else
                            {
                                foreach (DataGridViewRow row in dt_mayoreo_cantidad.Rows)
                                {
                                    b += Convert.ToDouble(row.Cells["total"].Value);
                                }
                            }
                            tot = a + b;

                            c += Convert.ToDouble(tb_pago.Text);
                            if (c < tot)
                            {
                                MessageBox.Show("El pago es menor al monto a pagar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                cambio = c - tot;

                                lbl_cambio.Text = (Convert.ToString(cambio.ToString("f2")));
                                lblpagar.Text = (Convert.ToString(tot.ToString("f2")));
                            }

                            //Guarda un registro general

                            MySql.Data.MySqlClient.MySqlCommand comando = null;
                            try
                            {
                                string insertar = "insert into registro(nombre, apellido, direccion, telefono, total, fecha)" +
                                    "values (@nombre, @apellido, @direccion, @telefono, @total, @fecha)";
                                using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                                {
                                    MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                                    agregar.Parameters.AddWithValue("@nombre", lbl_nombre.Text);
                                    agregar.Parameters.AddWithValue("@apellido", lbl_apellido.Text);
                                    agregar.Parameters.AddWithValue("@direccion", lbl_direccion.Text);
                                    agregar.Parameters.AddWithValue("@telefono", lbl_telefono.Text);
                                    agregar.Parameters.AddWithValue("@total", lblpagar.Text);

                                    agregar.Parameters.AddWithValue("@fecha", dtfecha.Value.ToString("yyyyMMdd"));
                                    _conecc.InsertCon(agregar);

                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                            DialogResult result1 = MessageBox.Show("¿Volver a compras?.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                            if (result1 == DialogResult.Yes)
                            {
                                      MySql.Data.MySqlClient.MySqlCommand comando3 = null;
                                      try
                                      {
                                          string insertar = "truncate table comprass";
                                          using (comando3 = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                                          {
                                              MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);
                                              _conecc.InsertCon(agregar);

                                          }
                                      }
                                      catch (Exception ex)
                                      {
                                          MessageBox.Show(ex.ToString());
                                      }
                                this.Hide();
                                compras abrir = new compras(_conecc, "0");
                                abrir.Show();
                            }

                        
                    }
                    }
            }
             catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
            actu();

        }

        private void tbbuscar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbbuscar1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
           
             string sC;
            string sAux;
            string swhere = "";

            sAux = tbbuscar1.Text + e.KeyChar;
            swhere = " Where comprass.nombre Like '%" + sAux + "%' ";
            if (check_nombre.Checked == true)
            {
                swhere = " Where comprass.producto Like '%" + sAux + "%' ";
            }
            if (check_codigo.Checked == true)
            {
                swhere = " Where comprass.codigo Like '%" + sAux + "%' ";
            }
            if (sAux.Trim() == null || e.KeyChar == 8)
            {
                sC = " select comprass.id as ID, comprass.codigo, comprass.producto, comprass.p_unidad, comprass.p_mayoreo, comprass.departamento, comprass.categoria, comprass.cantidad " + "from comprass";
            }
            else
            {
                sC = " select comprass.id as ID, comprass.codigo, comprass.producto, comprass.p_unidad, comprass.p_mayoreo, comprass.departamento, comprass.categoria, comprass.cantidad " + "from comprass" + swhere;
            }
            dtDatos = _conecc.llenarTablas(sC);
            dta_ventas.DataSource = dtDatos;


        }

        private void btnfactura1_Click(object sender, EventArgs e)
        {
            printdialog1.ShowDialog();
      
        }

        private void dt_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a;
            string b;
            string c;
            string d;
            string E;

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = dt_clientes.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtid.Text = dt_clientes.CurrentRow.Cells[0].Value.ToString();
                lbl_nombre.Text = dt_clientes.CurrentRow.Cells[1].Value.ToString();
                lbl_apellido.Text = dt_clientes.CurrentRow.Cells[2].Value.ToString();
                lbl_direccion.Text = dt_clientes.CurrentRow.Cells[3].Value.ToString();
                lbl_telefono.Text = dt_clientes.CurrentRow.Cells[4].Value.ToString();
                tbpago_deudas.Text = dt_clientes.CurrentRow.Cells[5].Value.ToString();
                tb_estatus.Text = dt_clientes.CurrentRow.Cells[8].Value.ToString();

                lbldeuda1_2.Text = dt_clientes.CurrentRow.Cells[5].Value.ToString();
                lblultimo_pago1.Text = dt_clientes.CurrentRow.Cells[6].Value.ToString();
                lblfecha1.Text = dt_clientes.CurrentRow.Cells[7].Value.ToString();
                
                a = "Nombre: " + lbl_nombre.Text;
                b = "Apellido: " + lbl_apellido.Text;
                c = "Deuda: $" + lbldeuda1_2.Text;
                d = "Deuda actual: $" + lblultimo_pago1.Text;
                E = "Fecha: " + lblfecha1.Text;

                list1.Items.Add(a);
                list1.Items.Add(b);
                list1.Items.Add(c);
                list1.Items.Add(d);
                list1.Items.Add(E);

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

        private void tb_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actu();
        }

        private void lblpagar_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar1_Click(object sender, EventArgs e)
        {
            dta_ventas.SelectAll();

           
           
                DialogResult result1 = MessageBox.Show("¿Desea cancelar esta operacion? todos los datos se perderan.", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if(result1 == DialogResult.Yes)
                    {
                        lblpagar.Text = "0.00";
                         lbl_cambio.Text = "0.00";
                         lbl_deuda_total.Text = "$0.00";
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
                         actu();

                         dta_ventas.ClearSelection();
                    }
            
        }

        private void pbbuscar_Click(object sender, EventArgs e)
        {
     
        }

        private void tbbuscar1_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sC;
            string sAux;
            string swhere = "";

            sAux = tbbuscar1_2.Text + e.KeyChar;
            if (rbt_nombre.Checked == true)
            {
                swhere = " Where cliente.nombre Like '%" + sAux + "%' ";
            }
            if (rbt_apellido.Checked == true)
            {
                swhere = " Where cliente.apellido Like '%" + sAux + "%' ";
            }
            if (sAux.Trim() == null || e.KeyChar == 8)
            {
                sC = " select cliente.id as ID, cliente.nombre, cliente.apellido, cliente.direccion, cliente.deuda_actual, cliente.ultimo_pago, cliente.fecha, cliente.estatus" + " from cliente";
            }
            else
            {
                sC = " select cliente.id as ID, cliente.nombre, cliente.apellido, cliente.direccion, cliente.deuda_actual, cliente.ultimo_pago, cliente.fecha, cliente.estatus" + " from cliente" + swhere;
            }
            dtDatos = _conecc.llenarTablas(sC);
            dt_clientes.DataSource = dtDatos;
        }

        private void pd1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int altura = 50;
            for (int i=0; i < list1.Items.Count; i++)
            {
                list1.SelectedIndex = i;
                e.Graphics.DrawString(list1.SelectedItem.ToString(), list1.Font, new SolidBrush(list1.ForeColor), 50, altura, StringFormat.GenericDefault);
                altura += list1.ItemHeight;
            }        

        }

        private void printdialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
