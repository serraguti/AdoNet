﻿using System;
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
//alter procedure updatesalariosplantilla
//(@nombre nvarchar(50))
//as
//declare @hospitalcod int
//declare @sumasalarial int
//select @hospitalcod = hospital_cod from hospital
//where nombre = @nombre
//select @sumasalarial = sum(salario) from plantilla
//where HOSPITAL_COD = @hospitalcod
//if (@sumasalarial > 1000000)
//    begin
//        update plantilla set salario = salario - 10000
//	where HOSPITAL_COD = @hospitalcod
//	print 'Bajando salarios'
//end
//else
//begin
//	update plantilla set salario = salario + 10000
//	where HOSPITAL_COD = @hospitalcod
//	print 'Subiendo salarios'
//end
//select * from plantilla where HOSPITAL_COD = @hospitalcod
//go
//exec updatesalariosplantilla 'la paz'
#endregion

namespace AdoNet
{
    public partial class Form07IncrementarSalariosProcedure : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form07IncrementarSalariosProcedure()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            string sql = "select * from hospital";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnModificarSalarios_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            SqlParameter paramNombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(paramNombre);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "updatesalariosplantilla";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            this.lstPlantilla.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + ", " + funcion + ",  " + salario);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
