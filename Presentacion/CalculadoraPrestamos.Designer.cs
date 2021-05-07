
namespace Presentacion
{
    partial class CalculadoraPrestamos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.txtTiempoPrestamo = new System.Windows.Forms.TextBox();
            this.txtInteresPrestamo = new System.Windows.Forms.TextBox();
            this.txtImportePrestamo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInteresPago = new System.Windows.Forms.Label();
            this.lblNumeroPagos = new System.Windows.Forms.Label();
            this.lblCuotaMensual = new System.Windows.Forms.Label();
            this.lblValorInteresPago = new System.Windows.Forms.Label();
            this.lblValorNumeroPagos = new System.Windows.Forms.Label();
            this.lblValorCuotaMensual = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fecha);
            this.groupBox1.Controls.Add(this.btnCalcular);
            this.groupBox1.Controls.Add(this.lblValorInteresPago);
            this.groupBox1.Controls.Add(this.lblValorNumeroPagos);
            this.groupBox1.Controls.Add(this.lblValorCuotaMensual);
            this.groupBox1.Controls.Add(this.lblInteresPago);
            this.groupBox1.Controls.Add(this.lblNumeroPagos);
            this.groupBox1.Controls.Add(this.lblCuotaMensual);
            this.groupBox1.Controls.Add(this.cbTipoPrestamo);
            this.groupBox1.Controls.Add(this.txtTiempoPrestamo);
            this.groupBox1.Controls.Add(this.txtInteresPrestamo);
            this.groupBox1.Controls.Add(this.txtImportePrestamo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora de Cuotas de Préstamo";
            // 
            // cbTipoPrestamo
            // 
            this.cbTipoPrestamo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPrestamo.FormattingEnabled = true;
            this.cbTipoPrestamo.Items.AddRange(new object[] {
            "-- Selecciona el tipo de préstamo --",
            "Personal"});
            this.cbTipoPrestamo.Location = new System.Drawing.Point(406, 217);
            this.cbTipoPrestamo.Name = "cbTipoPrestamo";
            this.cbTipoPrestamo.Size = new System.Drawing.Size(167, 29);
            this.cbTipoPrestamo.TabIndex = 10;
            // 
            // txtTiempoPrestamo
            // 
            this.txtTiempoPrestamo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoPrestamo.Location = new System.Drawing.Point(406, 170);
            this.txtTiempoPrestamo.Name = "txtTiempoPrestamo";
            this.txtTiempoPrestamo.Size = new System.Drawing.Size(167, 27);
            this.txtTiempoPrestamo.TabIndex = 7;
            // 
            // txtInteresPrestamo
            // 
            this.txtInteresPrestamo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteresPrestamo.Location = new System.Drawing.Point(406, 122);
            this.txtInteresPrestamo.Name = "txtInteresPrestamo";
            this.txtInteresPrestamo.Size = new System.Drawing.Size(167, 27);
            this.txtInteresPrestamo.TabIndex = 6;
            // 
            // txtImportePrestamo
            // 
            this.txtImportePrestamo.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportePrestamo.Location = new System.Drawing.Point(406, 72);
            this.txtImportePrestamo.Name = "txtImportePrestamo";
            this.txtImportePrestamo.Size = new System.Drawing.Size(167, 27);
            this.txtImportePrestamo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiempo de Amortización en Meses: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de Préstamo: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interés del Préstamo (% Anual TAE): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importe del Préstamo:";
            // 
            // lblInteresPago
            // 
            this.lblInteresPago.AutoSize = true;
            this.lblInteresPago.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInteresPago.Location = new System.Drawing.Point(46, 436);
            this.lblInteresPago.Name = "lblInteresPago";
            this.lblInteresPago.Size = new System.Drawing.Size(138, 21);
            this.lblInteresPago.TabIndex = 14;
            this.lblInteresPago.Text = "Interés a Pagar:";
            // 
            // lblNumeroPagos
            // 
            this.lblNumeroPagos.AutoSize = true;
            this.lblNumeroPagos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPagos.Location = new System.Drawing.Point(46, 388);
            this.lblNumeroPagos.Name = "lblNumeroPagos";
            this.lblNumeroPagos.Size = new System.Drawing.Size(150, 21);
            this.lblNumeroPagos.TabIndex = 12;
            this.lblNumeroPagos.Text = "Número de Pagos";
            // 
            // lblCuotaMensual
            // 
            this.lblCuotaMensual.AutoSize = true;
            this.lblCuotaMensual.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaMensual.Location = new System.Drawing.Point(46, 338);
            this.lblCuotaMensual.Name = "lblCuotaMensual";
            this.lblCuotaMensual.Size = new System.Drawing.Size(143, 21);
            this.lblCuotaMensual.TabIndex = 11;
            this.lblCuotaMensual.Text = "Cuota Mensual: ";
            // 
            // lblValorInteresPago
            // 
            this.lblValorInteresPago.AutoSize = true;
            this.lblValorInteresPago.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInteresPago.Location = new System.Drawing.Point(252, 436);
            this.lblValorInteresPago.Name = "lblValorInteresPago";
            this.lblValorInteresPago.Size = new System.Drawing.Size(0, 21);
            this.lblValorInteresPago.TabIndex = 17;
            // 
            // lblValorNumeroPagos
            // 
            this.lblValorNumeroPagos.AutoSize = true;
            this.lblValorNumeroPagos.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorNumeroPagos.Location = new System.Drawing.Point(252, 388);
            this.lblValorNumeroPagos.Name = "lblValorNumeroPagos";
            this.lblValorNumeroPagos.Size = new System.Drawing.Size(0, 21);
            this.lblValorNumeroPagos.TabIndex = 16;
            // 
            // lblValorCuotaMensual
            // 
            this.lblValorCuotaMensual.AutoSize = true;
            this.lblValorCuotaMensual.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorCuotaMensual.Location = new System.Drawing.Point(252, 338);
            this.lblValorCuotaMensual.Name = "lblValorCuotaMensual";
            this.lblValorCuotaMensual.Size = new System.Drawing.Size(0, 21);
            this.lblValorCuotaMensual.TabIndex = 15;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(256, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(167, 31);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(15, 26);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(373, 27);
            this.fecha.TabIndex = 19;
            // 
            // CalculadoraPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 507);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CalculadoraPrestamos";
            this.Text = "Calculadora de Cuotas de Préstamo";
            this.Load += new System.EventHandler(this.CalculadoraPrestamos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTiempoPrestamo;
        private System.Windows.Forms.TextBox txtInteresPrestamo;
        private System.Windows.Forms.TextBox txtImportePrestamo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoPrestamo;
        private System.Windows.Forms.Label lblValorInteresPago;
        private System.Windows.Forms.Label lblValorNumeroPagos;
        private System.Windows.Forms.Label lblValorCuotaMensual;
        private System.Windows.Forms.Label lblInteresPago;
        private System.Windows.Forms.Label lblNumeroPagos;
        private System.Windows.Forms.Label lblCuotaMensual;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DateTimePicker fecha;
    }
}

