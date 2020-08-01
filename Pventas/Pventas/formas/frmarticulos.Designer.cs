namespace Pventas.formas
{
    partial class frmarticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmarticulos));
            this.Codigo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Grupo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtexistencia = new System.Windows.Forms.TextBox();
            this.txtpreciov = new System.Windows.Forms.TextBox();
            this.txtpreciocosto = new System.Windows.Forms.TextBox();
            this.lbllupa = new System.Windows.Forms.Button();
            this.cbxarticulo = new System.Windows.Forms.ComboBox();
            this.lblbuscar = new System.Windows.Forms.Label();
            this.btncerrar = new System.Windows.Forms.Button();
            this.btndeshacer = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.cboxgrupo1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(72, 66);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(40, 13);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripcion";
            // 
            // Grupo
            // 
            this.Grupo.AutoSize = true;
            this.Grupo.Location = new System.Drawing.Point(72, 140);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(36, 13);
            this.Grupo.TabIndex = 2;
            this.Grupo.Text = "Grupo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Existencia";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(125, 63);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(81, 20);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtcodigo_KeyDown);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtcodigo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio venta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio costo";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescripcion.Location = new System.Drawing.Point(125, 102);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(123, 20);
            this.txtdescripcion.TabIndex = 7;
            this.txtdescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtdescripcion_KeyDown);
            this.txtdescripcion.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtdescripcion_KeyUp);
            // 
            // txtexistencia
            // 
            this.txtexistencia.Location = new System.Drawing.Point(125, 279);
            this.txtexistencia.Name = "txtexistencia";
            this.txtexistencia.Size = new System.Drawing.Size(81, 20);
            this.txtexistencia.TabIndex = 9;
            this.txtexistencia.TextChanged += new System.EventHandler(this.Txtexistencia_TextChanged);
            // 
            // txtpreciov
            // 
            this.txtpreciov.Location = new System.Drawing.Point(125, 186);
            this.txtpreciov.Name = "txtpreciov";
            this.txtpreciov.Size = new System.Drawing.Size(81, 20);
            this.txtpreciov.TabIndex = 10;
            this.txtpreciov.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtpreciov_KeyDown);
            // 
            // txtpreciocosto
            // 
            this.txtpreciocosto.Location = new System.Drawing.Point(125, 227);
            this.txtpreciocosto.Name = "txtpreciocosto";
            this.txtpreciocosto.Size = new System.Drawing.Size(81, 20);
            this.txtpreciocosto.TabIndex = 11;
            this.txtpreciocosto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txtpreciocosto_KeyDown);
            // 
            // lbllupa
            // 
            this.lbllupa.Image = ((System.Drawing.Image)(resources.GetObject("lbllupa.Image")));
            this.lbllupa.Location = new System.Drawing.Point(393, 55);
            this.lbllupa.Name = "lbllupa";
            this.lbllupa.Size = new System.Drawing.Size(40, 27);
            this.lbllupa.TabIndex = 42;
            this.lbllupa.UseVisualStyleBackColor = true;
            this.lbllupa.Click += new System.EventHandler(this.Lbllupa_Click);
            // 
            // cbxarticulo
            // 
            this.cbxarticulo.FormattingEnabled = true;
            this.cbxarticulo.Location = new System.Drawing.Point(451, 62);
            this.cbxarticulo.Name = "cbxarticulo";
            this.cbxarticulo.Size = new System.Drawing.Size(153, 21);
            this.cbxarticulo.TabIndex = 41;
            this.cbxarticulo.Visible = false;
            this.cbxarticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cbxarticulo_KeyPress);
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Location = new System.Drawing.Point(467, 37);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(47, 13);
            this.lblbuscar.TabIndex = 43;
            this.lblbuscar.Text = "Articulos";
            this.lblbuscar.Visible = false;
            // 
            // btncerrar
            // 
            this.btncerrar.Location = new System.Drawing.Point(447, 397);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(41, 23);
            this.btncerrar.TabIndex = 46;
            this.btncerrar.Text = "Cerrar";
            this.btncerrar.UseVisualStyleBackColor = true;
            this.btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // btndeshacer
            // 
            this.btndeshacer.Location = new System.Drawing.Point(345, 397);
            this.btndeshacer.Name = "btndeshacer";
            this.btndeshacer.Size = new System.Drawing.Size(69, 23);
            this.btndeshacer.TabIndex = 45;
            this.btndeshacer.Text = "Deshacer";
            this.btndeshacer.UseVisualStyleBackColor = true;
            this.btndeshacer.Click += new System.EventHandler(this.Btndeshacer_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(234, 397);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(93, 23);
            this.guardar.TabIndex = 44;
            this.guardar.Text = "Grabar/guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // cboxgrupo1
            // 
            this.cboxgrupo1.FormattingEnabled = true;
            this.cboxgrupo1.Location = new System.Drawing.Point(125, 137);
            this.cboxgrupo1.Name = "cboxgrupo1";
            this.cboxgrupo1.Size = new System.Drawing.Size(102, 21);
            this.cboxgrupo1.TabIndex = 47;
            this.cboxgrupo1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxgrupo1_KeyPress);
            // 
            // frmarticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboxgrupo1);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.btndeshacer);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.lblbuscar);
            this.Controls.Add(this.lbllupa);
            this.Controls.Add(this.cbxarticulo);
            this.Controls.Add(this.txtpreciocosto);
            this.Controls.Add(this.txtpreciov);
            this.Controls.Add(this.txtexistencia);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Codigo);
            this.Name = "frmarticulos";
            this.Text = "frmarticulos";
            this.Load += new System.EventHandler(this.Frmarticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Grupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.TextBox txtexistencia;
        private System.Windows.Forms.TextBox txtpreciov;
        private System.Windows.Forms.TextBox txtpreciocosto;
        private System.Windows.Forms.Button lbllupa;
        private System.Windows.Forms.ComboBox cbxarticulo;
        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.Button btncerrar;
        private System.Windows.Forms.Button btndeshacer;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.ComboBox cboxgrupo1;
    }
}