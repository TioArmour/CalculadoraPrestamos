using System;
using System.Windows.Forms;

namespace Logica
{
    public class Prestamos
    {
        double cuotaMensual;
        double interesPago;
        double interesMensual;
        double interesAnual;
        string numeroPagos;
        public void CalculosPrestamo(TextBox montoPrestamo, TextBox interesPrestamo, TextBox tiempoPrestamo, ComboBox tipoPrestamo, Label valorCuotaMensual, Label valorInteresPago, Label valorTiempoPrestamo)
        {
            if (montoPrestamo.Text != "" && interesPrestamo.Text != "" && tiempoPrestamo.Text != "")
            {
                try
                {
                interesAnual = double.Parse(interesPrestamo.Text) / 100;
                interesMensual = interesAnual/ 12;
                numeroPagos = tiempoPrestamo.Text;
                double numerador = double.Parse(montoPrestamo.Text) * interesMensual;
                double denominador = 1 - Math.Pow((1 + interesMensual), -12);
                cuotaMensual = Math.Round((numerador / denominador),2);
                interesPago = Math.Round((cuotaMensual*double.Parse(numeroPagos)) - double.Parse(montoPrestamo.Text),2);
                valorCuotaMensual.Text = Convert.ToString(cuotaMensual);
                valorInteresPago.Text = Convert.ToString(interesPago);
                valorTiempoPrestamo.Text = numeroPagos;
                }
                catch
                {
                    MessageBox.Show("Existe un error en la información proporcionada");
                }
            }
            else
            {
                MessageBox.Show("Hace falta mas informacion");
            }
        }
    }
}
