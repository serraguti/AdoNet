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
    public partial class Form14HospitalPlantilla : Form
    {
        HospitalPlantillaContext context;

        public Form14HospitalPlantilla()
        {
            InitializeComponent();
            this.context = new HospitalPlantillaContext();
            int posy = 20;
            List<Hospital> hospitales = this.context.GetHospitales();
            foreach (Hospital h in hospitales)
            {
                CheckBox chk = new CheckBox();
                chk.Text = h.Nombre;
                chk.Tag = h.IdHospital;
                chk.Location = new Point(10, posy);
                chk.AutoSize = true;
                posy += 50;
                chk.CheckedChanged += MostrarPlantilla;
                this.panelHospitales.Controls.Add(chk);
            }
        }

        private void MostrarPlantilla(object sender, EventArgs e)
        {
            this.lsvPlantilla.Items.Clear();
            List<int> hospitales = new List<int>();
            foreach (Control c in this.panelHospitales.Controls)
            {
                CheckBox chk = (CheckBox)c;
                if (chk.Checked == true)
                {
                    int codigo = int.Parse(chk.Tag.ToString());
                    hospitales.Add(codigo);
                }
            }
            
            if (hospitales.Count != 0)
            {
                List<Plantilla> plantillas =
                                    this.context.GetPlantillaHospitales(hospitales);
                
                foreach (Plantilla p in plantillas)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = p.Apellido;
                    item.Tag = p.IdPlantilla;
                    item.SubItems.Add(p.Funcion);
                    item.SubItems.Add(p.Salario.ToString());
                    item.SubItems.Add(p.Hospital.ToString());
                    this.lsvPlantilla.Items.Add(item);
                }
            }
        }
    }
}
