﻿
namespace AdoNet
{
    partial class Form07IncrementarSalariosProcedure
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHospitales = new System.Windows.Forms.ComboBox();
            this.btnModificarSalarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPlantilla = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospitales";
            // 
            // cmbHospitales
            // 
            this.cmbHospitales.FormattingEnabled = true;
            this.cmbHospitales.Location = new System.Drawing.Point(32, 54);
            this.cmbHospitales.Name = "cmbHospitales";
            this.cmbHospitales.Size = new System.Drawing.Size(284, 45);
            this.cmbHospitales.TabIndex = 1;
            // 
            // btnModificarSalarios
            // 
            this.btnModificarSalarios.Location = new System.Drawing.Point(363, 54);
            this.btnModificarSalarios.Name = "btnModificarSalarios";
            this.btnModificarSalarios.Size = new System.Drawing.Size(243, 45);
            this.btnModificarSalarios.TabIndex = 2;
            this.btnModificarSalarios.Text = "Modificar Salarios";
            this.btnModificarSalarios.UseVisualStyleBackColor = true;
            this.btnModificarSalarios.Click += new System.EventHandler(this.btnModificarSalarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Plantilla";
            // 
            // lstPlantilla
            // 
            this.lstPlantilla.FormattingEnabled = true;
            this.lstPlantilla.ItemHeight = 37;
            this.lstPlantilla.Location = new System.Drawing.Point(32, 179);
            this.lstPlantilla.Name = "lstPlantilla";
            this.lstPlantilla.Size = new System.Drawing.Size(579, 189);
            this.lstPlantilla.TabIndex = 4;
            // 
            // Form07IncrementarSalariosProcedure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 392);
            this.Controls.Add(this.lstPlantilla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificarSalarios);
            this.Controls.Add(this.cmbHospitales);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form07IncrementarSalariosProcedure";
            this.Text = "Form07IncrementarSalariosProcedure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHospitales;
        private System.Windows.Forms.Button btnModificarSalarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPlantilla;
    }
}