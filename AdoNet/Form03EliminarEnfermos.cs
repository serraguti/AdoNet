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

namespace AdoNet
{
    public partial class Form03EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            this.lstEnfermos.Items.Clear();
            String sql = "select * from enfermo";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(apellido + " - " + inscripcion);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string inscripcion = this.txtInscripcion.Text;
            string sql = "delete from enfermo where inscripcion=" + inscripcion;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            //Acción: ExecuteNonQuery() --> Devuelve un numero con los registros
            //afectados por la consulta
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            MessageBox.Show("Enfermos eliminados: " + eliminados);
            this.CargarEnfermos();
        }
    }
}
