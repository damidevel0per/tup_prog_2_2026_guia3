namespace Figuras
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbRadio = new System.Windows.Forms.TextBox();
            this.tbAlto = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbLargo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbCreadas = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbLargo);
            this.groupBox1.Controls.Add(this.tbAncho);
            this.groupBox1.Controls.Add(this.tbAlto);
            this.groupBox1.Controls.Add(this.tbRadio);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creacion de figuras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el tipo de figura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Radio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Alto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ancho";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Largo";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "CIRCULO",
            "RECTANGULO",
            "ESFERA",
            "CILINDRO"});
            this.listBox1.Location = new System.Drawing.Point(35, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 69);
            this.listBox1.TabIndex = 5;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbRadio
            // 
            this.tbRadio.Location = new System.Drawing.Point(281, 49);
            this.tbRadio.Name = "tbRadio";
            this.tbRadio.Size = new System.Drawing.Size(100, 20);
            this.tbRadio.TabIndex = 6;
            // 
            // tbAlto
            // 
            this.tbAlto.Location = new System.Drawing.Point(281, 105);
            this.tbAlto.Name = "tbAlto";
            this.tbAlto.Size = new System.Drawing.Size(100, 20);
            this.tbAlto.TabIndex = 7;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(447, 49);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(100, 20);
            this.tbAncho.TabIndex = 8;
            // 
            // tbLargo
            // 
            this.tbLargo.Location = new System.Drawing.Point(447, 105);
            this.tbLargo.Name = "tbLargo";
            this.tbLargo.Size = new System.Drawing.Size(100, 20);
            this.tbLargo.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(581, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Agregar figura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lbCreadas);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 169);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Figuras creadas";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(581, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 34);
            this.button2.TabIndex = 10;
            this.button2.Text = "Eliminar figura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbCreadas
            // 
            this.lbCreadas.FormattingEnabled = true;
            this.lbCreadas.Location = new System.Drawing.Point(35, 57);
            this.lbCreadas.Name = "lbCreadas";
            this.lbCreadas.Size = new System.Drawing.Size(512, 95);
            this.lbCreadas.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Elija la figura para eliminarla";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbCreadas;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbLargo;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbAlto;
        private System.Windows.Forms.TextBox tbRadio;
        private System.Windows.Forms.ListBox listBox1;
    }
}

