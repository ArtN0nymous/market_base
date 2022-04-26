using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace Punto_de_Venta
{
    public class conexion
    {

        //componente o variable de conexion//
        public MySqlConnection conn = null;
        //datos de conexion//
        string sconexion = "server=localhost; uid=root; database=punto_de_venta";


        //coexion por conecctar a la base de datos//
        public bool conectando()
        {
            try
            {
                conn = new MySqlConnection(sconexion);
                conn.Open();
            }
            catch (Exception ex) //llama el error que esta cachando el cacht//
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }
        public DataTable llenarTablas(string sL)
        {
            string strQuery = sL;
            MySqlCommand cmd = new MySqlCommand(strQuery, conn);
            cmd.Prepare();

            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cmd);
            DataTable dtaDatos = new DataTable();
            mdaDatos.Fill(dtaDatos);
            return dtaDatos;
        }

        public void getCombo(string strTable, string filtro, ref System.Windows.Forms.ComboBox cmb)
        {
            DataTable dtaDatos = new DataTable();
            string strQuery = " select * from " + strTable + " " + filtro;
            MySqlCommand cmd = new MySqlCommand(strQuery, conn);
            cmd.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cmd);
            mdaDatos.Fill(dtaDatos);
            cmb.ValueMember = "id";
            cmb.DisplayMember = "usuario";
            cmb.DataSource = dtaDatos;

        }
        public void ComboCategoria(string strTable, string filtro, ref System.Windows.Forms.ComboBox cmb)
        {
            DataTable dtaDatos = new DataTable();
            string strQuery = " select * from " + strTable + " " + filtro;
            MySqlCommand cmd = new MySqlCommand(strQuery, conn);
            cmd.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cmd);
            mdaDatos.Fill(dtaDatos);
            cmb.ValueMember = "id";
            cmb.DisplayMember = "categoria";
            cmb.DataSource = dtaDatos;

        }
        public void Combodepartamento(string strTable, string filtro, ref System.Windows.Forms.ComboBox cmb)
        {
            DataTable dtaDatos = new DataTable();
            string strQuery = " select * from " + strTable + " " + filtro;
            MySqlCommand cmd = new MySqlCommand(strQuery, conn);
            cmd.Prepare();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(cmd);
            mdaDatos.Fill(dtaDatos);
            cmb.ValueMember = "id";
            cmb.DisplayMember = "Departamento";
            cmb.DataSource = dtaDatos;

        }
        public void Insertar(string strCadena)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = strCadena;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("El registro se ha completado exitosamente..");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }

        }
        public void Modificar(string strCadena)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = strCadena;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Los datos se han Modificado exitosamente..");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }

        }
    
        public void InsertCon(MySqlCommand comand)
        {
            try
            {
                comand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        public void Eliminar(string strCadena)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = strCadena;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Datos modificados exitosamente");

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
       
    }
}
