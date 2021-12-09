using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Form09UpdateInsertDoctor()
        {
            InitializeComponent();
        }
    }
}
