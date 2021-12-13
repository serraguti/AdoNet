using AdoNet.Context;
using AdoNet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNet
{
    public partial class Form12EmpleadosOficios : Form
    {
        EmpleadosContext context;

        public Form12EmpleadosOficios()
        {
            InitializeComponent();
            this.context = new EmpleadosContext();
            List<String> oficios = this.context.GetOficios();
            foreach (string oficio in oficios)
            {
                this.cmbOficios.Items.Add(oficio);
            }
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            string oficio = this.cmbOficios.SelectedItem.ToString();
            List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
            this.lsvEmpleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                ListViewItem item = new ListViewItem();
                item.Text = emp.Apellido;
                item.SubItems.Add(emp.Oficio);
                item.SubItems.Add(emp.Salario.ToString());
                this.lsvEmpleados.Items.Add(item);
            }
        }
    }
}
