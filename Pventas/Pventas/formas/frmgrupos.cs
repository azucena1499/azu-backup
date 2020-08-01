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
    public partial class frmgrupos : Form
    {
        clases.Conexion objconexion;
        SqlConnection Conexion;
        int estatus;
        int existe = 0;
        public frmgrupos()
        {
            InitializeComponent();
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtclave.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //no fue nulo

                    objconexion = new clases.Conexion();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from grupos where gr_clave=@gr_clave";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    //inicializo cualquier parametrodefinido anteriormente
                    comando.Parameters.Clear();
                    //cualquier variable,pero se recomienda usar el mismo nombre del campo
                    comando.Parameters.AddWithValue("@gr_clave", this.txtclave.Text); 
                        //asigno a leer el sqldatareader para leer el registro.
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtnombre.Enabled = true;
                        txtnombre.Focus();
                        txtclave.Enabled = false;
                        btnguardar.Enabled = true;
                        btneliminar.Enabled = true;
                        cbox.Enabled = true;
                        //igualo los campos o columnas al txtnombre
                        txtnombre.Text = leer["gr_nombre"].ToString();
                        estatus = int.Parse(leer["gr_estatus"].ToString());
                        if (estatus == 1)
                        {
                            cbox.SelectedIndex = estatus - 1;
                        }
                        else
                        {
                            cbox.SelectedIndex = estatus + 1;
                        }
                        if (estatus == 0)
                        {
                            MessageBox.Show("Grupo dado de baja", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btneliminar.Enabled = false;
                            btnguardar.Enabled = false;
                            cbox.Enabled = false;
                        }
                    }
                    else
                    {
                        //si lavariable existe vale 0 y se usara insert
                        existe = 0;
                        if (MessageBox.Show("grupo no registrado.¿desea agregar un nuevo grupo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            txtnombre.Enabled = true;
                            cbox.Enabled = false;
                            btnguardar.Enabled = true;
                            txtnombre.Focus();
                            txtclave.Enabled = true;


                        }

                    }

                }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            cboxgrupos.Visible = true;
            llearcbox();
        }

        private void Frmgrupos_Load(object sender, EventArgs e)
        {
            //llenar el cbox de situacion
            cbox.Items.Add("activo");
            cbox.Items.Add("bajo");
            maximo();

        


        }

        private void Txtclave_TextChanged(object sender, EventArgs e)
        {


        }

        private void Txtmayuscula_TextChanged(object sender, EventArgs e)
        {
            txtnombre.CharacterCasing = CharacterCasing.Upper;
        }

        private void Frmgrupos_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = false;
            cboxgrupos.Visible = false;
            //llamo al procedimiento para llenar..tambien puede ir en el evento load
            llearcbox();
            txtclave.Focus();
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btnguardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new clases.Conexion();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                //string query = "select * from grupos where gr_clave=@gr_clave";
                string query = "INSERT INTO grupos values(@gr_clave,@gr_nombre,1)";  //este es para insetar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_loginue pueda ser
                //cualquier variable,pero se recomienda usar el mismo nombre del campo
                comando.Parameters.AddWithValue("@gr_clave", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("gr_nombre", txtnombre.Text);
                // comando.Parameters.AddWithValue("@gr_estatus", cbox.SelectedIndex);
                comando.ExecuteNonQuery();//es para verificar os editados
                MessageBox.Show("grupo guardado con exito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                btnguardar.Enabled = false;
                cbox.ResetText();
                txtnombre.Clear();
                cbox.Text = "";
                txtclave.Enabled = true;
                txtclave.Clear();
                txtclave.Focus();
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
                string query = "update grupos set gr_nombre=@gr_nombre,where gr_clave=@gr_clave";  //este es para modificar,se hace la conexion el campo y esl paramet                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                //tranfiero el valor de txtpassword al parametrous_loginue pueda ser
                //cualquier variable,pero se recomienda usar el mismo nombre del campo
                comando.Parameters.AddWithValue("@gr_clave", int.Parse(txtclave.Text)); //este es para ya modificar 
                comando.Parameters.AddWithValue("@gr_nombre", txtnombre.Text);
                //comando.Parameters.AddWithValue("@gr_estatus", cbox.SelectedIndex);
                comando.ExecuteNonQuery();
                MessageBox.Show("grupo modificado con exito", "modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
                btnguardar.Enabled = false;
                cbox.ResetText();
                txtnombre.Clear();
                // cbox.Text = "";
                txtclave.Enabled = true;
                txtclave.Clear();
                txtclave.Focus();
                maximo();
            }

        }

        private void Btneliminar_Click(object sender, EventArgs e)
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            //se abre el contenido
            Conexion.Open();
            string query = "update grupos set gr_estatus=0 where gr_clave=@gr_clave";
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@gr_clave", txtclave.Text);
            if (MessageBox.Show("el grupo se dara de baja,esta seguro?", "eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("grupo eliminado", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnguardar.Enabled = false;
            btneliminar.Enabled = false;
            cbox.ResetText();
            txtnombre.Enabled = false;
            txtnombre.Clear();
            cbox.Enabled = false;
            // cbox.Text = "";
            txtclave.Enabled = true;
            txtclave.Clear();
            txtclave.Focus();
            maximo();
        }
        private void llearcbox()
        {
            //defino el data table
            DataTable dt = new DataTable();
            //establezco conex
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            //abro conexion
            Conexion.Open();
            //establezco mi query
            string query = "select * from grupos where gr_estatus=1 order by gr_nombre";
            //defino comando
            SqlCommand comando = new SqlCommand(query, Conexion);
            //defino mi adapter
            SqlDataAdapter da = new SqlDataAdapter(comando);
            //lleno el datatable
            da.Fill(dt);
            //establece como fuente de datos del cbox el data table
            this.cboxgrupos.DataSource = dt;
            //defino los campos de la tabla
            this.cboxgrupos.ValueMember = "gr_clave";
            this.cboxgrupos.DisplayMember = "gr_nombre";
            //cierro conexion
            Conexion.Close();

        }

        private void Cboxgrupos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtclave.Text = this.cboxgrupos.SelectedValue.ToString();
                this.txtnombre.Text = this.cboxgrupos.SelectedText.ToString();
                //valido
                lblbuscar.Visible = false;
                cboxgrupos.Visible = false;
                txtclave.Enabled = false;
                txtnombre.Enabled = true;
                txtnombre.Focus();
                btnguardar.Enabled = true;
                btneliminar.Enabled = true;
                existe = 1;


            }
        }
        private void maximo()
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT max(gr_clave)+1 as ultimo from grupos";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtclave.Text = leer["ultimo"].ToString();
        }

        private void Txtclave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtnombre.Enabled = true;
                txtnombre.Focus();
            }
        }

        private void Txtnombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
               cbox.Enabled = true;
                cbox.Focus();
            }
        }

        private void Txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                txtclave.Enabled = true;
                txtclave.Clear();
                txtclave.Focus();
                txtnombre.Enabled = false;
                txtnombre.Clear();
                cbox.Enabled = false;
                cbox.ResetText();
                maximo();
            }
        }
    }
}
