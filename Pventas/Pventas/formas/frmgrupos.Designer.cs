namespace Pventas.formas
{
    partial class frmgrupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmgrupos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbox = new System.Windows.Forms.ComboBox();
            this.cboxgrupos = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "situacion";
            this.label3.Visible = false;
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(122, 64);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(63, 20);
            this.txtclave.TabIndex = 3;
            this.txtclave.TextChanged += new System.EventHandler(this.Txtclave_TextChanged);
            this.txtclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtclave_KeyDown);
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(122, 97);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(290, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.TextChanged += new System.EventHandler(this.Txtmayuscula_TextChanged);
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyDown);
            this.txtnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyUp);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(201, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 31);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbox
            // 
            this.cbox.Enabled = false;
            this.cbox.FormattingEnabled = true;
            this.cbox.Location = new System.Drawing.Point(131, 135);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(131, 21);
            this.cbox.TabIndex = 7;
            this.cbox.Visible = false;
            // 
            // cboxgrupos
            // 
            this.cboxgrupos.FormattingEnabled = true;
            this.cboxgrupos.Location = new System.Drawing.Point(270, 64);
            this.cboxgrupos.Name = "cboxgrupos";
            this.cboxgrupos.Size = new System.Drawing.Size(166, 21);
            this.cboxgrupos.TabIndex = 8;
            this.cboxgrupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cboxgrupos_KeyPress);
            // 
            // btnguardar
            // 
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(260, 241);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(45, 32);
            this.btnguardar.TabIndex = 9;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Image = ((System.Drawing.Image)(resources.GetObject("btneliminar.Image")));
            this.btneliminar.Location = new System.Drawing.Point(311, 241);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(46, 32);
            this.btneliminar.TabIndex = 10;
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(363, 242);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(51, 31);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(296, 39);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(97, 13);
            this.lblbuscar.TabIndex = 12;
            this.lblbuscar.Text = "consulta de grupos";
            this.lblbuscar.Visible = false;
            // 
            // frmgrupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 286);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.cboxgrupos);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmgrupos";
            this.Text = "movimientos a grupos";
            this.Load += new System.EventHandler(this.Frmgrupos_Load);
            this.Click += new System.EventHandler(this.Frmgrupos_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.ComboBox cboxgrupos;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label lblbuscar;
    }
}