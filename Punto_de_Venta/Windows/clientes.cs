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
    public partial class clientes : Form
    {
        public conexion _conecc = null;
        string _sId;
        DataTable dtDatos = null;
        public clientes(conexion _conect1, string sId)
        {
            InitializeComponent();
            _conecc = _conect1;
            _sId = sId;
           
        }
        private void Actualizar()
        {
            string aC = "select cliente.id as ID, cliente.nombre, cliente.apellido, cliente.direccion, cliente.deuda_actual, cliente.ultimo_pago, cliente.fecha, cliente.estatus" + " from cliente";
            dtDatos = _conecc.llenarTablas(aC);
            dta_clientes.DataSource = dtDatos;
            string aB = "select reporte.id as ID, reporte.nombre, reporte.apellido, reporte.telefono, reporte.fecha, reporte.report, reporte.direccion " + " from reporte";
            dtDatos = _conecc.llenarTablas(aB);
            dtaclientes_reportes.DataSource = dtDatos;
            //Mostrar tablas de la base de datos
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            Actualizar();
            rbtningresar_cliente.Checked = true;
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
            this.Hide();
            productos abrir = new productos(_conecc, "0");
            abrir.Show();
        }

        private void bar_btn_clientes_Click(object sender, EventArgs e)
        {
            //Actualizar();
        }

        private void lblapellido3_Click(object sender, EventArgs e)
        {

        }

        private void lblbuscar3_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar3_Click(object sender, EventArgs e)
        {
            if (rbtningresar_cliente.Checked == true)
            {
                //Guarda los datos que se encuentran en los TextBox correspondientes mediante una consulta de SQL si se cumple la condicion
                MySql.Data.MySqlClient.MySqlCommand comando = null;
                try
                {
                    string insertar = "insert into cliente(nombre, apellido, direccion, ultimo_pago, fecha, estatus)" +
                        "values (@nombre, @apellido, @direccion, @ultimo_pago, @fecha, @estatus)";
                    using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                    {
                        MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                        agregar.Parameters.AddWithValue("@nombre", tbnombre.Text);
                        agregar.Parameters.AddWithValue("@apellido", tbapellido.Text);
                        agregar.Parameters.AddWithValue("@direccion", tbdireccion.Text);
                        agregar.Parameters.AddWithValue("@telefono", tbtelefono.Text);
                        //agregar.Parameters.AddWithValue("@deuda_actual" == )
                        agregar.Parameters.AddWithValue("@ultimo_pago", tbpago_deudas.Text);
                        agregar.Parameters.AddWithValue("@fecha", dtfecha.Value.ToString("yyyyMMdd"));
                        agregar.Parameters.AddWithValue("@estatus", 1);


                        _conecc.InsertCon(agregar);
                        MessageBox.Show("Información guardada correctamente", "Clientes");
                        Limpiar();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Actualizar();
            }
            else
            {
                
                
                //Si no se cumple la condicion hace la siguiente consulta
                MySql.Data.MySqlClient.MySqlCommand comando = null;
                try
                {
                    string insertar = "insert into reporte(nombre, apellido, telefono, fecha, report, direccion)" +
                        "values (@nombre, @apellido, @telefono, @fecha, @report, @direccion)";
                    using (comando = new MySql.Data.MySqlClient.MySqlCommand(insertar, _conecc.conn))
                    {
                        MySqlCommand agregar = new MySqlCommand(insertar, _conecc.conn);

                        agregar.Parameters.AddWithValue("@nombre", lblnombr3_1.Text);
                        agregar.Parameters.AddWithValue("@apellido", lblapellido3_2.Text);

                        agregar.Parameters.AddWithValue("@telefono", lbl_telefono.Text);
                      
                        agregar.Parameters.AddWithValue("@fecha", fecha_date.Value.ToString("yyyyMMdd"));
                        agregar.Parameters.AddWithValue("@report", tb_reporte.Text);
                        agregar.Parameters.AddWithValue("@direccion", tbdireccion.Text);



                        _conecc.InsertCon(agregar);
                        MessageBox.Show("Información guardada correctamente", "Clientes");
                        Limpiar();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                Actualizar();
            }
            }
            
        private void Limpiar()
        {
            tbnombre.Clear();
            tbapellido.Clear();
            tbdireccion.Clear();
            tbtelefono.Clear();
            tbpago_deudas.Clear();
            dtfecha.Text = "";
            //list1.Items.Clear.
        }

        private void tbbuscar3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string sC;
            string sAux;
            string swhere = "";

            sAux = tbbuscar3.Text + e.KeyChar;
            if (rbtn_nombre.Checked == true)
            {
                swhere = " Where cliente.nombre Like '%" + sAux + "%' ";
            }
            if (rbtn_apellido.Checked == true)
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
            dta_clientes.DataSource = dtDatos;
        }

        private void btneliminar3_Click(object sender, EventArgs e)
        {
            //Elimina contenido de la base de datos
            MySql.Data.MySqlClient.MySqlCommand comando2 = null;
            try
            {
                string insertar = "delete from cliente where id='" + lbl_id.Text + "' ";
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

        private void dta_clientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Toma la informacion sleccionada y la envia a una lista
            string a;
            string b;
            string c;
            string d;
            string E;

            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                string id = dta_clientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                

                lbl_id.Text = dta_clientes.CurrentRow.Cells[0].Value.ToString();
                lblnombr3_1.Text = dta_clientes.CurrentRow.Cells[1].Value.ToString();
                lblapellido3_2.Text = dta_clientes.CurrentRow.Cells[2].Value.ToString();
                lbl_deuda_actual3_1.Text = dta_clientes.CurrentRow.Cells[4].Value.ToString();
                lblultimo_pago3_1.Text = dta_clientes.CurrentRow.Cells[5].Value.ToString();
                lblfecha3_1.Text = dta_clientes.CurrentRow.Cells[6].Value.ToString();
                lbl_telefono.Text = dta_clientes.CurrentRow.Cells[3].Value.ToString();

                a = "Nombre: " + lblnombr3_1.Text;
                b = "Apellido: " + lblapellido3_2.Text;
                c = "Deuda: $" + lbl_deuda_actual3_1.Text;
                d = "Deuda actual: $" + lblultimo_pago3_1.Text;
                E = "Fecha: " + lblfecha3_1.Text;

                list1.Items.Add(a);
                list1.Items.Add(b);
                list1.Items.Add(c);
                list1.Items.Add(d);
                list1.Items.Add(E);
            }
        }

        private void btncancelar3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnfactura3_Click(object sender, EventArgs e)
        {
            printdialog1.ShowDialog();
        }

        private void pd1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int altura = 50;
            for (int i = 0; i < list1.Items.Count; i++)
            {
                //codigo
                list1.SelectedIndex = i;
                e.Graphics.DrawString(list1.SelectedItem.ToString(), list1.Font, new SolidBrush(list1.ForeColor), 50, altura, StringFormat.GenericDefault);
                altura += list1.ItemHeight;
            }
        }

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            gruporeport.Visible = true;
            tb_reporte.Focus();
            rbtningresar_cliente.Checked = false;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Administracion abrir = new Administracion(_conecc, "0");
            abrir.Show();
        }
    }
    }

