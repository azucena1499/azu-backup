namespace Pventas.formas
{
    partial class frmlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.label1 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnaccesar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnivel = new System.Windows.Forms.TextBox();
            this.lblnivel = new System.Windows.Forms.Label();
            this.lblniv = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(253, 46);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(100, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtusuario_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // txtpassword
            // 
            this.txtpassword.Enabled = false;
            this.txtpassword.Location = new System.Drawing.Point(253, 122);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpassword_KeyPress);
            this.txtpassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtpassword_KeyUp);
            // 
            // btnaccesar
            // 
            this.btnaccesar.Enabled = false;
            this.btnaccesar.Location = new System.Drawing.Point(411, 269);
            this.btnaccesar.Name = "btnaccesar";
            this.btnaccesar.Size = new System.Drawing.Size(75, 23);
            this.btnaccesar.TabIndex = 4;
            this.btnaccesar.Text = "aceptar";
            this.btnaccesar.UseVisualStyleBackColor = true;
            this.btnaccesar.Click += new System.EventHandler(this.Btnaccesar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(525, 269);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtnivel
            // 
            this.txtnivel.Enabled = false;
            this.txtnivel.Location = new System.Drawing.Point(423, 75);
            this.txtnivel.Name = "txtnivel";
            this.txtnivel.Size = new System.Drawing.Size(100, 20);
            this.txtnivel.TabIndex = 8;
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Location = new System.Drawing.Point(457, 59);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(29, 13);
            this.lblnivel.TabIndex = 9;
            this.lblnivel.Text = "nivel";
            // 
            // lblniv
            // 
            this.lblniv.AutoSize = true;
            this.lblniv.Location = new System.Drawing.Point(84, 144);
            this.lblniv.Name = "lblniv";
            this.lblniv.Size = new System.Drawing.Size(29, 13);
            this.lblniv.TabIndex = 10;
            this.lblniv.Text = "nivel";
            this.lblniv.Click += new System.EventHandler(this.Lblniv_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 321);
            this.Controls.Add(this.lblniv);
            this.Controls.Add(this.lblnivel);
            this.Controls.Add(this.txtnivel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnaccesar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmlogin";
            this.Text = "acceso al sistema";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnaccesar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnivel;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.Label lblniv;
    }
}