
namespace AdoNet
{
    partial class Form14HospitalPlantilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHospitales = new System.Windows.Forms.Panel();
            this.lsvPlantilla = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelHospitales
            // 
            this.panelHospitales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelHospitales.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHospitales.Location = new System.Drawing.Point(0, 0);
            this.panelHospitales.Name = "panelHospitales";
            this.panelHospitales.Size = new System.Drawing.Size(230, 431);
            this.panelHospitales.TabIndex = 0;
            // 
            // lsvPlantilla
            // 
            this.lsvPlantilla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvPlantilla.FullRowSelect = true;
            this.lsvPlantilla.HideSelection = false;
            this.lsvPlantilla.Location = new System.Drawing.Point(246, 51);
            this.lsvPlantilla.MultiSelect = false;
            this.lsvPlantilla.Name = "lsvPlantilla";
            this.lsvPlantilla.Size = new System.Drawing.Size(643, 368);
            this.lsvPlantilla.TabIndex = 1;
            this.lsvPlantilla.UseCompatibleStateImageBehavior = false;
            this.lsvPlantilla.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Apellido";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Función";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Salario";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hospital";
            this.columnHeader4.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Plantilla";
            // 
            // Form14HospitalPlantilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvPlantilla);
            this.Controls.Add(this.panelHospitales);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form14HospitalPlantilla";
            this.Text = "Form14HospitalPlantilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHospitales;
        private System.Windows.Forms.ListView lsvPlantilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}