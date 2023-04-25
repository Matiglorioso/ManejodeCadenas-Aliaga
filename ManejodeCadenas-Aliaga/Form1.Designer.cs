namespace ManejodeCadenas_Aliaga
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
            this.lblPalabra = new System.Windows.Forms.Label();
            this.lblPalabra2 = new System.Windows.Forms.Label();
            this.txtPalabra1 = new System.Windows.Forms.TextBox();
            this.txtPalabra2 = new System.Windows.Forms.TextBox();
            this.lblCarac = new System.Windows.Forms.Label();
            this.lblCarac2 = new System.Windows.Forms.Label();
            this.lblLenght = new System.Windows.Forms.Label();
            this.lblLenght2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.btnConvertir2 = new System.Windows.Forms.Button();
            this.btnConvertir3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalabra
            // 
            this.lblPalabra.AutoSize = true;
            this.lblPalabra.Location = new System.Drawing.Point(14, 32);
            this.lblPalabra.Name = "lblPalabra";
            this.lblPalabra.Size = new System.Drawing.Size(55, 13);
            this.lblPalabra.TabIndex = 0;
            this.lblPalabra.Text = "Palabra 1:";
            // 
            // lblPalabra2
            // 
            this.lblPalabra2.AutoSize = true;
            this.lblPalabra2.Location = new System.Drawing.Point(14, 70);
            this.lblPalabra2.Name = "lblPalabra2";
            this.lblPalabra2.Size = new System.Drawing.Size(55, 13);
            this.lblPalabra2.TabIndex = 1;
            this.lblPalabra2.Text = "Palabra 2:";
            // 
            // txtPalabra1
            // 
            this.txtPalabra1.Location = new System.Drawing.Point(75, 29);
            this.txtPalabra1.Name = "txtPalabra1";
            this.txtPalabra1.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra1.TabIndex = 2;
            this.txtPalabra1.TextChanged += new System.EventHandler(this.txtPalabra1_TextChanged);
            // 
            // txtPalabra2
            // 
            this.txtPalabra2.Location = new System.Drawing.Point(75, 66);
            this.txtPalabra2.Name = "txtPalabra2";
            this.txtPalabra2.Size = new System.Drawing.Size(100, 20);
            this.txtPalabra2.TabIndex = 3;
            this.txtPalabra2.TextChanged += new System.EventHandler(this.txtPalabra2_TextChanged);
            // 
            // lblCarac
            // 
            this.lblCarac.AutoSize = true;
            this.lblCarac.Location = new System.Drawing.Point(195, 32);
            this.lblCarac.Name = "lblCarac";
            this.lblCarac.Size = new System.Drawing.Size(61, 13);
            this.lblCarac.TabIndex = 4;
            this.lblCarac.Text = "Caracteres:";
            // 
            // lblCarac2
            // 
            this.lblCarac2.AutoSize = true;
            this.lblCarac2.Location = new System.Drawing.Point(195, 70);
            this.lblCarac2.Name = "lblCarac2";
            this.lblCarac2.Size = new System.Drawing.Size(61, 13);
            this.lblCarac2.TabIndex = 5;
            this.lblCarac2.Text = "Caracteres:";
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Location = new System.Drawing.Point(262, 32);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(13, 13);
            this.lblLenght.TabIndex = 6;
            this.lblLenght.Text = "0";
            // 
            // lblLenght2
            // 
            this.lblLenght2.AutoSize = true;
            this.lblLenght2.Location = new System.Drawing.Point(262, 70);
            this.lblLenght2.Name = "lblLenght2";
            this.lblLenght2.Size = new System.Drawing.Size(13, 13);
            this.lblLenght2.TabIndex = 7;
            this.lblLenght2.Text = "0";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(397, 53);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 8;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFecha.Location = new System.Drawing.Point(453, 47);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(195, 20);
            this.dtpFecha.TabIndex = 9;
            this.dtpFecha.Value = new System.DateTime(2023, 4, 25, 19, 18, 0, 0);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(400, 89);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(99, 43);
            this.btnConvertir.TabIndex = 10;
            this.btnConvertir.Text = "Convertir en dia/mes/año";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtConversion
            // 
            this.txtConversion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConversion.Location = new System.Drawing.Point(400, 151);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.Size = new System.Drawing.Size(289, 13);
            this.txtConversion.TabIndex = 11;
            // 
            // btnConvertir2
            // 
            this.btnConvertir2.Location = new System.Drawing.Point(505, 89);
            this.btnConvertir2.Name = "btnConvertir2";
            this.btnConvertir2.Size = new System.Drawing.Size(89, 42);
            this.btnConvertir2.TabIndex = 12;
            this.btnConvertir2.Text = "Convertir hora formato 24hs";
            this.btnConvertir2.UseVisualStyleBackColor = true;
            this.btnConvertir2.Click += new System.EventHandler(this.btnConvertir2_Click);
            // 
            // btnConvertir3
            // 
            this.btnConvertir3.Location = new System.Drawing.Point(600, 89);
            this.btnConvertir3.Name = "btnConvertir3";
            this.btnConvertir3.Size = new System.Drawing.Size(89, 42);
            this.btnConvertir3.TabIndex = 13;
            this.btnConvertir3.Text = "Convertir fecha formato largo";
            this.btnConvertir3.UseVisualStyleBackColor = true;
            this.btnConvertir3.Click += new System.EventHandler(this.btnConvertir3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 200);
            this.Controls.Add(this.btnConvertir3);
            this.Controls.Add(this.btnConvertir2);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblLenght2);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.lblCarac2);
            this.Controls.Add(this.lblCarac);
            this.Controls.Add(this.txtPalabra2);
            this.Controls.Add(this.txtPalabra1);
            this.Controls.Add(this.lblPalabra2);
            this.Controls.Add(this.lblPalabra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalabra;
        private System.Windows.Forms.Label lblPalabra2;
        private System.Windows.Forms.TextBox txtPalabra1;
        private System.Windows.Forms.TextBox txtPalabra2;
        private System.Windows.Forms.Label lblCarac;
        private System.Windows.Forms.Label lblCarac2;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.Label lblLenght2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtConversion;
        private System.Windows.Forms.Button btnConvertir2;
        private System.Windows.Forms.Button btnConvertir3;
    }
}

