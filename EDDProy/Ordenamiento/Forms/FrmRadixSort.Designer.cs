namespace EDDemo.Ordenamiento.Forms
{
    partial class FrmRadixSort
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
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.bntOrdenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lstRe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un Arreglo:";
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(212, 34);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(211, 22);
            this.txtDatos.TabIndex = 1;
            // 
            // bntOrdenar
            // 
            this.bntOrdenar.Location = new System.Drawing.Point(447, 28);
            this.bntOrdenar.Name = "bntOrdenar";
            this.bntOrdenar.Size = new System.Drawing.Size(79, 28);
            this.bntOrdenar.TabIndex = 2;
            this.bntOrdenar.Text = "Ordenar";
            this.bntOrdenar.UseVisualStyleBackColor = true;
            this.bntOrdenar.Click += new System.EventHandler(this.bntOrdenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado:";
            // 
            // lstRe
            // 
            this.lstRe.FormattingEnabled = true;
            this.lstRe.ItemHeight = 16;
            this.lstRe.Location = new System.Drawing.Point(212, 129);
            this.lstRe.Name = "lstRe";
            this.lstRe.Size = new System.Drawing.Size(232, 100);
            this.lstRe.TabIndex = 4;
            // 
            // FrmRadixSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 339);
            this.Controls.Add(this.lstRe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bntOrdenar);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.label1);
            this.Name = "FrmRadixSort";
            this.Text = "FrmRadixSort";
            this.Load += new System.EventHandler(this.FrmRadixSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button bntOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstRe;
    }
}