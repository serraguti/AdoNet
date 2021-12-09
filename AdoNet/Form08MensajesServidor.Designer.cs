
namespace AdoNet
{
    partial class Form08MensajesServidor
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.btnNuevoDepartamento = new System.Windows.Forms.Button();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstDepartamentos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(24, 63);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 43);
            this.txtNumero.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(24, 155);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(243, 43);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Localidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(24, 257);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(243, 43);
            this.txtLocalidad.TabIndex = 5;
            // 
            // btnNuevoDepartamento
            // 
            this.btnNuevoDepartamento.Location = new System.Drawing.Point(24, 316);
            this.btnNuevoDepartamento.Name = "btnNuevoDepartamento";
            this.btnNuevoDepartamento.Size = new System.Drawing.Size(243, 84);
            this.btnNuevoDepartamento.TabIndex = 6;
            this.btnNuevoDepartamento.Text = "Nuevo departamento";
            this.btnNuevoDepartamento.UseVisualStyleBackColor = true;
            // 
            // lblMensajes
            // 
            this.lblMensajes.AutoSize = true;
            this.lblMensajes.ForeColor = System.Drawing.Color.Red;
            this.lblMensajes.Location = new System.Drawing.Point(24, 426);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(157, 37);
            this.lblMensajes.TabIndex = 7;
            this.lblMensajes.Text = "lblMensajes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "Departamentos";
            // 
            // lstDepartamentos
            // 
            this.lstDepartamentos.FormattingEnabled = true;
            this.lstDepartamentos.ItemHeight = 37;
            this.lstDepartamentos.Items.AddRange(new object[] {
            "10 - CONTABILIDAD - ELCHE",
            "20 - INVESTIGACION - MADRID"});
            this.lstDepartamentos.Location = new System.Drawing.Point(291, 67);
            this.lstDepartamentos.Name = "lstDepartamentos";
            this.lstDepartamentos.Size = new System.Drawing.Size(509, 337);
            this.lstDepartamentos.TabIndex = 9;
            // 
            // Form08MensajesServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 484);
            this.Controls.Add(this.lstDepartamentos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMensajes);
            this.Controls.Add(this.btnNuevoDepartamento);
            this.Controls.Add(this.txtLocalidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form08MensajesServidor";
            this.Text = "Form08MensajesServidor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Button btnNuevoDepartamento;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstDepartamentos;
    }
}