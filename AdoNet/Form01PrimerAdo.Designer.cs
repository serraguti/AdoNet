
namespace AdoNet
{
    partial class Form01PrimerAdo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnLeerDatos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lstApellidos = new System.Windows.Forms.ListBox();
            this.lstColumnas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstTiposDato = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(12, 13);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(175, 61);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(12, 97);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(175, 67);
            this.btnDesconectar.TabIndex = 1;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnLeerDatos
            // 
            this.btnLeerDatos.Location = new System.Drawing.Point(12, 182);
            this.btnLeerDatos.Name = "btnLeerDatos";
            this.btnLeerDatos.Size = new System.Drawing.Size(175, 52);
            this.btnLeerDatos.TabIndex = 2;
            this.btnLeerDatos.Text = "Leer datos";
            this.btnLeerDatos.UseVisualStyleBackColor = true;
            this.btnLeerDatos.Click += new System.EventHandler(this.btnLeerDatos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Apellidos";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Blue;
            this.lblMensaje.Location = new System.Drawing.Point(12, 433);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(146, 37);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "lblMensaje";
            // 
            // lstApellidos
            // 
            this.lstApellidos.FormattingEnabled = true;
            this.lstApellidos.ItemHeight = 37;
            this.lstApellidos.Location = new System.Drawing.Point(212, 50);
            this.lstApellidos.Name = "lstApellidos";
            this.lstApellidos.Size = new System.Drawing.Size(210, 374);
            this.lstApellidos.TabIndex = 5;
            // 
            // lstColumnas
            // 
            this.lstColumnas.FormattingEnabled = true;
            this.lstColumnas.ItemHeight = 37;
            this.lstColumnas.Location = new System.Drawing.Point(452, 50);
            this.lstColumnas.Name = "lstColumnas";
            this.lstColumnas.Size = new System.Drawing.Size(210, 374);
            this.lstColumnas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 37);
            this.label2.TabIndex = 6;
            this.label2.Text = "Columnas";
            // 
            // lstTiposDato
            // 
            this.lstTiposDato.FormattingEnabled = true;
            this.lstTiposDato.ItemHeight = 37;
            this.lstTiposDato.Location = new System.Drawing.Point(691, 50);
            this.lstTiposDato.Name = "lstTiposDato";
            this.lstTiposDato.Size = new System.Drawing.Size(210, 374);
            this.lstTiposDato.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 37);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tipos Dato";
            // 
            // Form01PrimerAdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 479);
            this.Controls.Add(this.lstTiposDato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstColumnas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstApellidos);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLeerDatos);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnConectar);
            this.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form01PrimerAdo";
            this.Text = "Form01PrimerAdo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnLeerDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ListBox lstApellidos;
        private System.Windows.Forms.ListBox lstColumnas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstTiposDato;
        private System.Windows.Forms.Label label3;
    }
}

