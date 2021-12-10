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

#region PROCEDIMIENTOS VISTAS

//create view doctores_plantilla
//as
//	select doctor_no as id, apellido, salario, hospital_cod from doctor
//	union
//	select empleado_no, apellido, salario, hospital_cod from plantilla
//go
//create procedure doctores_plantilla_hospital
//(@nombre nvarchar(50)
//, @suma int out, @media int out, @personas int out)
//as
//	declare @hospitalcod int
//	select @hospitalcod = HOSPITAL_COD from hospital
//	where nombre = @nombre
//	select * from doctores_plantilla where HOSPITAL_COD = @hospitalcod
//	select @suma = sum(salario)
//	, @personas = count(id), @media = avg(salario)
//	from doctores_plantilla where HOSPITAL_COD = @hospitalcod
//go

#endregion

namespace AdoNet
{
    public partial class Form11PlantillaDoctoresHospital : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form11PlantillaDoctoresHospital()
        {
            InitializeComponent();
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            String cadenaconexion = config["CadenaHospitalTajamar"];
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            String sql = "select * from hospital";
            this.com.CommandText = sql;
            this.com.CommandType = CommandType.Text;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                String nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string sql = "doctores_plantilla_hospital";
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            SqlParameter pamMedia = new SqlParameter("@MEDIA", 0);
            pamMedia.Direction = ParameterDirection.Output;
            SqlParameter pamSuma = new SqlParameter("@SUMA", 0);
            pamSuma.Direction = ParameterDirection.Output;
            SqlParameter pamPersonas = new SqlParameter("@PERSONAS", 0);
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            this.com.Parameters.Add(pamMedia);
            this.com.Parameters.Add(pamSuma);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);
            }
            this.reader.Close();
            this.lblMedia.Text = "Media: " + pamMedia.Value;
            this.lblPersonas.Text = "Personas: " + pamPersonas.Value;
            this.lblSuma.Text = "Suma: " + pamSuma.Value;
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
