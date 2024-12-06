namespace EDDemo.Estructuras_Lineales.Forms
{
    partial class Pilas
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.lstPilas = new System.Windows.Forms.ListBox();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un dato:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(131, 83);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(194, 22);
            this.txtDato.TabIndex = 1;
            // 
            // lstPilas
            // 
            this.lstPilas.FormattingEnabled = true;
            this.lstPilas.ItemHeight = 16;
            this.lstPilas.Location = new System.Drawing.Point(173, 131);
            this.lstPilas.Name = "lstPilas";
            this.lstPilas.Size = new System.Drawing.Size(120, 164);
            this.lstPilas.TabIndex = 2;
            this.lstPilas.SelectedIndexChanged += new System.EventHandler(this.lstPilas_SelectedIndexChanged);
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(97, 333);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(88, 33);
            this.btnPush.TabIndex = 3;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(237, 333);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(88, 33);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // Pilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 411);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.lstPilas);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Name = "Pilas";
            this.Text = "Pilas";
            this.Load += new System.EventHandler(this.Pilas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ListBox lstPilas;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
    }
}