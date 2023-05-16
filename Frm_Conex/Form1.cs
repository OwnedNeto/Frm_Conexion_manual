using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Frm_Conex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conex = new SqlConnection("Data Source=ERNESTOLAP\\SQLEXPRESS; Initial Catalog=conexion_db; Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try 
            { 
                conex.Open();
                MessageBox.Show("Conexion exitosa");
              

            } 
            catch(Exception ex) 
            {
                MessageBox.Show("No hay conexion" + ex.Message);

            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            try 
            { 
                SqlDataAdapter datos= new SqlDataAdapter("Select * From t_personas",conex);
                DataTable dt = new DataTable();
                datos.Fill(dt);
                dgvDatos.DataSource = dt;
            }
            catch(Exception ex)
            {


            }
        }
    }
}
