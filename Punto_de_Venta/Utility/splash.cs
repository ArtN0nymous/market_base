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
    public partial class splash : Form
    {
        public splash()
        {

            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 5000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
     
            

        }

        private void splash_Load(object sender, EventArgs e)
        {
            
        
        }
    }
}
