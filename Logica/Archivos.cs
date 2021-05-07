using System.Windows.Forms;
using System.IO;

namespace Logica
{
    public class Archivos
    {
        public void RegistrarPrestamo(DateTimePicker fecha,TextBox montoPrestamo, TextBox interesPrestamo, TextBox tiempoPrestamo, ComboBox tipoPrestamo, Label valorCuotaMensual, Label valorInteresPago)
        {
            if(valorCuotaMensual.Text != "")
            {

            string ruta = @"C:\Users\omarc\OneDrive - Escuela Militar de Ingenieria\3° Semestre Ing. Mec\Programacion II\VisualStudio\AvanceP2\Prestamos\Archivos\Prestamos.txt";
            StreamWriter sw = new StreamWriter(ruta, true);

            sw.WriteLine(fecha.Text);
            sw.WriteLine($"Monto Prestamo: {montoPrestamo.Text} Bs.");
            sw.WriteLine($"Interes Préstamo: {interesPrestamo.Text} Bs.");
            sw.WriteLine($"Tiempo Préstamo: {tiempoPrestamo.Text} meses");
            sw.WriteLine($"Tipo Préstamo: {tipoPrestamo.SelectedItem}");
            sw.WriteLine($"Cuota Mensual: {valorCuotaMensual.Text} Bs.");
            sw.WriteLine($"Interes a Pagar: {valorInteresPago.Text} Bs.");
            sw.Close();
            }
        }
    }
}
