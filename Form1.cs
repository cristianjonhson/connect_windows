using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace conexionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String cadenaConexion = "Data source=.; initial catalog=william;integrated security=true";
                SqlConnection conexionBD = new SqlConnection(cadenaConexion);
                conexionBD.Open();
                MessageBox.Show("conexion exitosa");
            }
            catch (Exception)
            {
                MessageBox.Show("Conexion Fallida");
                throw;
            }
        }
    }
}
