namespace Pventas.formas
{
    partial class Frmaccesoo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmaccesoo));
            this.btnclose = new System.Windows.Forms.Button();
            this.btnacep = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(540, 360);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(70, 38);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Cerrar";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // btnacep
            // 
            this.btnacep.Enabled = false;
            this.btnacep.Location = new System.Drawing.Point(341, 332);
            this.btnacep.Name = "btnacep";
            this.btnacep.Size = new System.Drawing.Size(75, 23);
            this.btnacep.TabIndex = 11;
            this.btnacep.Text = "Aceptar";
            this.btnacep.UseVisualStyleBackColor = true;
            this.btnacep.Click += new System.EventHandler(this.Btnacep_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(206, 263);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(100, 20);
            this.txtpass.TabIndex = 10;
            this.txtpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpass_KeyPress);
            this.txtpass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txtpass_KeyUp);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(231, 235);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 9;
            this.password.Text = "Password";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(206, 194);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(100, 20);
            this.txtuser.TabIndex = 8;
            this.txtuser.TextChanged += new System.EventHandler(this.Txtuser_TextChanged);
            this.txtuser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtuser_KeyPress);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(228, 169);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(43, 13);
            this.usuario.TabIndex = 7;
            this.usuario.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Frmaccesoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnacep);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.usuario);
            this.Name = "Frmaccesoo";
            this.Text = "Frmaccesoo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnacep;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label usuario;
    }
}