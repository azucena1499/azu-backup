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
    public partial class frmcatalogos : Form
    {
        public frmcatalogos()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Btnimprimir_Click(object sender, EventArgs e)
        {
            if (rdbgrupos.Checked)
            {
                if (rdbnombre.Checked)
                {
                    informes.frtgruponombre grupos = new informes.frtgruponombre();
                    formas.frmreporte reporte = new frmreporte();
                    reporte.crystalReportViewer1.ReportSource = grupos;
                    reporte.ShowDialog();
                    gpbordenada.Visible = true;
                }
                else
                {
                    informes.grupoporclave grupos = new informes.grupoporclave();
                    formas.frmreporte reporte = new frmreporte();
                    reporte.crystalReportViewer1.ReportSource = grupos;
                    reporte.ShowDialog();
                    gpbordenada.Visible = true;

                }
            }
            if (rdbclientes.Checked)
            {
                if (rdbnombre.Checked)
                {
                    informes.frtclientepornombre2 cliente = new informes.frtclientepornombre2();
                    formas.frmreporte reporte = new frmreporte();
                    reporte.crystalReportViewer1.ReportSource = cliente;
                    reporte.ShowDialog();
                    gpbordenada.Visible = false;
                }
                else
                {
                    informes.clientesporclave cliente = new informes.clientesporclave();
                    formas.frmreporte reporte = new frmreporte();
                    reporte.crystalReportViewer1.ReportSource = cliente;
                    reporte.ShowDialog();
                    gpbordenada.Visible = true;
                }
            }

            if (rdbarticulo.Checked)
            {

                informes.frmarticulogrupo articulo = new informes.frmarticulogrupo();
                formas.frmreporte reporte = new frmreporte();
                reporte.crystalReportViewer1.ReportSource = articulo;
                reporte.ShowDialog();
                gpbordenada.Visible = false;
            }
        }
                

        private void frmcatalogos_Load(object sender, EventArgs e)
        {
            
        }

        private void rdbclientes_Click(object sender, EventArgs e)
        {

            gpbordenada.Visible = true;
            rdbnombre.Visible = true;
            rdbclave.Visible = true;
        }

        private void gpbordenada_Enter(object sender, EventArgs e)
        {

        }

        private void rdbgrupos_Click(object sender, EventArgs e)
        {
            gpbordenada.Visible = true;
            rdbnombre.Visible =true;
            rdbclave.Visible = true;
        }

        private void rdbarticulo_Click(object sender, EventArgs e)
        {

            gpbordenada.Visible = false;
            rdbnombre.Visible = false;
            rdbclave.Visible = false;
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
