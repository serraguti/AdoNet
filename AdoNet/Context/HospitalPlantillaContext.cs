using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AdoNet.Models;

namespace AdoNet.Context
{
    public class HospitalPlantillaContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public HospitalPlantillaContext()
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            String cadenaconexion = config["CadenaHospitalTajamar"];
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Hospital> GetHospitales()
        {
            string sql = "select * from hospital";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Hospital> lista = new List<Hospital>();
            while (this.reader.Read())
            {
                Hospital hosp = new Hospital();
                hosp.IdHospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hosp.Nombre = this.reader["NOMBRE"].ToString();
                lista.Add(hosp);
            }

            this.reader.Close();
            this.cn.Close();
            return lista;
        }

        public List<Plantilla> GetPlantillaHospital(int hospitalcod)
        {
            string sql = "select * from plantilla where hospital_cod=@HOSPITALCOD";
            this.com.Parameters.AddWithValue("@HOSPITALCOD", hospitalcod);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Plantilla> lista = new List<Plantilla>();
            while (this.reader.Read())
            {
                Plantilla plan = new Plantilla();
                plan.IdPlantilla = int.Parse(this.reader["EMPLEADO_NO"].ToString());
                plan.Apellido = this.reader["APELLIDO"].ToString();
                plan.Funcion = this.reader["FUNCION"].ToString();
                plan.Salario = int.Parse(this.reader["SALARIO"].ToString());
                plan.Hospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                lista.Add(plan);
            }

            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return lista;
        }


        public List<Plantilla> GetPlantillaHospitales(List<int> hospitales)
        {
            string sql = "select * from plantilla where hospital_cod=@HOSPITALCOD";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            List<Plantilla> lista = new List<Plantilla>();
            foreach (int codigo in hospitales)
            {
                this.com.Parameters.AddWithValue("@HOSPITALCOD", codigo);
                this.reader = this.com.ExecuteReader();
              
                while (this.reader.Read())
                {
                    Plantilla plan = new Plantilla();
                    plan.IdPlantilla = int.Parse(this.reader["EMPLEADO_NO"].ToString());
                    plan.Apellido = this.reader["APELLIDO"].ToString();
                    plan.Funcion = this.reader["FUNCION"].ToString();
                    plan.Salario = int.Parse(this.reader["SALARIO"].ToString());
                    plan.Hospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                    lista.Add(plan);
                }

                this.reader.Close();
                this.com.Parameters.Clear();
            }
            
            this.cn.Close();
            return lista;
        }

        public List<Plantilla> GetPlantillaHospitales(string hospitales)
        {
            //22,18
            string sql = "select * from plantilla where hospital_cod in ("
                 + hospitales + ")";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();

            List<Plantilla> lista = new List<Plantilla>();
            while (this.reader.Read())
            {
                Plantilla plan = new Plantilla();
                plan.IdPlantilla = int.Parse(this.reader["EMPLEADO_NO"].ToString());
                plan.Apellido = this.reader["APELLIDO"].ToString();
                plan.Funcion = this.reader["FUNCION"].ToString();
                plan.Salario = int.Parse(this.reader["SALARIO"].ToString());
                plan.Hospital = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                lista.Add(plan);
            }

            this.reader.Close();
            this.cn.Close();
            return lista;
        }
    }
}
