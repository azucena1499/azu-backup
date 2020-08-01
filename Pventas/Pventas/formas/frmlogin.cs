using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//poner siempre que vaya a hacer conexion a sql
using System.Data.SqlClient;

namespace Pventas.formas
{
    public partial class frmlogin : Form
    {
        //definimos conexion
        //esto es fijo para todos los los forms
        clases.Conexion objconexion;
        SqlConnection Conexion;
        string pass;
        string nivel;
        int intento = 0;//aqui se definen las variables


        public frmlogin()
        {
            InitializeComponent();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            //aplicattion.exit se sale de todo
            this.Close();
        }

        private void Txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)

            {

                if (txtusuario.Text.Trim() == "maria" || txtusuario.Text.Trim() == "juan") //el trim quita los espacios de izquierda o derech de texbox
                {
                    pictureBox1.Image = Image.FromFile(@"\fotos\" + txtusuario.Text + ".png");


                    txtpassword.Enabled = true;
                    txtpassword.Focus();
                }
                else
                {
                    MessageBox.Show("error", "xD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox1.Image = Image.FromFile(@"\fotos\" + "x.png");
                    txtusuario.Clear();
                    txtusuario.Focus();
                }
                // aqui puede pnoer codigo de foto

                objconexion = new clases.Conexion();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "select * from usuarios where us_login=@us_login";
                //asugno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_loginue pueda ser
                //cualquier variable,pero se recomienda usar el mismo nombre del campo
                comando.Parameters.AddWithValue("@us_login", txtusuario.Text);
                //asigno a leer el sqldatareader para leer el registro.
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read())
                {
                    pass = leer["us_password"].ToString();
                    nivel = leer["us_nivel"].ToString();
                    if (nivel == "1")
                    txtnivel.Text = "administrador";
                    if (nivel == "2")
                        txtnivel.Text = "operador";
                    if (nivel == "3")
                        txtnivel.Text = "invitado";
                   //tambien se puede hacer con este lblniv.Text="invitado";

                    txtpassword.Enabled = true;
                    txtpassword.Focus();

                }
                else
                {
                    //lo encontro
                    MessageBox.Show("error,usuario no registrado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusuario.Clear();
                    txtusuario.Focus();




                }
            }
        }

        private void Btnaccesar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmmenu x = new Frmmenu();
             x.Show();
           
            
           

        }

        private void Txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
            {
                if (txtpassword.Text.Trim() == pass)
                {
                    btnaccesar.Enabled = true;

                }
                else
                {

                    if (intento <= 2)
                    {
                        MessageBox.Show("error verificar", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtpassword.Clear();
                        txtpassword.Focus();
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

        private void Lblniv_Click(object sender, EventArgs e)
        {

        }

        private void Txtpassword_KeyUp(object sender, KeyEventArgs e)
        {
            //escape en txtpassword0
            if(e.KeyCode==Keys.Escape)
            {
                pictureBox1.Image = Image.FromFile(@"\fotos\X.png");
                txtpassword.Clear();
                lblniv.Visible = false;
                btnaccesar.Enabled = false;
                txtnivel.Visible = false;
                txtusuario.Focus();
                txtusuario.Clear();
                txtnivel.Clear();
                

            }

        }
    }
}
   