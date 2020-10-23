namespace Parcial2
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
            this.tipoPrenda = new System.Windows.Forms.GroupBox();
            this.bermuda = new System.Windows.Forms.CheckBox();
            this.mangaCorta = new System.Windows.Forms.CheckBox();
            this.pantalon = new System.Windows.Forms.RadioButton();
            this.camisa = new System.Windows.Forms.RadioButton();
            this.calidadPrenda = new System.Windows.Forms.GroupBox();
            this.premium = new System.Windows.Forms.RadioButton();
            this.standard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.price = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.calcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoPrenda.SuspendLayout();
            this.calidadPrenda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tipoPrenda
            // 
            this.tipoPrenda.Controls.Add(this.bermuda);
            this.tipoPrenda.Controls.Add(this.mangaCorta);
            this.tipoPrenda.Controls.Add(this.pantalon);
            this.tipoPrenda.Controls.Add(this.camisa);
            this.tipoPrenda.Location = new System.Drawing.Point(12, 31);
            this.tipoPrenda.Name = "tipoPrenda";
            this.tipoPrenda.Size = new System.Drawing.Size(237, 80);
            this.tipoPrenda.TabIndex = 1;
            this.tipoPrenda.TabStop = false;
            this.tipoPrenda.Text = "Tipo de Prenda";
            this.tipoPrenda.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // bermuda
            // 
            this.bermuda.AutoSize = true;
            this.bermuda.Enabled = false;
            this.bermuda.Location = new System.Drawing.Point(104, 50);
            this.bermuda.Name = "bermuda";
            this.bermuda.Size = new System.Drawing.Size(87, 21);
            this.bermuda.TabIndex = 3;
            this.bermuda.Text = "Bermuda";
            this.bermuda.UseVisualStyleBackColor = true;
            // 
            // mangaCorta
            // 
            this.mangaCorta.AutoSize = true;
            this.mangaCorta.Location = new System.Drawing.Point(104, 22);
            this.mangaCorta.Name = "mangaCorta";
            this.mangaCorta.Size = new System.Drawing.Size(111, 21);
            this.mangaCorta.TabIndex = 2;
            this.mangaCorta.Text = "Manga Corta";
            this.mangaCorta.UseVisualStyleBackColor = true;
            // 
            // pantalon
            // 
            this.pantalon.AutoSize = true;
            this.pantalon.Location = new System.Drawing.Point(7, 50);
            this.pantalon.Name = "pantalon";
            this.pantalon.Size = new System.Drawing.Size(85, 21);
            this.pantalon.TabIndex = 1;
            this.pantalon.Text = "Pantalon";
            this.pantalon.UseVisualStyleBackColor = true;
            // 
            // camisa
            // 
            this.camisa.AutoSize = true;
            this.camisa.Checked = true;
            this.camisa.Location = new System.Drawing.Point(7, 22);
            this.camisa.Name = "camisa";
            this.camisa.Size = new System.Drawing.Size(75, 21);
            this.camisa.TabIndex = 0;
            this.camisa.TabStop = true;
            this.camisa.Text = "Camisa";
            this.camisa.UseVisualStyleBackColor = true;
            this.camisa.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // calidadPrenda
            // 
            this.calidadPrenda.Controls.Add(this.premium);
            this.calidadPrenda.Controls.Add(this.standard);
            this.calidadPrenda.Location = new System.Drawing.Point(12, 117);
            this.calidadPrenda.Name = "calidadPrenda";
            this.calidadPrenda.Size = new System.Drawing.Size(238, 52);
            this.calidadPrenda.TabIndex = 2;
            this.calidadPrenda.TabStop = false;
            this.calidadPrenda.Text = "Calidad de prenda";
            this.calidadPrenda.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // premium
            // 
            this.premium.AutoSize = true;
            this.premium.Location = new System.Drawing.Point(104, 22);
            this.premium.Name = "premium";
            this.premium.Size = new System.Drawing.Size(84, 21);
            this.premium.TabIndex = 1;
            this.premium.Text = "Premium";
            this.premium.UseVisualStyleBackColor = true;
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Checked = true;
            this.standard.Location = new System.Drawing.Point(7, 22);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(87, 21);
            this.standard.TabIndex = 0;
            this.standard.TabStop = true;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.price);
            this.groupBox3.Location = new System.Drawing.Point(12, 175);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(7, 22);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(98, 22);
            this.price.TabIndex = 0;
            this.price.TextChanged += new System.EventHandler(this.price_TextChanged);
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cantidad);
            this.groupBox4.Location = new System.Drawing.Point(138, 175);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(111, 58);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // cantidad
            // 
            this.cantidad.Location = new System.Drawing.Point(7, 22);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(98, 22);
            this.cantidad.TabIndex = 0;
            this.cantidad.TextChanged += new System.EventHandler(this.cantidad_TextChanged);
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressIsNumber);
            // 
            // calcular
            // 
            this.calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.calcular.Enabled = false;
            this.calcular.ForeColor = System.Drawing.Color.Black;
            this.calcular.Location = new System.Drawing.Point(12, 239);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(238, 36);
            this.calcular.TabIndex = 5;
            this.calcular.Text = "Calcular Precio Final";
            this.calcular.UseVisualStyleBackColor = false;
            this.calcular.Click += new System.EventHandler(this.calcularPrecio);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "VENTAS AL POR MAYOR";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 284);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.calidadPrenda);
            this.Controls.Add(this.tipoPrenda);
            this.MaximumSize = new System.Drawing.Size(280, 331);
            this.MinimumSize = new System.Drawing.Size(280, 331);
            this.Name = "Form1";
            this.Text = "PradBit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tipoPrenda.ResumeLayout(false);
            this.tipoPrenda.PerformLayout();
            this.calidadPrenda.ResumeLayout(false);
            this.calidadPrenda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox tipoPrenda;
        private System.Windows.Forms.CheckBox bermuda;
        private System.Windows.Forms.CheckBox mangaCorta;
        private System.Windows.Forms.RadioButton pantalon;
        private System.Windows.Forms.RadioButton camisa;
        private System.Windows.Forms.GroupBox calidadPrenda;
        private System.Windows.Forms.RadioButton premium;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Label label1;
    }
}

