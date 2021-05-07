using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class CalculadoraPrestamos : Form
    {
        Logica.Prestamos Prestamos = new Logica.Prestamos();
        Logica.Archivos Archivos = new Logica.Archivos();
        public CalculadoraPrestamos()
        {
            InitializeComponent();
        }

        private void CalculadoraPrestamos_Load(object sender, EventArgs e)
        {
            lblCuotaMensual.Visible = false;
            lblValorCuotaMensual.Visible = false;
            lblInteresPago.Visible = false;
            lblValorInteresPago.Visible = false;
            lblNumeroPagos.Visible = false;
            lblValorNumeroPagos.Visible = false;
            fecha.Enabled = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Prestamos.CalculosPrestamo(txtImportePrestamo, txtInteresPrestamo, txtTiempoPrestamo, cbTipoPrestamo, lblValorCuotaMensual, lblValorInteresPago, lblValorNumeroPagos);
            if(lblValorCuotaMensual.Text != "")
            {
                lblCuotaMensual.Visible = true;
                lblValorCuotaMensual.Visible = true;
                lblInteresPago.Visible = true;
                lblValorInteresPago.Visible = true;
                lblNumeroPagos.Visible = true;
                lblValorNumeroPagos.Visible = true;
            }
            Archivos.RegistrarPrestamo(fecha, txtImportePrestamo, txtInteresPrestamo, txtTiempoPrestamo, cbTipoPrestamo, lblValorCuotaMensual, lblValorInteresPago);
        }
    }
}
