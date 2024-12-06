
namespace EDDemo.Estructuras_No_Lineales
{
    partial class frmArboles
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtArbol = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnRecorrer = new System.Windows.Forms.Button();
            this.btnCompleto = new System.Windows.Forms.Button();
            this.btnHojas = new System.Windows.Forms.Button();
            this.btnNiveles = new System.Windows.Forms.Button();
            this.btnPodar = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnSuc = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnAltura = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblPre = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.lblAlt = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblCom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(77, 18);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(68, 32);
            this.txtDato.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(165, 18);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 34);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Insertar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtArbol
            // 
            this.txtArbol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArbol.Location = new System.Drawing.Point(8, 274);
            this.txtArbol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArbol.Multiline = true;
            this.txtArbol.Name = "txtArbol";
            this.txtArbol.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtArbol.Size = new System.Drawing.Size(888, 356);
            this.txtArbol.TabIndex = 2;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(276, 18);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 32);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(165, 66);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(88, 33);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear arbol";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnRecorrer
            // 
            this.btnRecorrer.Location = new System.Drawing.Point(165, 115);
            this.btnRecorrer.Name = "btnRecorrer";
            this.btnRecorrer.Size = new System.Drawing.Size(88, 32);
            this.btnRecorrer.TabIndex = 4;
            this.btnRecorrer.Text = "Recorrer";
            this.btnRecorrer.UseVisualStyleBackColor = true;
            this.btnRecorrer.Click += new System.EventHandler(this.btnRecorrer_Click);
            // 
            // btnCompleto
            // 
            this.btnCompleto.Location = new System.Drawing.Point(567, 213);
            this.btnCompleto.Name = "btnCompleto";
            this.btnCompleto.Size = new System.Drawing.Size(88, 32);
            this.btnCompleto.TabIndex = 5;
            this.btnCompleto.Text = "Completo";
            this.btnCompleto.UseVisualStyleBackColor = true;
            this.btnCompleto.Click += new System.EventHandler(this.btnCompleto_Click);
            // 
            // btnHojas
            // 
            this.btnHojas.Location = new System.Drawing.Point(462, 18);
            this.btnHojas.Name = "btnHojas";
            this.btnHojas.Size = new System.Drawing.Size(88, 32);
            this.btnHojas.TabIndex = 6;
            this.btnHojas.Text = "Hojas";
            this.btnHojas.UseVisualStyleBackColor = true;
            this.btnHojas.Click += new System.EventHandler(this.btnHojas_Click);
            // 
            // btnNiveles
            // 
            this.btnNiveles.Location = new System.Drawing.Point(567, 163);
            this.btnNiveles.Name = "btnNiveles";
            this.btnNiveles.Size = new System.Drawing.Size(88, 30);
            this.btnNiveles.TabIndex = 7;
            this.btnNiveles.Text = "Niveles";
            this.btnNiveles.UseVisualStyleBackColor = true;
            this.btnNiveles.Click += new System.EventHandler(this.btnNiveles_Click);
            // 
            // btnPodar
            // 
            this.btnPodar.Location = new System.Drawing.Point(567, 18);
            this.btnPodar.Name = "btnPodar";
            this.btnPodar.Size = new System.Drawing.Size(88, 34);
            this.btnPodar.TabIndex = 8;
            this.btnPodar.Text = "Podar";
            this.btnPodar.UseVisualStyleBackColor = true;
            this.btnPodar.Click += new System.EventHandler(this.btnPodar_Click);
            // 
            // btnGrafica
            // 
            this.btnGrafica.Location = new System.Drawing.Point(567, 71);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(88, 31);
            this.btnGrafica.TabIndex = 9;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = true;
            this.btnGrafica.Click += new System.EventHandler(this.btnGrafica_Click);
            // 
            // btnSuc
            // 
            this.btnSuc.Location = new System.Drawing.Point(672, 70);
            this.btnSuc.Name = "btnSuc";
            this.btnSuc.Size = new System.Drawing.Size(88, 34);
            this.btnSuc.TabIndex = 10;
            this.btnSuc.Text = "Sucesor";
            this.btnSuc.UseVisualStyleBackColor = true;
            this.btnSuc.Click += new System.EventHandler(this.btnSuc_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(672, 16);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(88, 34);
            this.btnPre.TabIndex = 11;
            this.btnPre.Text = "Predecesor";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnAltura
            // 
            this.btnAltura.Location = new System.Drawing.Point(567, 117);
            this.btnAltura.Name = "btnAltura";
            this.btnAltura.Size = new System.Drawing.Size(88, 30);
            this.btnAltura.TabIndex = 12;
            this.btnAltura.Text = "Altura";
            this.btnAltura.UseVisualStyleBackColor = true;
            this.btnAltura.Click += new System.EventHandler(this.btnAltura_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(462, 74);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(88, 30);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(77, 66);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(68, 27);
            this.txtNumero.TabIndex = 14;
            this.txtNumero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Dato:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(273, 73);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(68, 16);
            this.lbl1.TabIndex = 16;
            this.lbl1.Text = "PreOrden:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(273, 106);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(57, 16);
            this.lbl2.TabIndex = 17;
            this.lbl2.Text = "InOrden:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(273, 143);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(74, 16);
            this.lbl3.TabIndex = 18;
            this.lbl3.Text = "PostOrden:";
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Location = new System.Drawing.Point(357, 74);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(71, 16);
            this.lblPre.TabIndex = 19;
            this.lblPre.Text = "PostOrden";
            // 
            // lblIn
            // 
            this.lblIn.AutoSize = true;
            this.lblIn.Location = new System.Drawing.Point(357, 106);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(71, 16);
            this.lblIn.TabIndex = 20;
            this.lblIn.Text = "PostOrden";
            // 
            // lblPost
            // 
            this.lblPost.AutoSize = true;
            this.lblPost.Location = new System.Drawing.Point(357, 143);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(71, 16);
            this.lblPost.TabIndex = 21;
            this.lblPost.Text = "PostOrden";
            // 
            // lblAlt
            // 
            this.lblAlt.AutoSize = true;
            this.lblAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlt.Location = new System.Drawing.Point(483, 129);
            this.lblAlt.Name = "lblAlt";
            this.lblAlt.Size = new System.Drawing.Size(45, 18);
            this.lblAlt.TabIndex = 22;
            this.lblAlt.Text = "Altura";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.Location = new System.Drawing.Point(483, 175);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(56, 18);
            this.lblNivel.TabIndex = 23;
            this.lblNivel.Text = "Niveles";
            // 
            // lblCom
            // 
            this.lblCom.AutoSize = true;
            this.lblCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCom.Location = new System.Drawing.Point(477, 219);
            this.lblCom.Name = "lblCom";
            this.lblCom.Size = new System.Drawing.Size(73, 18);
            this.lblCom.TabIndex = 24;
            this.lblCom.Text = "Completo";
            // 
            // frmArboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 641);
            this.Controls.Add(this.lblCom);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.lblAlt);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblIn);
            this.Controls.Add(this.lblPre);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAltura);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnSuc);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnPodar);
            this.Controls.Add(this.btnNiveles);
            this.Controls.Add(this.btnHojas);
            this.Controls.Add(this.btnCompleto);
            this.Controls.Add(this.btnRecorrer);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtArbol);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtDato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmArboles";
            this.Text = "frmArboles";
            ((System.ComponentModel.ISupportInitialize)(this.txtNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtArbol;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnRecorrer;
        private System.Windows.Forms.Button btnCompleto;
        private System.Windows.Forms.Button btnHojas;
        private System.Windows.Forms.Button btnNiveles;
        private System.Windows.Forms.Button btnPodar;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnSuc;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnAltura;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.NumericUpDown txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.Label lblAlt;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblCom;
    }
}