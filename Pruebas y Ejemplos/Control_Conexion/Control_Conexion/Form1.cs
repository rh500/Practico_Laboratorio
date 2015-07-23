using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Control_Conexion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctrlusu_Conexion1_Conexion_Exitosa(System.Data.SqlClient.SqlConnection cnx)
        {
            MessageBox.Show(cnx.State.ToString());
        }

        
    }
}
