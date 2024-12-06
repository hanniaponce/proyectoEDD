namespace EDDemo.Busqueda.Forms
{
    partial class FrmHash
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstRe = new System.Windows.Forms.ListBox();
            this.btnArch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Buscar:";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(100, 31);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(145, 22);
            this.txtClave.TabIndex = 3;
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(100, 83);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(145, 22);
            this.txtVal.TabIndex = 4;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(100, 127);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(145, 22);
            this.txtBuscar.TabIndex = 5;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(297, 34);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(95, 37);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(297, 112);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 37);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lstRe
            // 
            this.lstRe.FormattingEnabled = true;
            this.lstRe.ItemHeight = 16;
            this.lstRe.Location = new System.Drawing.Point(100, 188);
            this.lstRe.Name = "lstRe";
            this.lstRe.Size = new System.Drawing.Size(292, 132);
            this.lstRe.TabIndex = 8;
            // 
            // btnArch
            // 
            this.btnArch.Location = new System.Drawing.Point(218, 326);
            this.btnArch.Name = "btnArch";
            this.btnArch.Size = new System.Drawing.Size(91, 36);
            this.btnArch.TabIndex = 9;
            this.btnArch.Text = "Cargar";
            this.btnArch.UseVisualStyleBackColor = true;
            this.btnArch.Click += new System.EventHandler(this.btnArch_Click);
            // 
            // FrmHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 389);
            this.Controls.Add(this.btnArch);
            this.Controls.Add(this.lstRe);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmHash";
            this.Text = "FrmHash";
            this.Load += new System.EventHandler(this.FrmHash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ListBox lstRe;
        private System.Windows.Forms.Button btnArch;
    }
}