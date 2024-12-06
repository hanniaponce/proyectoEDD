namespace EDDemo.Estructuras_Lineales.Forms
{
    partial class Dobles
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
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnVerList = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un dato:";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(128, 64);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(146, 22);
            this.txtDato.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(40, 114);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(106, 34);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Lista";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnVerList
            // 
            this.btnVerList.Location = new System.Drawing.Point(243, 114);
            this.btnVerList.Name = "btnVerList";
            this.btnVerList.Size = new System.Drawing.Size(106, 34);
            this.btnVerList.TabIndex = 3;
            this.btnVerList.Text = "Ver lista ID";
            this.btnVerList.UseVisualStyleBackColor = true;
            this.btnVerList.Click += new System.EventHandler(this.btnVerList_Click);
            // 
            // txtList
            // 
            this.txtList.Location = new System.Drawing.Point(55, 206);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(279, 22);
            this.txtList.TabIndex = 4;
            this.txtList.TextChanged += new System.EventHandler(this.txtList_TextChanged);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(55, 282);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(91, 30);
            this.btnInsertar.TabIndex = 5;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(243, 282);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 30);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Dobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 387);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnVerList);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.label1);
            this.Name = "Dobles";
            this.Text = "Dobles";
            this.Load += new System.EventHandler(this.Dobles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnVerList;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
    }
}