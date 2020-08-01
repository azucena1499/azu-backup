using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Pventas.formas
{
    public partial class frmclientes : Form
    {
        clases.Conexion objconexion;
        SqlConnection Conexion;
        int estatus;
        int existe = 0;
        public frmclientes()
        {
            InitializeComponent();
        }

        private void Frmclientes_Load(object sender, EventArgs e)
        {
            //llenar el cbox de situacion
            cboxclientee.Text = "seleccione";
            cboxclientee.Items.Add("mayoreo");
            cboxclientee.Items.Add("menudeo");
            maximo(); 
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtclave.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtclave.Enabled = true;
                    txtclave.Clear();
                    txtclave.Focus();
                }
                else
                {
                    //no fue nulo

                    objconexion = new clases.Conexion();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from clientes where cl_clave=@cl_clave";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    //inicializo cualquier parametrodefinido anteriormente
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@cl_clave", int.Parse(txtclave.Text));
                    comando.Parameters.AddWithValue("@cl_nombre", this.txtnombre.Text);
                    comando.Parameters.AddWithValue("@cl_domicilio", this.txtdomicilio.Text);
                    comando.Parameters.AddWithValue("@cl_localidad", this.txtlocalidad.Text);
                    comando.Parameters.AddWithValue("@cl_telefono", this.txtteleono.Text);
                    comando.Parameters.AddWithValue("@cl_email", this.txtemail.Text);

                    comando.Parameters.AddWithValue("@cl_estatus", this.cboxclientee.SelectedIndex);


                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtnombre.Enabled = true;
                        txtdomicilio.Enabled = true;
                        txtemail.Enabled = true;
                        txtlocalidad.Enabled = true;
                        txtteleono.Enabled = true;
                        txtnombre.Focus();
                        txtclave.Enabled = false;
                        btngrabar.Enabled = true;
                        btneliminar.Enabled = true;
                        cboxclientee.Enabled = true;

                        //igualo los campos o columnas al txtnombre
                        txtnombre.Text = leer["cl_nombre"].ToString();
                        estatus = int.Parse(leer["cl_estatus"].ToString());
                        txtdomicilio.Text = leer["cl_domicilio"].ToString();
                        txtlocalidad.Text = leer["cl_tipo"].ToString();
                        txtemail.Text = leer["cl_email"].ToString();
                        txtclave.Text = leer["cl_clave"].ToString();
                        txtteleono.Text = leer["cl_telefono"].ToString();
                        txtlocalidad.Text = leer["cl_localidad"].ToString();

                        if (estatus == 1)
                        {
                            cboxclientee.SelectedIndex = estatus - 1;
                        }
                        else
                        {
                            cboxclientee.SelectedIndex = estatus + 1;
                        }
                        if (estatus == 0)
                        {
                            MessageBox.Show("Grupo dado de baja", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btneliminar.Enabled = false;
                            btngrabar.Enabled = false;
                            cboxclientee.Enabled = false;
                            txtnombre.Enabled = true;
                            txtdomicilio.Enabled = false;
                            txtemail.Enabled = false;
                            txtlocalidad.Enabled = false;
                            limpiar();



                        }
                    }
                    else
                    {
                        //si lavariable existe vale 0 y se usara insert
                        existe = 0;
                        if (MessageBox.Show("grupo no registrado.¿desea agregar un nuevo grupo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            //poner un habilitar aqui
                            txtnombre.Enabled = true;
                            txtnombre.Focus();
                        }
                    }
                }
        }

        private void Txtnombre_TextChanged(object sender, EventArgs e)
        {
            txtnombre.CharacterCasing = CharacterCasing.Upper;
        }
        private void limpiar()
        {
            btngrabar.Enabled = false;
            btneliminar.Enabled = false;
            cboxclientee.Enabled = false;
            cboxclientee.ResetText();
            txtemail.Enabled = false;
            txtemail.Clear();
            txtteleono.Enabled = false;
            txtteleono.Clear();
            txtlocalidad.Enabled = false;
            txtlocalidad.Clear();
            txtdomicilio.Enabled = false;
            txtdomicilio.Clear();
            txtnombre.Enabled = false;
            txtnombre.Clear();
            txtclave.Enabled = true;
            txtclave.Clear();
            txtclave.Focus();
        }
        private void habilitar()
        {
            txtclave.Enabled = true;
            txtdomicilio.Enabled = true;
            txtlocalidad.Enabled= true;
            txtnombre.Enabled = true;
            txtemail.Enabled = true;
            btncerrar.Enabled = true;
            btngrabar.Enabled = true;
            btneliminar.Enabled = true;

        }
        private void Txtdomicilio_TextChanged(object sender, EventArgs e)
        {
            txtnombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void Btngrabar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new clases.Conexion();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                //string query = "select * from grupos where gr_clave=@gr_clave";
                string query = "INSERT INTO clientes values(@cl_clave,@cl_nombre,@cl_domicilio,@cl_localidad,@cl_telefono,@cl_email,@cl_tipo,1)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
               
                comando.Parameters.AddWithValue("@cl_clave", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@cl_nombre", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@cl_domicilio", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@cl_localidad", txtnombre.Text);
                // comando.Parameters.AddWithValue("@cl_estatus", cboxclientee.SelectedIndex);
                comando.Parameters.AddWithValue("@cl_telefono", txtteleono.Text);
                comando.Parameters.AddWithValue("@cl_email", txtemail.Text);
                comando.Parameters.AddWithValue("@cl_tipo", cboxclientee.SelectedIndex);

                comando.ExecuteNonQuery();//es para verificar los editados
                MessageBox.Show("grupo guardado con exito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                limpiar();
                maximo();

            }
            if (existe == 1)
            {
                //fue un 0
                objconexion = new clases.Conexion();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                //string query = "select * from grupos where gr_clave=@gr_clave";
                string query = "update clientes set cl_nombre=@cl_nombre where cl_clave=@cl_clave";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_loginue pueda ser
                //cualquier variable,pero se recomienda usar el mismo nombre del campo
                comando.Parameters.AddWithValue("@cl_clave", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@cl_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@cl_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@cl_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@cl_estatus", cboxclientee.SelectedIndex);
                comando.Parameters.AddWithValue("@cl_telefono", txtteleono.Text);
                comando.Parameters.AddWithValue("@cl_email", txtemail.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("grupo modificado con exito", "modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                limpiar();
                maximo();
               


            }
        }

        private void Txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if  (e.KeyCode == Keys.Escape)
            {
 
                limpiar();
                maximo();
            }
        }
        private void Btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            //se abre el contenido
            Conexion.Open();
            string query = "update clientes set cl_estatus=0 where cl_clave=@cl_clave";
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@cl_clave", txtclave.Text);
            if (MessageBox.Show("el grupo se dara de baja,esta seguro?", "eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("grupo eliminado", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiar();
            maximo();
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            cboxgrupos.Visible = true;
            llenarcbox();
        }
        private void llenarcbox()
        {
            DataTable dt = new DataTable();
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT * from clientes where cl_estatus=1 order by cl_nombre";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            this.cboxgrupos.DataSource = dt;
            this.cboxgrupos.ValueMember = "cl_clave";
            this.cboxgrupos.DisplayMember = "cl_nombre";
            Conexion.Close();
        }

        private void Cboxgrupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtclave.Text = this.cboxgrupos.SelectedValue.ToString();
                lblbuscar.Visible = false;
                cboxgrupos.Visible = false;
                txtclave.Enabled = true;
            }


        }
        private void maximo()
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT max(cl_clave)+1 as ultimo from clientes";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtclave.Text = leer["ultimo"].ToString();
        }

        private void Txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                txtdomicilio.Enabled = true;
                txtdomicilio.Focus();
            }
    
        }
        private void Txtdomicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtlocalidad.Enabled = true;
                txtlocalidad.Focus();
            }
        }


        private void Frmclientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtteleono.Enabled = true;
                txtteleono.Focus();
            }
        }

        private void Txtteleono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtemail.Enabled = true;
                txtemail.Focus();
            }
        }

        private void Txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                cboxclientee.Enabled = true;
                cboxclientee.Focus();
                btngrabar.Enabled = true;
                btneliminar.Enabled = true;
            }
        }

        private void Txtlocalidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtteleono.Enabled = true;
                txtteleono.Focus();
            }
        }
    }
}
