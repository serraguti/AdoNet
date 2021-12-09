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

#region PROCEDIMIENTO ALMACENADO
//CREATE PROCEDURE ACTUALIZARDOCTOR
//(@IDDOCTOR INT, @APELLIDO NVARCHAR(50)
//, @ESPECIALIDAD NVARCHAR(50), @SALARIO INT
//, @HOSPITAL INT)
//AS
//	declare @numdoctors int
//	select @numdoctors = count(doctor_no) from doctor
//	where DOCTOR_NO = @IDDOCTOR
//	if (@numdoctors = 0)
//	begin
//		insert into doctor values (@HOSPITAL, @IDDOCTOR
//		, @APELLIDO, @ESPECIALIDAD, @SALARIO)
//		print 'Doctor insertado'
//	end
//	else
//	begin
//		update doctor set APELLIDO = @APELLIDO, ESPECIALIDAD = @ESPECIALIDAD
//		, salario = @salario, HOSPITAL_COD = @HOSPITAL
//		where DOCTOR_NO = @IDDOCTOR
//		print 'Doctor actualizado'
//	end
//GO
#endregion

namespace AdoNet
{
    public partial class Form09UpdateInsertDoctor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form09UpdateInsertDoctor()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=LOCALHOST;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.cn = new SqlConnection(cadenaconexion);
            this.cn.InfoMessage += Cn_InfoMessage;
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajes.Text = e.Message;
        }

        private void btnActualizarDatos_Click(object sender, EventArgs e)
        {
            this.lblMensajes.Text = "";
            int iddoctor = int.Parse(this.txtIdDoctor.Text);
            String apellido = this.txtApellido.Text;
            String especialidad = this.txtEspecialidad.Text;
            int salario = int.Parse(this.txtSalario.Text);
            int hospitalcod = int.Parse(this.txtHospital.Text);
            SqlParameter pamId = new SqlParameter("@IDDOCTOR", iddoctor);
            SqlParameter pamApe = new SqlParameter("@APELLIDO", apellido);
            SqlParameter pamEspe = new SqlParameter("@ESPECIALIDAD", especialidad);
            SqlParameter pamSal = new SqlParameter("@SALARIO", salario);
            SqlParameter pamHosp = new SqlParameter("@HOSPITAL", hospitalcod);
            this.com.Parameters.Add(pamId);
            this.com.Parameters.Add(pamApe);
            this.com.Parameters.Add(pamEspe);
            this.com.Parameters.Add(pamSal);
            this.com.Parameters.Add(pamHosp);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "ACTUALIZARDOCTOR";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
