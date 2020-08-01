namespace Pventas.formas
{
    partial class frmclientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmclientes));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtteleono = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.cboxclientee = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.cboxgrupos = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domicilio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Localidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "E-mail:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(122, 41);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(76, 20);
            this.txtclave.TabIndex = 7;
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtclave_KeyPress);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(122, 74);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(177, 20);
            this.txtnombre.TabIndex = 8;
            this.txtnombre.TextChanged += new System.EventHandler(this.Txtnombre_TextChanged);
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyDown);
            this.txtnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyUp);
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.Enabled = false;
            this.txtdomicilio.Location = new System.Drawing.Point(122, 114);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(177, 20);
            this.txtdomicilio.TabIndex = 9;
            this.txtdomicilio.TextChanged += new System.EventHandler(this.Txtdomicilio_TextChanged);
            this.txtdomicilio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtdomicilio_KeyDown);
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Location = new System.Drawing.Point(122, 151);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(207, 20);
            this.txtlocalidad.TabIndex = 10;
            this.txtlocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtlocalidad_KeyDown);
            // 
            // txtteleono
            // 
            this.txtteleono.Enabled = false;
            this.txtteleono.Location = new System.Drawing.Point(122, 186);
            this.txtteleono.Name = "txtteleono";
            this.txtteleono.Size = new System.Drawing.Size(148, 20);
            this.txtteleono.TabIndex = 11;
            this.txtteleono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtteleono_KeyDown);
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(122, 219);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 20);
            this.txtemail.TabIndex = 12;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtemail_KeyDown);
            // 
            // btngrabar
            // 
            this.btngrabar.Enabled = false;
            this.btngrabar.Location = new System.Drawing.Point(269, 351);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 14;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.Btngrabar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(387, 351);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 15;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(501, 351);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 16;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // cboxclientee
            // 
            this.cboxclientee.Enabled = false;
            this.cboxclientee.FormattingEnabled = true;
            this.cboxclientee.Location = new System.Drawing.Point(126, 265);
            this.cboxclientee.Name = "cboxclientee";
            this.cboxclientee.Size = new System.Drawing.Size(144, 21);
            this.cboxclientee.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "tipo cliente:";
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(477, 16);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(97, 13);
            this.lblbuscar.TabIndex = 21;
            this.lblbuscar.Text = "consulta de grupos";
            this.lblbuscar.Visible = false;
            // 
            // cboxgrupos
            // 
            this.cboxgrupos.FormattingEnabled = true;
            this.cboxgrupos.Location = new System.Drawing.Point(440, 43);
            this.cboxgrupos.Name = "cboxgrupos";
            this.cboxgrupos.Size = new System.Drawing.Size(166, 21);
            this.cboxgrupos.TabIndex = 20;
            this.cboxgrupos.Visible = false;
            this.cboxgrupos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cboxgrupos_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(382, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 31);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.cboxgrupos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboxclientee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtteleono);
            this.Controls.Add(this.txtlocalidad);
            this.Controls.Add(this.txtdomicilio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtclave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmclientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmclientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frmclientes_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.TextBox txtteleono;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.ComboBox cboxclientee;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.ComboBox cboxgrupos;
        private System.Windows.Forms.Button button1;
    }
}