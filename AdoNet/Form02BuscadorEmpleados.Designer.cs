
namespace AdoNet
{
    partial class Form02BuscadorEmpleados
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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.btnBuscarEmpleados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.btnBuscarOficios = new System.Windows.Forms.Button();
            this.txtOficio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(122, 14);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(287, 43);
            this.txtSalario.TabIndex = 1;
            // 
            // btnBuscarEmpleados
            // 
            this.btnBuscarEmpleados.Location = new System.Drawing.Point(417, 2);
            this.btnBuscarEmpleados.Name = "btnBuscarEmpleados";
            this.btnBuscarEmpleados.Size = new System.Drawing.Size(227, 55);
            this.btnBuscarEmpleados.TabIndex = 2;
            this.btnBuscarEmpleados.Text = "Buscar salarios";
            this.btnBuscarEmpleados.UseVisualStyleBackColor = true;
            this.btnBuscarEmpleados.Click += new System.EventHandler(this.btnBuscarEmpleados_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleados";
            // 
            // lstEmpleados
            // 
            this.lstEmpleados.FormattingEnabled = true;
            this.lstEmpleados.ItemHeight = 37;
            this.lstEmpleados.Location = new System.Drawing.Point(37, 186);
            this.lstEmpleados.Name = "lstEmpleados";
            this.lstEmpleados.Size = new System.Drawing.Size(552, 189);
            this.lstEmpleados.TabIndex = 4;
            // 
            // btnBuscarOficios
            // 
            this.btnBuscarOficios.Location = new System.Drawing.Point(417, 73);
            this.btnBuscarOficios.Name = "btnBuscarOficios";
            this.btnBuscarOficios.Size = new System.Drawing.Size(227, 55);
            this.btnBuscarOficios.TabIndex = 7;
            this.btnBuscarOficios.Text = "Buscar oficios";
            this.btnBuscarOficios.UseVisualStyleBackColor = true;
            this.btnBuscarOficios.Click += new System.EventHandler(this.btnBuscarOficios_Click);
            // 
            // txtOficio
            // 
            this.txtOficio.Location = new System.Drawing.Point(122, 85);
            this.txtOficio.Name = "txtOficio";
            this.txtOficio.Size = new System.Drawing.Size(287, 43);
            this.txtOficio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Oficio:";
            // 
            // Form02BuscadorEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 396);
            this.Controls.Add(this.btnBuscarOficios);
            this.Controls.Add(this.txtOficio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarEmpleados);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form02BuscadorEmpleados";
            this.Text = "Form02BuscadorEmpleados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnBuscarEmpleados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Button btnBuscarOficios;
        private System.Windows.Forms.TextBox txtOficio;
        private System.Windows.Forms.Label label3;
    }
}