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
    public partial class frmproveedores1 : Form
    {
        clases.Conexion objconexion;
        SqlConnection Conexion;
        int estatus;
        int existe = 0;
        public frmproveedores1()
        {
            InitializeComponent();
        }
        private void habilitar()
        {
            txtclave.Enabled = true;
            txtdomicilio.Enabled = true;
            txtlocalidad.Enabled = true;
            txtnombre.Enabled = true;
            txtemail.Enabled = true;
            btncerrar.Enabled = true;
            btngrabar.Enabled = true;
            btneliminar.Enabled = true;
            txttwiter.Enabled = true;
        }
        private void limpiar()
        {
            btngrabar.Enabled = false;
            btneliminar.Enabled = false;
            txtemail.Enabled = false;
            txtemail.Clear();
            txttelefono.Enabled = false;
            txttelefono.Clear();
            txtlocalidad.Enabled = false;
            txtlocalidad.Clear();
            txtdomicilio.Enabled = false;
            txtdomicilio.Clear();
            txtnombre.Enabled = false;
            txtnombre.Clear();
            txttwiter.Enabled = false;
            txttwiter.Clear();
            txtclave.Enabled = true;
            txtclave.Clear();
            txtclave.Focus();
        }
        private void maximo()
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT max(pr_clave)+1 as ultimo from proveedores";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtclave.Text = leer["ultimo"].ToString();
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
                    string query = "select * from proveedores where pr_clave=@pr_clave";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    //inicializo cualquier parametrodefinido anteriormente
                    comando.Parameters.Clear();

                    comando.Parameters.AddWithValue("@pr_clave", int.Parse(txtclave.Text));
                    comando.Parameters.AddWithValue("@pr_nombre", this.txtnombre.Text);
                    comando.Parameters.AddWithValue("@pr_domicilio", this.txtdomicilio.Text);
                    comando.Parameters.AddWithValue("@pr_localidad", this.txtlocalidad.Text);
                    comando.Parameters.AddWithValue("@pr_telefono", this.txttelefono.Text);
                    comando.Parameters.AddWithValue("@pr_email", this.txtemail.Text);
                    comando.Parameters.AddWithValue("@pr_twiter", this.txttwiter.Text);

                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        //inicializo la variable 1 para que el programa sepa que existe
                        existe = 1;
                        txtnombre.Enabled = true;
                        txtdomicilio.Enabled = true;
                        txtemail.Enabled = true;
                        txtlocalidad.Enabled = true;
                        txttelefono.Enabled = true;
                        txtnombre.Focus();
                        txtclave.Enabled = false;
                        btngrabar.Enabled = true;
                        btneliminar.Enabled = true;
                        txttwiter.Enabled = true;


                        //igualo los campos o columnas al txtnombre
                        txtclave.Text = leer["pr_clave"].ToString();
                        txtnombre.Text = leer["pr_nombre"].ToString();
                        txtdomicilio.Text = leer["pr_domicilio"].ToString();
                        txtlocalidad.Text = leer["pr_localidad"].ToString();
                        txttelefono.Text = leer["pr_telefono"].ToString();
                        txtemail.Text = leer["pr_email"].ToString();
                        txttwiter.Text = leer["pr_twiter"].ToString();


                        estatus = int.Parse(leer["pr_estatus"].ToString());
                        if (estatus == 0)
                        {
                            MessageBox.Show("Grupo dado de baja", "ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtnombre.Enabled = false;
                            txtdomicilio.Enabled = false;
                            txtemail.Enabled = false;
                            txtlocalidad.Enabled = false;
                            txttelefono.Enabled = false;
                            txtclave.Enabled = false;
                            btngrabar.Enabled = false;
                            btneliminar.Enabled = false;
                            txttwiter.Enabled = false;
                            limpiar();
                        }
                    }
                    else
                    {
                        //si lavariable existe vale 0 y se usara insert
                        existe = 0;
                        if (MessageBox.Show("proveedor no registrado.¿desea agregar un nuevo grupo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            txtnombre.Focus();
                            habilitar();
                        }
                    }
                }
        }

        private void Btngrabar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new clases.Conexion();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "INSERT INTO proveedores values(@pr_clave,@pr_nombre,@pr_domicilio,@pr_localidad,@pr_telefono,@pr_email,@pr_twiter,1)";  //este es para insetar,                                                                                                            //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", int.Parse(txtclave.Text)); //es para ya modificar 
                comando.Parameters.AddWithValue("@pr_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@pr_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@pr_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@pr_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@pr_email", txtemail.Text);
                comando.Parameters.AddWithValue("@pr_Twiter", txttwiter.Text);


                comando.ExecuteNonQuery();//es para verificar los editados
                MessageBox.Show("proveedor guardado con exito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string query = "update proveedores set pr_nombre=@pr_nombre,pr_domicilio=@pr_domicilio,pr_localidad=@pr_localidad,pr_telefono=@pr_telefono,pr_email=@pr_email,pr_twiter=@pr_twiter where pr_clave=@pr_clave";                                          //asigno a comando el sqlcommand
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@pr_clave", int.Parse(txtclave.Text));
                comando.Parameters.AddWithValue("@pr_nombre", txtnombre.Text);
                comando.Parameters.AddWithValue("@pr_domicilio", txtdomicilio.Text);
                comando.Parameters.AddWithValue("@pr_localidad", txtlocalidad.Text);
                comando.Parameters.AddWithValue("@pr_telefono", txttelefono.Text);
                comando.Parameters.AddWithValue("@pr_email", txtemail.Text);
                comando.Parameters.AddWithValue("@pr_Twiter", txttwiter.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("proveedor modificado con exito", "modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //dejar el forms como el inicio
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
            string query = "update proveedores set pr_estatus=0 where pr_clave=@pr_clave";
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@pr_clave", txtclave.Text);
            if (MessageBox.Show("proveedor se dara de baja,esta seguro?", "eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("proveedor eliminado", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                maximo();
            }

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
                if (string.IsNullOrEmpty(txtnombre.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtnombre.Clear();
                    txtnombre.Focus();
                }
                else
                {
                    txtdomicilio.Enabled = true;
                    txtdomicilio.Focus();
                }
            }
        }

        private void Txtdomicilio_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                if (string.IsNullOrEmpty(txtdomicilio.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdomicilio.Clear();
                    txtdomicilio.Focus();
                }
                else
                {
                    txtlocalidad.Enabled = true;
                    txtlocalidad.Focus();
                }
            }
               
        }

        private void Txtlocalidad_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                if (string.IsNullOrEmpty(txtlocalidad.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtlocalidad.Clear();
                    txtlocalidad.Focus();
                }
                else
                {
                    txttelefono.Enabled = true;
                    txttelefono.Focus();
                }

               
            }
        }

        private void Txttelefono_KeyDown(object sender, KeyEventArgs e)
        {
            //if (char.IsSeparator(e.KeyCode))
            //{
            //    e.Handled = true;
            //}

            if (e.KeyValue == 13)
            {
                txtemail.Enabled = true;
                txtemail.Focus();
            }
        }

        private void Txtnombre_KeyUp(object sender, KeyEventArgs e)
        {
           

            if (e.KeyCode == Keys.Escape)
            {
                limpiar();
                maximo();
            }
        }

        private void Cboxlupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtclave.Text = this.cboxlupa.SelectedValue.ToString();
                lblbuscar.Visible = false;
                cboxlupa.Visible = false;
                txtclave.Enabled = true;
            }
        }

        private void Lupa_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            cboxlupa.Visible = true;
            llenarcbox();
        }

        private void Frmproveedores1_Load(object sender, EventArgs e)
        {
            limpiar();
            maximo();
            
        }

        private void Cboxlupa_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void llenarcbox()
        {
            DataTable dt = new DataTable();
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT * from proveedores where pr_estatus=1 order by pr_nombre";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            this.cboxlupa.DataSource = dt;
            this.cboxlupa.ValueMember = "pr_clave";
            this.cboxlupa.DisplayMember = "pr_nombre";
            Conexion.Close();
        }

        private void Txttwiter_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Txtemail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txttwiter.Enabled = true;
                txttwiter.Focus();
            }
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    