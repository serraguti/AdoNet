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
    public partial class Form05ModificarSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
            
        public Form05ModificarSalas()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarSalas();
        }

        public void CargarSalas()
        {
            String sql = "select distinct nombre from sala";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstSalas.Items.Clear();
            while (this.reader.Read())
            {
                String nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string sql = "update sala set nombre=@newname where "
                + " nombre=@oldname";
            string oldname = this.lstSalas.SelectedItem.ToString();
            string newname = this.txtNuevoNombre.Text;
            SqlParameter pamold = new SqlParameter("@oldname", oldname);
            SqlParameter pamnew = new SqlParameter("@newname", newname);
            this.com.Parameters.Add(pamold);
            this.com.Parameters.Add(pamnew);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarSalas();
        }
    }
}
