
namespace AdoNet
{
    partial class Form05ModificarSalas
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
            this.lstSalas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoNombre = new System.Windows.Forms.TextBox();
            this.btnModificarSalas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salas";
            // 
            // lstSalas
            // 
            this.lstSalas.FormattingEnabled = true;
            this.lstSalas.ItemHeight = 37;
            this.lstSalas.Location = new System.Drawing.Point(31, 54);
            this.lstSalas.Name = "lstSalas";
            this.lstSalas.Size = new System.Drawing.Size(290, 263);
            this.lstSalas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nuevo nombre";
            // 
            // txtNuevoNombre
            // 
            this.txtNuevoNombre.Location = new System.Drawing.Point(345, 54);
            this.txtNuevoNombre.Name = "txtNuevoNombre";
            this.txtNuevoNombre.Size = new System.Drawing.Size(247, 43);
            this.txtNuevoNombre.TabIndex = 3;
            // 
            // btnModificarSalas
            // 
            this.btnModificarSalas.Location = new System.Drawing.Point(345, 121);
            this.btnModificarSalas.Name = "btnModificarSalas";
            this.btnModificarSalas.Size = new System.Drawing.Size(247, 65);
            this.btnModificarSalas.TabIndex = 4;
            this.btnModificarSalas.Text = "Modificar sala";
            this.btnModificarSalas.UseVisualStyleBackColor = true;
            this.btnModificarSalas.Click += new System.EventHandler(this.btnModificarSalas_Click);
            // 
            // Form05ModificarSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 350);
            this.Controls.Add(this.btnModificarSalas);
            this.Controls.Add(this.txtNuevoNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSalas);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form05ModificarSalas";
            this.Text = "Form05ModificarSalas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSalas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevoNombre;
        private System.Windows.Forms.Button btnModificarSalas;
    }
}