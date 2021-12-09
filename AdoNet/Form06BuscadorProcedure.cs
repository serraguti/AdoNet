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
//CREATE PROCEDURE BUSCADORPLANTILLASALARIO
//(@SALARIO INT)
//AS
//	SELECT * FROM PLANTILLA
//	WHERE SALARIO >= @SALARIO
//GO
#endregion

namespace AdoNet
{
    public partial class Form06BuscadorProcedure : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form06BuscadorProcedure()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //LOS PARAMETROS SON ENVIADOS EN COMMAND
            int salario = int.Parse(this.txtSalario.Text);
            SqlParameter paramsal = new SqlParameter("@SALARIO", salario);
            this.com.Parameters.Add(paramsal);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "BUSCADORPLANTILLASALARIO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + ", " + sal);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
