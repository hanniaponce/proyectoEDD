namespace EDDemo.Ordenamiento.Forms
{
    partial class FrmQuickSort
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
            this.lstRe = new System.Windows.Forms.ListBox();
            this.txtDatos = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese numeros";
            // 
            // lstRe
            // 
            this.lstRe.FormattingEnabled = true;
            this.lstRe.ItemHeight = 16;
            this.lstRe.Location = new System.Drawing.Point(128, 132);
            this.lstRe.Name = "lstRe";
            this.lstRe.Size = new System.Drawing.Size(278, 116);
            this.lstRe.TabIndex = 1;
            // 
            // txtDatos
            // 
            this.txtDatos.Location = new System.Drawing.Point(77, 66);
            this.txtDatos.Name = "txtDatos";
            this.txtDatos.Size = new System.Drawing.Size(278, 22);
            this.txtDatos.TabIndex = 2;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(388, 62);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(80, 30);
            this.btnOrdenar.TabIndex = 3;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // FrmQuickSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 373);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtDatos);
            this.Controls.Add(this.lstRe);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuickSort";
            this.Text = "FrmQuickSort";
            this.Load += new System.EventHandler(this.FrmQuickSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRe;
        private System.Windows.Forms.TextBox txtDatos;
        private System.Windows.Forms.Button btnOrdenar;
    }
}