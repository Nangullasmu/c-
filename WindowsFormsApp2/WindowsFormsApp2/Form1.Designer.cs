namespace WindowsFormsApp2
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
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtFarenheit = new System.Windows.Forms.TextBox();
            this.btnFarenheit = new System.Windows.Forms.Button();
            this.btnCelsius = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnlimpiar.Location = new System.Drawing.Point(224, 214);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(108, 74);
            this.btnlimpiar.TabIndex = 0;
            this.btnlimpiar.Text = "limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // txtCelsius
            // 
            this.txtCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCelsius.Location = new System.Drawing.Point(394, 85);
            this.txtCelsius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(76, 20);
            this.txtCelsius.TabIndex = 1;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            // 
            // txtFarenheit
            // 
            this.txtFarenheit.Location = new System.Drawing.Point(93, 85);
            this.txtFarenheit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFarenheit.Name = "txtFarenheit";
            this.txtFarenheit.Size = new System.Drawing.Size(76, 20);
            this.txtFarenheit.TabIndex = 2;
            // 
            // btnFarenheit
            // 
            this.btnFarenheit.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnFarenheit.Location = new System.Drawing.Point(61, 129);
            this.btnFarenheit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFarenheit.Name = "btnFarenheit";
            this.btnFarenheit.Size = new System.Drawing.Size(135, 60);
            this.btnFarenheit.TabIndex = 3;
            this.btnFarenheit.Text = "Farenheit a Celcius";
            this.btnFarenheit.UseVisualStyleBackColor = false;
            this.btnFarenheit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCelsius
            // 
            this.btnCelsius.BackColor = System.Drawing.Color.LightCoral;
            this.btnCelsius.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCelsius.Location = new System.Drawing.Point(359, 128);
            this.btnCelsius.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCelsius.Name = "btnCelsius";
            this.btnCelsius.Size = new System.Drawing.Size(147, 61);
            this.btnCelsius.TabIndex = 4;
            this.btnCelsius.Text = "celcius a farenheit";
            this.btnCelsius.UseVisualStyleBackColor = false;
            this.btnCelsius.Click += new System.EventHandler(this.btnCelsius_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Conversor de temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "grados farenheit";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(448, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "grados celsius";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCelsius);
            this.Controls.Add(this.btnFarenheit);
            this.Controls.Add(this.txtFarenheit);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.btnlimpiar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtFarenheit;
        private System.Windows.Forms.Button btnFarenheit;
        private System.Windows.Forms.Button btnCelsius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

