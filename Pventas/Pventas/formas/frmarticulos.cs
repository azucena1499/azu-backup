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
    public partial class frmarticulos : Form
    {
        clases.Conexion objconexion;
        SqlConnection Conexion;
        int existe = 0;
        public frmarticulos()
        {
            InitializeComponent();
        }

        private void Txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtcodigo.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcodigo.Enabled = true;
                    txtcodigo.Clear();
                    txtcodigo.Focus();
                }
                else
                {
                    objconexion = new clases.Conexion();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from articulo where ar_clave=@ar_clave";
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@ar_clave", int.Parse(txtcodigo.Text));

                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        existe = 1;
                        txtcodigo.Enabled = false;

                        txtdescripcion.Text = leer["ar_nombre"].ToString();
                        cboxgrupo1.Text = leer["ar_grupo"].ToString();
                        txtexistencia.Text = leer["ar_existencia"].ToString();
                        txtpreciov.Text = leer["ar_precioventa"].ToString();
                        txtpreciocosto.Text = leer["ar_preciocosto"].ToString();
                    }
                    else
                    {
                        if (MessageBox.Show("articulo no registrado.¿desea agregar un nuevo articulo?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {

                            txtdescripcion.Enabled = true;
                            txtdescripcion.Focus();

                        }
                        else
                        {
                            txtcodigo.Clear();
                            txtcodigo.Focus();

                        }
                    }
                    Conexion.Close();
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (existe == 0)
            {
                objconexion = new clases.Conexion();
                Conexion = new SqlConnection(objconexion.Conn());
                Conexion.Open();
                string query = "INSERT INTO articulo values(@ar_clave,@ar_nombre,@gr_grupo,@ar_precioventa,@ar_preciocosto,@ar_existencia)";  //este es para insetar,                                                                                                            
                SqlCommand comando = new SqlCommand(query, Conexion);
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ar_clave", int.Parse(txtcodigo.Text));
                comando.Parameters.AddWithValue("@ar_nombre", txtdescripcion.Text);
                comando.Parameters.AddWithValue("@ar_grupo", cboxgrupo1.Text); 
                 comando.Parameters.AddWithValue("@ar_precioventa", txtpreciov.Text);
                comando.Parameters.AddWithValue("@ar_preciocosto", txtpreciocosto.Text);
                comando.Parameters.AddWithValue("@ar_existencia", txtexistencia.Text);


                comando.ExecuteNonQuery();//es para verificar los editados
                MessageBox.Show("articulo guardado con exito", "guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();

            }
            if (existe == 1)
            {
                //fue un 0
                objconexion = new clases.Conexion();
                Conexion = new SqlConnection(objconexion.Conn());
                //se abre la conexion
                Conexion.Open();
                string query = "update articulo set ar_nombre=@ar_nombre,ar_grupo=@ar_grupo,ar_precioventa=@ar_precioventa,ar_preciocosto=@ar_preciocosto,ar_existencia=@ar_existencia where ar_clave=@ar_clave";
                SqlCommand comando = new SqlCommand(query, Conexion);
                //inicializo cualquier parametrodefinido anteriormente
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ar_clave", int.Parse(txtcodigo.Text));
                comando.Parameters.AddWithValue("@ar_nombre", txtdescripcion.Text);
                comando.Parameters.AddWithValue("@ar_grupo", cboxgrupo1.Text);
                comando.Parameters.AddWithValue("@ar_precioventa", txtpreciov.Text);
                comando.Parameters.AddWithValue("@ar_preciocosto", txtpreciocosto.Text);
                comando.Parameters.AddWithValue("@ar_existencia", txtexistencia.Text);

                comando.ExecuteNonQuery();
                MessageBox.Show("articulo modificado con exito", "modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            Conexion.Close();
        }

        private void Btndeshacer_Click(object sender, EventArgs e)
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            //se abre el contenido
            Conexion.Open();
            string query = "DELETE from articulo where ar_clave=" + txtcodigo.Text;
            SqlCommand comando = new SqlCommand(query, Conexion);
            comando.Parameters.Clear();
            if (MessageBox.Show("articulo se dara de baja,esta seguro?", "eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop) == DialogResult.Yes)
            {
                comando.ExecuteNonQuery();
                MessageBox.Show("articulo eliminado", "eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
        }

        private void Txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtdescripcion.Enabled = true;
                txtdescripcion.Focus();
            }
        }

        private void Txtdescripcion_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                cboxgrupo1.Enabled = true;
                cboxgrupo1.Focus();
            }
        }

        private void Txtgrupo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtpreciov.Enabled = true;
                txtpreciov.Focus();
            }
        }


        private void Txtpreciov_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 13)
            {
                txtpreciocosto.Enabled = true;
                txtpreciocosto.Focus();
                btncerrar.Enabled = true;
                guardar .Enabled = true;
            }
        }

        private void Cbxarticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtcodigo.Text = this.cbxarticulo.SelectedValue.ToString();
                lblbuscar.Visible = false;
                cbxarticulo.Visible = false;
                cbxarticulo.Enabled = true;
                txtcodigo.Focus();
            }
        }

        private void Lbllupa_Click(object sender, EventArgs e)
        {
            lblbuscar.Visible = true;
            cbxarticulo.Visible = true;
            llenarcbox();
        }
        private void llenarcbox()
        {
            DataTable dt = new DataTable();
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT * from articulo where ar_clave >=1 order by ar_nombre";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            this.cbxarticulo.DataSource = dt;
            this.cbxarticulo.ValueMember = "ar_clave";
            this.cbxarticulo.DisplayMember = "ar_nombre";
            Conexion.Close();
        }
     

              
        private void Txtexistencia_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txtpreciocosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtexistencia.Enabled = true;
                txtexistencia.Focus();
            }
        }
        private void maximo()
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT max(ar_clave)+1 as ultimo from articulo";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtcodigo.Text = leer["ultimo"].ToString();
        }

        private void Frmarticulos_Load(object sender, EventArgs e)
        {
            maximo();
        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txtdescripcion_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                limpiar();
                maximo();
            }
        }
        private void limpiar()
        {
            guardar.Enabled = false;
            btncerrar.Enabled = false;
            txtcodigo.Enabled = true;
            txtcodigo.Clear();
            txtdescripcion.Enabled = false;
            txtdescripcion.Clear();
            txtexistencia.Enabled = false;
            txtexistencia.Clear();
            cboxgrupo1.Enabled = false;
            //cboxgrupo1.Clear();
            txtpreciocosto.Enabled = false;
            txtpreciocosto.Clear();
            txtpreciov.Enabled = false;
            txtpreciov.Clear();
            txtcodigo.Focus();
        }
       
        private void txtgrupo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxgrupo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtcodigo.Text = this.cboxgrupo1.SelectedValue.ToString();
               
            }
            
        }
    }
}
