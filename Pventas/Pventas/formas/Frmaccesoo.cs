using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pventas.formas
{
    public partial class Frmaccesoo : Form
    {
        int intento = 0;//aqui se definen las variables publicas,pueden ser utilizadas en todo el formulario
        public Frmaccesoo()
        {
            InitializeComponent();
        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)// fue un enter,13 codigo ascii 
            {

                if (txtuser.Text.Trim() == "maria" || txtuser.Text.Trim() == "juan") //el trim quita los espacios de izquierda o derech de texbox
                {
                    pictureBox1.Image = Image.FromFile(@"\fotos\" + txtuser.Text + ".png");


                    txtpass.Enabled = true;
                    txtpass.Focus();
                }
                else
                {
                    MessageBox.Show("error", "xD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox1.Image = Image.FromFile(@"\fotos\" + "x.png");
                    txtuser.Clear();
                    txtuser.Focus();
                }
            }
        }

        private void Txtpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtpass.Text.Trim() == "123")
                {
                    btnacep.Enabled = true;

                }
                else
                {

                    if (intento <= 2)
                    {
                        MessageBox.Show("error verificar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpass.Clear();
                        txtpass.Focus();
                        intento++;

                    }
                    else
                    {
                        MessageBox.Show("oportunidades agotadas", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();//el sistema se cierra
                    }
                }
            }
        }

        private void Txtpass_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                txtpass.Clear();
                txtpass.Enabled = false;
                btnacep.Enabled = true;
                txtpass.Clear();
                txtpass.Focus();
            }
        }

        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btnacep_Click(object sender, EventArgs e)
        {
            Frmmenu menu = new Frmmenu();
            this.Hide();
            menu.Show();
        }
    }
}
