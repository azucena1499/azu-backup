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
    public partial class frmventa : Form
    {
        clases.Conexion objconexion;
        SqlConnection Conexion;
        int existe = 0;

        public frmventa()
        {
            InitializeComponent();
        }

        private void maximo()
        {
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT max(vg_folio)+1 as ultimo from ventagen";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
                txtfolio.Text = leer["ultimo"].ToString();
        }
        private void limpiar()
        {
            txttelefono.Enabled = false;
            txttelefono.Clear();
            txtlocalidad.Enabled = false;
            txtlocalidad.Clear();
            txtnombre.Enabled = false;
            txtnombre.Clear();
            txtcliente.Enabled = true;
            txtcliente.Clear();
        }
        private void habilitar()
        {
            txtcliente.Enabled = true;
            txtlocalidad.Enabled = true;
            txttelefono.Enabled = true;
            txtnombre.Enabled = true;
        }
        private void Rdbtncontado_Click(object sender, EventArgs e)
        {
            if (rdbtncontado.Checked)
            {
                gpboxinfo.Visible = true;
                txtfolio.Enabled = false;
                txtcliente.Focus();
            }
        }
        private void Frmventa_Load(object sender, EventArgs e)
        {
            maximo();
            txtcodigo.Focus();

        }
        private void Rdbtncreito_Click(object sender, EventArgs e)
        {
            if (rdbtncreito.Checked)
            {
                txtfolio.Enabled = true;
                dtpfecha.Enabled = true;
                gpboxinfo.Visible = false;
                txtfolio.Focus();


            }
        }
        private void Txtcliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 13)
                //chechando que no sea valor nulo o blanco
                if (string.IsNullOrEmpty(txtcliente.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcliente.Enabled = true;
                    txtcliente.Clear();
                    txtcliente.Focus();
                }
                else
                {
                    objconexion = new clases.Conexion();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from clientes where cl_clave=@cl_clave";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@cl_clave", int.Parse(txtcliente.Text));


                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                        existe = 1;
                        txtnombre.Enabled = true;
                        txtlocalidad.Enabled = true;
                        txttelefono.Enabled = true;
                        txtnombre.Focus();
                        txtcliente.Enabled = false;


                        //igualo los campos o columnas al txtnombre
                        txtcliente.Text = leer["cl_clave"].ToString();
                        txtnombre.Text = leer["cl_nombre"].ToString();
                        txtlocalidad.Text = leer["cl_localidad"].ToString();
                        txttelefono.Text = leer["cl_telefono"].ToString();

                    }
                    else
                    {
                        existe = 0;
                        if (MessageBox.Show("cliente no registrado.¿desea agregar un nuevo cliente?", "no existe", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            txtnombre.Enabled = true;
                            txtnombre.Focus();
                            habilitar();
                        }
                        else
                        {
                            txtcliente.Clear();
                            txtcliente.Focus();

                        }
                    }

                }
        }
        private void Lbllupa_Click(object sender, EventArgs e)
        {
            lbllupa.Visible = true;
            cbxcliente.Visible = true;
            llenarcbox();
        }
        private void Cbxcliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.txtcliente.Text = this.cbxcliente.SelectedValue.ToString();
                lbllupa.Visible = false;
                cbxcliente.Visible = false;
                txtcliente.Enabled = true;
                txtcliente.Focus();
                txtnombre.Enabled = true;
            }
        }
        private void llenarcbox()
        {
            DataTable dt = new DataTable();
            objconexion = new clases.Conexion();
            Conexion = new SqlConnection(objconexion.Conn());
            Conexion.Open();
            string query = "SELECT * from clientes where cl_estatus=1 order by cl_clave";
            SqlCommand comando = new SqlCommand(query, Conexion);
            SqlDataAdapter da = new SqlDataAdapter(comando);
            da.Fill(dt);
            this.cbxcliente.DataSource = dt;
            this.cbxcliente.ValueMember = "cl_clave";
            this.cbxcliente.DisplayMember = "cl_nombre";
            Conexion.Close();
        }
        private void Txtcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                txtnombre.Enabled = true;
                txtnombre.Focus();
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
        private void Txtcliente_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                limpiar();
                maximo();
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
                    txtlocalidad.Enabled = true;
                    txtlocalidad.Focus();
                }
            }
        }

        private void Txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (string.IsNullOrEmpty(txtcodigo.Text))
                {
                    MessageBox.Show("Error:No se permiten nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcliente.Enabled = true;
                    txtcliente.Clear();
                    txtcliente.Focus();
                }
                else
                {
                    objconexion = new clases.Conexion();
                    Conexion = new SqlConnection(objconexion.Conn());
                    //se abre la conexion
                    Conexion.Open();
                    string query = "select * from articulo where ar_clave=@ar_clave";
                    //asigno a comando el sqlcommand
                    SqlCommand comando = new SqlCommand(query, Conexion);
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@ar_clave", int.Parse(txtcodigo.Text));

                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.Read())
                    {
                      
                        txtnombree.Text = leer["ar_nombre"].ToString();
                        txtpreciou.Text = leer["ar_precioventa"].ToString();
                        txtpreciou.Focus();
                        btnresta.Enabled = true;
                        btnsuma.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("articulo no registrado.¿desea agregar un nuevo articulo?", "no existe", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtcodigo.Clear();
                        txtcodigo.Focus();
                    }
                }
            }
        }

        private void Txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtimporte.Text = (Convert.ToDouble(txtpreciou.Text) * Convert.ToDouble(txtcantidad.Text)).ToString("n2");
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            dgvventa.Rows.Add(txtcodigo.Text, txtnombree.Text, txtcantidad.Text, txtpreciou.Text, txtimporte.Text);
            txtcodigo.Clear();
            txtnombree.Clear();
            txtpreciou.Clear();
            txtcantidad.Clear();
            txtimporte.Clear();
            suma();
            txtcodigo.Focus();
        }
        private void suma()
        {
            double total = 0;
            foreach(DataGridViewRow row in dgvventa.Rows)
            {
               total += Convert.ToDouble(row.Cells["importe"].Value);
                suma();
                txtcodigo.Focus();
            }
        }

        
    }
}
        
                            
            
