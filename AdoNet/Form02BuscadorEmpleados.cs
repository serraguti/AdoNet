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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            //TAMBIEN VAMOS A INDICAR LA CONEXION QUE UTILIZARA NUESTRO COMANDO
            this.com.Connection = this.cn;
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            String datosalario = this.txtSalario.Text;
            String sql = "select * from emp where salario > " + datosalario;
            this.lstEmpleados.Items.Clear();
            //TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //CONSULTA SQL
            this.com.CommandText = sql;
            //SIEMPRE SERA ENTRAR/SALIR
            //ABRIR CONEXION
            this.cn.Open();
            //EJECUTAR CONSULTA
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                String apellido = this.reader["APELLIDO"].ToString();
                String sal = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + sal);
            }

            //SALIMOS
            this.reader.Close();
            this.cn.Close();
        }

        private void btnBuscarOficios_Click(object sender, EventArgs e)
        {
            String oficio = this.txtOficio.Text;
            String sql = "select * from emp where oficio='" + oficio + "'";
            this.lstEmpleados.Items.Clear();
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string ape = this.reader["APELLIDO"].ToString();
                string ofi = this.reader["OFICIO"].ToString();
                this.lstEmpleados.Items.Add(ape + " - " + ofi);
            }

            this.reader.Close();
            this.cn.Close();
        }
    }
}
