namespace EDDemo.Ordenamiento.Forms
{
    partial class FrmShellSort
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
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.lstRe = new System.Windows.Forms.ListBox();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese diferentes Numeros:";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(389, 70);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(84, 29);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // lstRe
            // 
            this.lstRe.FormattingEnabled = true;
            this.lstRe.ItemHeight = 16;
            this.lstRe.Location = new System.Drawing.Point(124, 145);
            this.lstRe.Name = "lstRe";
            this.lstRe.Size = new System.Drawing.Size(275, 116);
            this.lstRe.TabIndex = 2;
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(89, 73);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(275, 22);
            this.txtDato.TabIndex = 3;
            // 
            // FrmShellSort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 354);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.lstRe);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label1);
            this.Name = "FrmShellSort";
            this.Text = "FrmShellSort";
            this.Load += new System.EventHandler(this.FrmShellSort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ListBox lstRe;
        private System.Windows.Forms.TextBox txtDato;
    }
}