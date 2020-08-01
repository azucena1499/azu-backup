namespace Pventas.formas
{
    partial class frmcatalogos
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
            this.gpbcatalogos = new System.Windows.Forms.GroupBox();
            this.rdbclientes = new System.Windows.Forms.RadioButton();
            this.rdbarticulo = new System.Windows.Forms.RadioButton();
            this.rdbgrupos = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbimpresora = new System.Windows.Forms.RadioButton();
            this.rdbpantalla = new System.Windows.Forms.RadioButton();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.gpbordenada = new System.Windows.Forms.GroupBox();
            this.rdbclave = new System.Windows.Forms.RadioButton();
            this.rdbnombre = new System.Windows.Forms.RadioButton();
            this.gpbcatalogos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gpbordenada.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbcatalogos
            // 
            this.gpbcatalogos.Controls.Add(this.rdbclientes);
            this.gpbcatalogos.Controls.Add(this.rdbarticulo);
            this.gpbcatalogos.Controls.Add(this.rdbgrupos);
            this.gpbcatalogos.Location = new System.Drawing.Point(43, 38);
            this.gpbcatalogos.Name = "gpbcatalogos";
            this.gpbcatalogos.Size = new System.Drawing.Size(126, 98);
            this.gpbcatalogos.TabIndex = 0;
            this.gpbcatalogos.TabStop = false;
            this.gpbcatalogos.Text = "Selecciona";
            // 
            // rdbclientes
            // 
            this.rdbclientes.AutoSize = true;
            this.rdbclientes.Location = new System.Drawing.Point(16, 43);
            this.rdbclientes.Name = "rdbclientes";
            this.rdbclientes.Size = new System.Drawing.Size(62, 17);
            this.rdbclientes.TabIndex = 1;
            this.rdbclientes.Text = "Clientes";
            this.rdbclientes.UseVisualStyleBackColor = true;
            this.rdbclientes.Click += new System.EventHandler(this.rdbclientes_Click);
            // 
            // rdbarticulo
            // 
            this.rdbarticulo.AutoSize = true;
            this.rdbarticulo.Location = new System.Drawing.Point(16, 66);
            this.rdbarticulo.Name = "rdbarticulo";
            this.rdbarticulo.Size = new System.Drawing.Size(60, 17);
            this.rdbarticulo.TabIndex = 0;
            this.rdbarticulo.Text = "Articulo";
            this.rdbarticulo.UseVisualStyleBackColor = true;
            this.rdbarticulo.Click += new System.EventHandler(this.rdbarticulo_Click);
            // 
            // rdbgrupos
            // 
            this.rdbgrupos.AutoSize = true;
            this.rdbgrupos.Checked = true;
            this.rdbgrupos.Location = new System.Drawing.Point(16, 20);
            this.rdbgrupos.Name = "rdbgrupos";
            this.rdbgrupos.Size = new System.Drawing.Size(59, 17);
            this.rdbgrupos.TabIndex = 0;
            this.rdbgrupos.TabStop = true;
            this.rdbgrupos.Text = "Grupos";
            this.rdbgrupos.UseVisualStyleBackColor = true;
            this.rdbgrupos.Click += new System.EventHandler(this.rdbgrupos_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbimpresora);
            this.groupBox2.Controls.Add(this.rdbpantalla);
            this.groupBox2.Location = new System.Drawing.Point(218, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "consultada por:";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // rdbimpresora
            // 
            this.rdbimpresora.AutoSize = true;
            this.rdbimpresora.Location = new System.Drawing.Point(16, 54);
            this.rdbimpresora.Name = "rdbimpresora";
            this.rdbimpresora.Size = new System.Drawing.Size(71, 17);
            this.rdbimpresora.TabIndex = 1;
            this.rdbimpresora.Text = "Impresora";
            this.rdbimpresora.UseVisualStyleBackColor = true;
            // 
            // rdbpantalla
            // 
            this.rdbpantalla.AutoSize = true;
            this.rdbpantalla.Checked = true;
            this.rdbpantalla.Location = new System.Drawing.Point(16, 20);
            this.rdbpantalla.Name = "rdbpantalla";
            this.rdbpantalla.Size = new System.Drawing.Size(63, 17);
            this.rdbpantalla.TabIndex = 0;
            this.rdbpantalla.TabStop = true;
            this.rdbpantalla.Text = "Pantalla";
            this.rdbpantalla.UseVisualStyleBackColor = true;
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(446, 311);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(75, 23);
            this.btnimprimir.TabIndex = 2;
            this.btnimprimir.Text = "Imprimir";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.Btnimprimir_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(543, 311);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 3;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // gpbordenada
            // 
            this.gpbordenada.Controls.Add(this.rdbclave);
            this.gpbordenada.Controls.Add(this.rdbnombre);
            this.gpbordenada.Location = new System.Drawing.Point(371, 38);
            this.gpbordenada.Name = "gpbordenada";
            this.gpbordenada.Size = new System.Drawing.Size(126, 98);
            this.gpbordenada.TabIndex = 4;
            this.gpbordenada.TabStop = false;
            this.gpbordenada.Text = "ordenada por:";
            this.gpbordenada.Visible = false;
            this.gpbordenada.Enter += new System.EventHandler(this.gpbordenada_Enter);
            // 
            // rdbclave
            // 
            this.rdbclave.AutoSize = true;
            this.rdbclave.Location = new System.Drawing.Point(16, 43);
            this.rdbclave.Name = "rdbclave";
            this.rdbclave.Size = new System.Drawing.Size(52, 17);
            this.rdbclave.TabIndex = 3;
            this.rdbclave.Text = "Clave";
            this.rdbclave.UseVisualStyleBackColor = true;
            // 
            // rdbnombre
            // 
            this.rdbnombre.AutoSize = true;
            this.rdbnombre.Checked = true;
            this.rdbnombre.Location = new System.Drawing.Point(16, 20);
            this.rdbnombre.Name = "rdbnombre";
            this.rdbnombre.Size = new System.Drawing.Size(62, 17);
            this.rdbnombre.TabIndex = 2;
            this.rdbnombre.TabStop = true;
            this.rdbnombre.Text = "Nombre";
            this.rdbnombre.UseVisualStyleBackColor = true;
            // 
            // frmcatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbordenada);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gpbcatalogos);
            this.Name = "frmcatalogos";
            this.Text = "frmcatalogos";
            this.Load += new System.EventHandler(this.frmcatalogos_Load);
            this.gpbcatalogos.ResumeLayout(false);
            this.gpbcatalogos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gpbordenada.ResumeLayout(false);
            this.gpbordenada.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbcatalogos;
        private System.Windows.Forms.RadioButton rdbclientes;
        private System.Windows.Forms.RadioButton rdbgrupos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbimpresora;
        private System.Windows.Forms.RadioButton rdbpantalla;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.RadioButton rdbarticulo;
        private System.Windows.Forms.GroupBox gpbordenada;
        private System.Windows.Forms.RadioButton rdbclave;
        private System.Windows.Forms.RadioButton rdbnombre;
    }
}