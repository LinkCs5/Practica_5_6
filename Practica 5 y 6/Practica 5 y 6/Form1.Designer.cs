namespace Practica_5_y_6
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
            this.boton_Calcular = new System.Windows.Forms.Button();
            this.dinero_ingresado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Monto_Pagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cambio_total = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boton_Calcular
            // 
            this.boton_Calcular.Location = new System.Drawing.Point(523, 152);
            this.boton_Calcular.Name = "boton_Calcular";
            this.boton_Calcular.Size = new System.Drawing.Size(75, 23);
            this.boton_Calcular.TabIndex = 0;
            this.boton_Calcular.Text = "Calcular";
            this.boton_Calcular.UseVisualStyleBackColor = true;
            this.boton_Calcular.Click += new System.EventHandler(this.boton_Calcular_Click);
            // 
            // dinero_ingresado
            // 
            this.dinero_ingresado.Location = new System.Drawing.Point(362, 155);
            this.dinero_ingresado.Name = "dinero_ingresado";
            this.dinero_ingresado.Size = new System.Drawing.Size(100, 20);
            this.dinero_ingresado.TabIndex = 2;
            this.dinero_ingresado.TextChanged += new System.EventHandler(this.dinero_ingresado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Monto a pagar: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Monto_Pagar
            // 
            this.Monto_Pagar.Location = new System.Drawing.Point(94, 152);
            this.Monto_Pagar.Name = "Monto_Pagar";
            this.Monto_Pagar.Size = new System.Drawing.Size(100, 20);
            this.Monto_Pagar.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Monto Recibido: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cambio: ";
            // 
            // cambio_total
            // 
            this.cambio_total.AutoSize = true;
            this.cambio_total.Location = new System.Drawing.Point(228, 228);
            this.cambio_total.Name = "cambio_total";
            this.cambio_total.Size = new System.Drawing.Size(13, 13);
            this.cambio_total.TabIndex = 9;
            this.cambio_total.Text = "0";
            this.cambio_total.Click += new System.EventHandler(this.cambio_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(274, 228);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 10;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 401);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cambio_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Monto_Pagar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dinero_ingresado);
            this.Controls.Add(this.boton_Calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_Calcular;
        private System.Windows.Forms.TextBox dinero_ingresado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Monto_Pagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cambio_total;
        private System.Windows.Forms.ListBox listBox1;
    }
}

