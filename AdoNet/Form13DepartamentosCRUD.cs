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
    public partial class Form13DepartamentosCRUD : Form
    {
        DepartamentosContext context;

        public Form13DepartamentosCRUD()
        {
            InitializeComponent();
            this.context = new DepartamentosContext();
            this.CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            List<Departamento> departamentos = this.context.GetDepartamentos();
            this.lsvDepartamentos.Items.Clear();
            foreach (Departamento dept in departamentos)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = dept.IdDepartamento;
                item.Text = dept.Nombre;
                item.SubItems.Add(dept.Localidad);
                this.lsvDepartamentos.Items.Add(item);
            }
        }

        private void lsvDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsvDepartamentos.SelectedItems.Count != 0)
            {
                ListViewItem seleccionado = this.lsvDepartamentos.SelectedItems[0];
                this.txtNumero.Text = seleccionado.Tag.ToString();
                this.txtNombre.Text = seleccionado.SubItems[0].Text;
                this.txtLocalidad.Text = seleccionado.SubItems[1].Text;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.context.InsertarDepartamento(numero, nombre, localidad);
            this.CargarDepartamentos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLocalidad.Text;
            this.context.ModificarDepartamento(num, nombre, localidad);
            this.CargarDepartamentos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtNumero.Text);
            this.context.EliminarDepartamento(id);
            this.CargarDepartamentos();
        }
    }
}
