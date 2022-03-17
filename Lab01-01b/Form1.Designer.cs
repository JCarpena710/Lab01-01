namespace Lab01_01b
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.Label();
            this.txtOperacion = new System.Windows.Forms.ComboBox();
            this.txtTemperatura = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Operación = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.txtTipoTemperatura = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(128, 28);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(121, 22);
            this.txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(128, 67);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(121, 22);
            this.txtNumero2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(323, 109);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(91, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 5;
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(42, 150);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(72, 16);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.Text = "Resultado:";
            // 
            // txtOperacion
            // 
            this.txtOperacion.FormattingEnabled = true;
            this.txtOperacion.Items.AddRange(new object[] {
            "Sumar",
            "Restar",
            "Multiplicar ",
            "Dividir"});
            this.txtOperacion.Location = new System.Drawing.Point(128, 106);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(121, 24);
            this.txtOperacion.TabIndex = 7;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.AutoSize = true;
            this.txtTemperatura.Location = new System.Drawing.Point(29, 262);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(88, 16);
            this.txtTemperatura.TabIndex = 8;
            this.txtTemperatura.Text = "Temperatura:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 9;
            // 
            // Operación
            // 
            this.Operación.AutoSize = true;
            this.Operación.Location = new System.Drawing.Point(33, 109);
            this.Operación.Name = "Operación";
            this.Operación.Size = new System.Drawing.Size(73, 16);
            this.Operación.TabIndex = 10;
            this.Operación.Text = "Operación:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Convertir a:";
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(323, 312);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(91, 23);
            this.btnConvertir.TabIndex = 12;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Resultado:";
            // 
            // txtResultado2
            // 
            this.txtResultado2.Location = new System.Drawing.Point(128, 363);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(121, 22);
            this.txtResultado2.TabIndex = 15;
            // 
            // txtTipoTemperatura
            // 
            this.txtTipoTemperatura.FormattingEnabled = true;
            this.txtTipoTemperatura.Items.AddRange(new object[] {
            "°C",
            "°F"});
            this.txtTipoTemperatura.Location = new System.Drawing.Point(128, 312);
            this.txtTipoTemperatura.Name = "txtTipoTemperatura";
            this.txtTipoTemperatura.Size = new System.Drawing.Size(121, 24);
            this.txtTipoTemperatura.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 450);
            this.Controls.Add(this.txtTipoTemperatura);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Operación);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.txtOperacion);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.ComboBox txtOperacion;
        private System.Windows.Forms.Label txtTemperatura;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Operación;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.ComboBox txtTipoTemperatura;
    }
}

