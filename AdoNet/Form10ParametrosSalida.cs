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
using Microsoft.Extensions.Configuration;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure EMPLEADOSDEPT_OUTPUT
//(@NOMBRE NVARCHAR(50)
//, @SUMA INT OUT
//, @MEDIA INT OUT
//, @PERSONAS INT OUT)
//AS
//    DECLARE @DEPTNO INT
//	SELECT @DEPTNO = DEPT_NO FROM DEPT
//	WHERE DNOMBRE = @NOMBRE
//	--CONSULTA PARA LOS PARAMETROS DE SALIDA
//	SELECT @SUMA = SUM(SALARIO), @MEDIA = AVG(SALARIO)
//	, @PERSONAS = COUNT(EMP_NO) FROM EMP
//	WHERE DEPT_NO = @DEPTNO
//	--CONSULTA PARA DEVOLVER LOS EMPLEADOS (CURSOR)
//	SELECT* FROM EMP WHERE DEPT_NO = @DEPTNO
//GO
#endregion

namespace AdoNet
{
    public partial class Form10ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form10ParametrosSalida()
        {
            InitializeComponent();
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            String cadenaconexion = config["CadenaHospitalTajamar"];
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            string sql = "select * from dept";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbDepartamentos.SelectedItem.ToString();
            //NO ES NECESARIO CREAR PARAMETROS PARA LOS DE ENTRADA
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            SqlParameter pamSuma = new SqlParameter("@SUMA", 0);
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);
            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@MEDIA";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);
            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@PERSONAS";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "EMPLEADOSDEPT_OUTPUT";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }

            //HASTA QUE EL READER NO SE HA CERRADO, NO TENDREMOS EL 
            //VALOR DE LOS PARAMETROS
            this.reader.Close();

            this.lblMedia.Text = "Media: " + pamMedia.Value;
            this.lblPersonas.Text = "Personas: " + pamPersonas.Value;
            this.lblSuma.Text = "Suma: " + pamSuma.Value;

            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
