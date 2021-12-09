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

#region PROCEDIMIENTOS ALMACENADOS

//CREATE procedure INSERTARDEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
//as

//    --NO QUEREMOS LOCALIDADES EN TERUEL
//	if (@localidad = 'TERUEL')
//	begin
//        print 'Teruel no existe'
//	end
//	else
//	begin 
//		insert into dept values (@numero, @nombre, @localidad)
//	end
//go
#endregion

namespace AdoNet
{
    public partial class Form08MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form08MensajesServidor()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajes.Text = e.Message;
        }

        private void CargarDepartamentos()
        {
            this.lstDepartamentos.Items.Clear();
            String sql = "select * from dept";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {
                string numero = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(numero + " - " + nombre
                    + " - " + localidad);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnNuevoDepartamento_Click(object sender, EventArgs e)
        {
            this.lblMensajes.Text = "";
            int numero = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            SqlParameter paramNumero = new SqlParameter("@numero", numero);
            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            SqlParameter paramLocalidad = new SqlParameter("@localidad", localidad);
            this.com.Parameters.Add(paramNumero);
            this.com.Parameters.Add(paramNombre);
            this.com.Parameters.Add(paramLocalidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "INSERTARDEPARTAMENTO";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarDepartamentos();
        }
    }
}
