namespace Pventas.formas
{
    partial class frmventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmventa));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtlocalidad = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfolio = new System.Windows.Forms.TextBox();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.rdbtncontado = new System.Windows.Forms.RadioButton();
            this.rdbtncreito = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.cbxcliente = new System.Windows.Forms.ComboBox();
            this.txtnombree = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpreciou = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtimporte = new System.Windows.Forms.TextBox();
            this.gpboxtipo = new System.Windows.Forms.GroupBox();
            this.dgvventa = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciounitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.btntotalizar = new System.Windows.Forms.Button();
            this.btndeshacer = new System.Windows.Forms.Button();
            this.btncerrar = new System.Windows.Forms.Button();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtpagoca = new System.Windows.Forms.Label();
            this.txtcambio = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbox2 = new System.Windows.Forms.ComboBox();
            this.gpboxinfo = new System.Windows.Forms.GroupBox();
            this.lbllupa = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpboxtipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).BeginInit();
            this.gpboxinfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Localidad";
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(56, 19);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(87, 20);
            this.txtcliente.TabIndex = 3;
            this.txtcliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcliente_KeyDown);
            this.txtcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcliente_KeyPress);
            this.txtcliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtcliente_KeyUp);
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(66, 67);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(160, 20);
            this.txtnombre.TabIndex = 4;
            this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtnombre_KeyDown);
            // 
            // txtlocalidad
            // 
            this.txtlocalidad.Enabled = false;
            this.txtlocalidad.Location = new System.Drawing.Point(66, 105);
            this.txtlocalidad.Name = "txtlocalidad";
            this.txtlocalidad.Size = new System.Drawing.Size(160, 20);
            this.txtlocalidad.TabIndex = 5;
            this.txtlocalidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtlocalidad_KeyDown);
            // 
            // txttelefono
            // 
            this.txttelefono.Enabled = false;
            this.txttelefono.Location = new System.Drawing.Point(66, 138);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(160, 20);
            this.txttelefono.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Folio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Articulo";
            // 
            // txtfolio
            // 
            this.txtfolio.Enabled = false;
            this.txtfolio.Location = new System.Drawing.Point(659, 33);
            this.txtfolio.Name = "txtfolio";
            this.txtfolio.Size = new System.Drawing.Size(57, 20);
            this.txtfolio.TabIndex = 10;
            // 
            // dtpfecha
            // 
            this.dtpfecha.Enabled = false;
            this.dtpfecha.Location = new System.Drawing.Point(635, 79);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(153, 20);
            this.dtpfecha.TabIndex = 11;
            // 
            // rdbtncontado
            // 
            this.rdbtncontado.AutoSize = true;
            this.rdbtncontado.Location = new System.Drawing.Point(11, 19);
            this.rdbtncontado.Name = "rdbtncontado";
            this.rdbtncontado.Size = new System.Drawing.Size(65, 16);
            this.rdbtncontado.TabIndex = 13;
            this.rdbtncontado.TabStop = true;
            this.rdbtncontado.Text = "Contado";
            this.rdbtncontado.UseVisualStyleBackColor = true;
            this.rdbtncontado.Click += new System.EventHandler(this.Rdbtncontado_Click);
            // 
            // rdbtncreito
            // 
            this.rdbtncreito.AutoSize = true;
            this.rdbtncreito.Location = new System.Drawing.Point(11, 41);
            this.rdbtncreito.Name = "rdbtncreito";
            this.rdbtncreito.Size = new System.Drawing.Size(60, 16);
            this.rdbtncreito.TabIndex = 14;
            this.rdbtncreito.TabStop = true;
            this.rdbtncreito.Text = "Credito";
            this.rdbtncreito.UseVisualStyleBackColor = true;
            this.rdbtncreito.Click += new System.EventHandler(this.Rdbtncreito_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(121, 234);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(58, 20);
            this.txtcodigo.TabIndex = 17;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcodigo_KeyPress);
            // 
            // cbxcliente
            // 
            this.cbxcliente.FormattingEnabled = true;
            this.cbxcliente.Location = new System.Drawing.Point(207, 22);
            this.cbxcliente.Name = "cbxcliente";
            this.cbxcliente.Size = new System.Drawing.Size(153, 20);
            this.cbxcliente.TabIndex = 19;
            this.cbxcliente.Visible = false;
            this.cbxcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbxcliente_KeyPress);
            // 
            // txtnombree
            // 
            this.txtnombree.Enabled = false;
            this.txtnombree.Location = new System.Drawing.Point(123, 270);
            this.txtnombree.Name = "txtnombree";
            this.txtnombree.Size = new System.Drawing.Size(126, 20);
            this.txtnombree.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(255, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 12);
            this.label9.TabIndex = 22;
            this.label9.Text = "precio unit";
            // 
            // txtpreciou
            // 
            this.txtpreciou.Location = new System.Drawing.Point(321, 270);
            this.txtpreciou.Name = "txtpreciou";
            this.txtpreciou.Size = new System.Drawing.Size(64, 20);
            this.txtpreciou.TabIndex = 23;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(433, 270);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(60, 20);
            this.txtcantidad.TabIndex = 24;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcantidad_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 273);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "Cant";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "Importe";
            // 
            // txtimporte
            // 
            this.txtimporte.Enabled = false;
            this.txtimporte.Location = new System.Drawing.Point(562, 270);
            this.txtimporte.Name = "txtimporte";
            this.txtimporte.Size = new System.Drawing.Size(66, 20);
            this.txtimporte.TabIndex = 26;
            // 
            // gpboxtipo
            // 
            this.gpboxtipo.Controls.Add(this.rdbtncontado);
            this.gpboxtipo.Controls.Add(this.rdbtncreito);
            this.gpboxtipo.Location = new System.Drawing.Point(451, 12);
            this.gpboxtipo.Name = "gpboxtipo";
            this.gpboxtipo.Size = new System.Drawing.Size(105, 62);
            this.gpboxtipo.TabIndex = 28;
            this.gpboxtipo.TabStop = false;
            this.gpboxtipo.Text = "Tipo";
            // 
            // dgvventa
            // 
            this.dgvventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.cantidad,
            this.preciounitario,
            this.total});
            this.dgvventa.Location = new System.Drawing.Point(12, 322);
            this.dgvventa.Name = "dgvventa";
            this.dgvventa.Size = new System.Drawing.Size(694, 181);
            this.dgvventa.TabIndex = 29;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 250;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // preciounitario
            // 
            this.preciounitario.HeaderText = "Precio Unitario";
            this.preciounitario.Name = "preciounitario";
            this.preciounitario.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // btnsuma
            // 
            this.btnsuma.Enabled = false;
            this.btnsuma.Location = new System.Drawing.Point(771, 322);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(41, 23);
            this.btnsuma.TabIndex = 30;
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            // 
            // btnresta
            // 
            this.btnresta.Enabled = false;
            this.btnresta.Location = new System.Drawing.Point(771, 351);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(41, 23);
            this.btnresta.TabIndex = 31;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(719, 533);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(93, 23);
            this.guardar.TabIndex = 32;
            this.guardar.Text = "Grabar/guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // btntotalizar
            // 
            this.btntotalizar.Enabled = false;
            this.btntotalizar.Location = new System.Drawing.Point(771, 438);
            this.btntotalizar.Name = "btntotalizar";
            this.btntotalizar.Size = new System.Drawing.Size(68, 23);
            this.btntotalizar.TabIndex = 33;
            this.btntotalizar.Text = "Totalizar";
            this.btntotalizar.UseVisualStyleBackColor = true;
            // 
            // btndeshacer
            // 
            this.btndeshacer.Location = new System.Drawing.Point(830, 533);
            this.btndeshacer.Name = "btndeshacer";
            this.btndeshacer.Size = new System.Drawing.Size(69, 23);
            this.btndeshacer.TabIndex = 34;
            this.btndeshacer.Text = "Deshacer";
            this.btndeshacer.UseVisualStyleBackColor = true;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(932, 533);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(41, 23);
            this.btncerrar.TabIndex = 35;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(932, 408);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(67, 20);
            this.txttotal.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(889, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 12);
            this.label12.TabIndex = 36;
            this.label12.Text = "Total $";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(932, 435);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(67, 20);
            this.textBox12.TabIndex = 39;
            // 
            // txtpagoca
            // 
            this.txtpagoca.AutoSize = true;
            this.txtpagoca.Location = new System.Drawing.Point(870, 438);
            this.txtpagoca.Name = "txtpagoca";
            this.txtpagoca.Size = new System.Drawing.Size(56, 12);
            this.txtpagoca.TabIndex = 38;
            this.txtpagoca.Text = "Pago can$";
            // 
            // txtcambio
            // 
            this.txtcambio.Enabled = false;
            this.txtcambio.Location = new System.Drawing.Point(932, 463);
            this.txtcambio.Name = "txtcambio";
            this.txtcambio.Size = new System.Drawing.Size(67, 20);
            this.txtcambio.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(889, 468);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 12);
            this.label14.TabIndex = 40;
            this.label14.Text = "Cambio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(594, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 12);
            this.label7.TabIndex = 42;
            this.label7.Text = "Fecha";
            // 
            // cbox2
            // 
            this.cbox2.FormattingEnabled = true;
            this.cbox2.Location = new System.Drawing.Point(257, 237);
            this.cbox2.Name = "cbox2";
            this.cbox2.Size = new System.Drawing.Size(153, 20);
            this.cbox2.TabIndex = 43;
            // 
            // gpboxinfo
            // 
            this.gpboxinfo.Controls.Add(this.lbllupa);
            this.gpboxinfo.Controls.Add(this.txtcliente);
            this.gpboxinfo.Controls.Add(this.label1);
            this.gpboxinfo.Controls.Add(this.label2);
            this.gpboxinfo.Controls.Add(this.label3);
            this.gpboxinfo.Controls.Add(this.txtnombre);
            this.gpboxinfo.Controls.Add(this.txtlocalidad);
            this.gpboxinfo.Controls.Add(this.txttelefono);
            this.gpboxinfo.Controls.Add(this.label4);
            this.gpboxinfo.Controls.Add(this.cbxcliente);
            this.gpboxinfo.Location = new System.Drawing.Point(12, 12);
            this.gpboxinfo.Name = "gpboxinfo";
            this.gpboxinfo.Size = new System.Drawing.Size(373, 175);
            this.gpboxinfo.TabIndex = 44;
            this.gpboxinfo.TabStop = false;
            this.gpboxinfo.Visible = false;
            // 
            // lbllupa
            // 
            this.lbllupa.Image = ((System.Drawing.Image)(resources.GetObject("lbllupa.Image")));
            this.lbllupa.Location = new System.Drawing.Point(149, 15);
            this.lbllupa.Name = "lbllupa";
            this.lbllupa.Size = new System.Drawing.Size(40, 27);
            this.lbllupa.TabIndex = 40;
            this.lbllupa.UseVisualStyleBackColor = true;
            this.lbllupa.Click += new System.EventHandler(this.Lbllupa_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(186, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 29);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 606);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpboxinfo);
            this.Controls.Add(this.cbox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcambio);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.txtpagoca);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btndeshacer);
            this.Controls.Add(this.btntotalizar);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.dgvventa);
            this.Controls.Add(this.gpboxtipo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtimporte);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtpreciou);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtnombree);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpfecha);
            this.Controls.Add(this.txtfolio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmventa";
            this.Text = "frmreporte";
            this.Load += new System.EventHandler(this.Frmventa_Load);
            this.gpboxtipo.ResumeLayout(false);
            this.gpboxtipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvventa)).EndInit();
            this.gpboxinfo.ResumeLayout(false);
            this.gpboxinfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtlocalidad;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfolio;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.RadioButton rdbtncontado;
        private System.Windows.Forms.RadioButton rdbtncreito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.ComboBox cbxcliente;
        private System.Windows.Forms.TextBox txtnombree;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpreciou;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtimporte;
        private System.Windows.Forms.GroupBox gpboxtipo;
        private System.Windows.Forms.DataGridView dgvventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciounitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button btntotalizar;
        private System.Windows.Forms.Button btndeshacer;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label txtpagoca;
        private System.Windows.Forms.TextBox txtcambio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbox2;
        private System.Windows.Forms.GroupBox gpboxinfo;
        private System.Windows.Forms.Button lbllupa;
        private System.Windows.Forms.Button button1;
    }
}