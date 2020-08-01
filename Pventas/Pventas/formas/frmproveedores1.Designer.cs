namespace Pventas.formas
{
    partial class frmproveedores1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmproveedores1));
            this.lblbuscar = new System.Windows.Forms.Label();
            this.cboxlupa = new System.Windows.Forms.ComboBox();
            this.lupa = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txtdomicilio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txttwiter = new System.Windows.Forms.TextBox();
            this.TWITER = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(547, 46);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(114, 13);
            this.lblbuscar.TabIndex = 41;
            this.lblbuscar.Text = "Busqueda por nombre:";
            this.lblbuscar.Visible = false;
            // 
            // cboxlupa
            // 
            this.cboxlupa.FormattingEnabled = true;
            this.cboxlupa.Location = new System.Drawing.Point(510, 73);
            this.cboxlupa.Name = "cboxlupa";
            this.cboxlupa.Size = new System.Drawing.Size(166, 21);
            this.cboxlupa.TabIndex = 40;
            this.cboxlupa.Visible = false;
            this.cboxlupa.SelectedIndexChanged += new System.EventHandler(this.Cboxlupa_SelectedIndexChanged);
            this.cboxlupa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cboxlupa_KeyPress);
            // 
            // lupa
            // 
            this.lupa.Image = ((System.Drawing.Image)(resources.GetObject("lupa.Image")));
            this.lupa.Location = new System.Drawing.Point(452, 67);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(52, 31);
            this.lupa.TabIndex = 39;
            this.lupa.UseVisualStyleBackColor = true;
            this.lupa.Click += new System.EventHandler(this.Lupa_Click);
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(571, 381);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(75, 23);
            this.btncerrar.TabIndex = 36;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Enabled = false;
            this.btneliminar.Location = new System.Drawing.Point(457, 381);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 35;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.Btneliminar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Enabled = false;
            this.btngrabar.Location = new System.Drawing.Point(339, 381);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 23);
            this.btngrabar.TabIndex = 34;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.Btngrabar_Click);
            // 
            // txtemail
            // 
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtemail.Enabled = false;
            this.txtemail.Location = new System.Drawing.Point(192, 249);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(148, 20);
            this.txtemail.TabIndex = 33;
            this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtemail_KeyDown);
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(192, 216);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(148, 20);
            this.txttelefono.TabIndex = 32;
            this.txttelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttelefono_KeyDown);
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Location = new System.Drawing.Point(192, 181);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(207, 20);
            this.txtlocalidad.TabIndex = 31;
            this.txtlocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtlocalidad_KeyDown);
            // 
            // txtdomicilio
            // 
            this.txtdomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdomicilio.Enabled = false;
            this.txtdomicilio.Location = new System.Drawing.Point(192, 144);
            this.txtdomicilio.Name = "txtdomicilio";
            this.txtdomicilio.Size = new System.Drawing.Size(177, 20);
            this.txtdomicilio.TabIndex = 30;
            this.txtdomicilio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtdomicilio_KeyDown);
            // 
            // txtnombre
            // 
            this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(192, 104);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(177, 20);
            this.txtnombre.TabIndex = 29;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyDown);
            this.txtnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyUp);
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(192, 71);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(76, 20);
            this.txtclave.TabIndex = 28;
            this.txtclave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtclave_KeyDown);
            this.txtclave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtclave_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "E-mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Localidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Domicilio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Clave:";
            // 
            // txttwiter
            // 
            this.txttwiter.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txttwiter.Enabled = false;
            this.txttwiter.Location = new System.Drawing.Point(192, 298);
            this.txttwiter.Name = "txttwiter";
            this.txttwiter.Size = new System.Drawing.Size(148, 20);
            this.txttwiter.TabIndex = 43;
            this.txttwiter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txttwiter_KeyDown);
            // 
            // TWITER
            // 
            this.TWITER.AutoSize = true;
            this.TWITER.Location = new System.Drawing.Point(148, 298);
            this.TWITER.Name = "TWITER";
            this.TWITER.Size = new System.Drawing.Size(39, 13);
            this.TWITER.TabIndex = 42;
            this.TWITER.Text = "Twiter:";
            // 
            // frmproveedores1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txttwiter);
            this.Controls.Add(this.TWITER);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.cboxlupa);
            this.Controls.Add(this.lupa);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txttelefono);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmproveedores1";
            this.Text = "Captura de proveedores";
            this.Load += new System.EventHandler(this.Frmproveedores1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.ComboBox cboxlupa;
        private System.Windows.Forms.Button lupa;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.TextBox txtdomicilio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttwiter;
        private System.Windows.Forms.Label TWITER;
    }
}