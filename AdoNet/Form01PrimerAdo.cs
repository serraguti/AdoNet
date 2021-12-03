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
    public partial class Form01PrimerAdo : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "Connection está cambiando de "
                + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                this.lblMensaje.BackColor = Color.LightGreen;
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //DECLARAMOS NUESTRA CONSULTA SQL
            string sql = "select * from emp";
            //INDICAMOS AL COMANDO SU CONEXION
            this.com.Connection = this.cn;
            //INDICAMOS EL TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //INDICAMOS LA CONSULTA
            this.com.CommandText = sql;
            //DEBEMOS TENER LA CONEXION ABIERTA
            //PARA LOS SIGUIENTES PASOS
            //EJECUTAMOS LA CONSULTA
            //COMO ES UNA CONSULTA SELECT, DEVUELVE UN CURSOR
            //UN CURSOR ES SqlDataReader
            this.reader = this.com.ExecuteReader();
            //VAMOS A DIBUJAR LA PRIMERA COLUMNA DE LA CONSULTA
            //Y SU TIPO DE DATO
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                String columna = this.reader.GetName(i);
                String tipo = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipo);
            }

            //VAMOS A RECUPERAR UN APELLIDO
            //PARA PODER RECUPERAR REGISTROS
            //DEBEMOS LEER
            //EL CURSOR ESTA POSICIONADO POR DEFECTO EN LA FILA -1
            //CADA VEZ QUE LEEMOS, VA AVANZANDO UNA FILA
            while (this.reader.Read())
            {
                //string apellido = this.reader.GetString(1); //APELLIDO
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            //SIEMPRE DEBEMOS LIBERAR EL CURSOR AL FINALIZAR LA LECTURA
            this.reader.Close();
        }
    }
}
