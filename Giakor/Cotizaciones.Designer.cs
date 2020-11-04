namespace Giakor
{
    partial class Cotizaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.llegada = new System.Windows.Forms.DateTimePicker();
            this.Salida = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnoches = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthab = new System.Windows.Forms.ComboBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rdaltasi = new System.Windows.Forms.RadioButton();
            this.rdaltano = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // llegada
            // 
            this.llegada.Location = new System.Drawing.Point(188, 103);
            this.llegada.Name = "llegada";
            this.llegada.Size = new System.Drawing.Size(200, 20);
            this.llegada.TabIndex = 0;
            // 
            // Salida
            // 
            this.Salida.Location = new System.Drawing.Point(188, 71);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(200, 20);
            this.Salida.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(12, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dia de llegada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dia de salida";
            // 
            // lblnoches
            // 
            this.lblnoches.AutoSize = true;
            this.lblnoches.BackColor = System.Drawing.Color.Transparent;
            this.lblnoches.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnoches.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnoches.Location = new System.Drawing.Point(205, 143);
            this.lblnoches.Name = "lblnoches";
            this.lblnoches.Size = new System.Drawing.Size(18, 17);
            this.lblnoches.TabIndex = 23;
            this.lblnoches.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "N. de Noches";
            // 
            // txthab
            // 
            this.txthab.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txthab.FormattingEnabled = true;
            this.txthab.Items.AddRange(new object[] {
            "101",
            "102",
            "103",
            "104",
            "105",
            "106",
            "107",
            "201",
            "202",
            "301",
            "302",
            "303",
            "304",
            "401",
            "402",
            "501",
            "502",
            "503",
            "601",
            "602",
            "603"});
            this.txthab.Location = new System.Drawing.Point(196, 41);
            this.txthab.Name = "txthab";
            this.txthab.Size = new System.Drawing.Size(121, 21);
            this.txthab.TabIndex = 21;
            // 
            // txtmonto
            // 
            this.txtmonto.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtmonto.Location = new System.Drawing.Point(188, 191);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(121, 20);
            this.txtmonto.TabIndex = 20;
            this.txtmonto.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(12, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Monto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(12, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Habitacion";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdaltasi
            // 
            this.rdaltasi.AutoSize = true;
            this.rdaltasi.BackColor = System.Drawing.Color.Transparent;
            this.rdaltasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdaltasi.Location = new System.Drawing.Point(188, 163);
            this.rdaltasi.Name = "rdaltasi";
            this.rdaltasi.Size = new System.Drawing.Size(39, 22);
            this.rdaltasi.TabIndex = 25;
            this.rdaltasi.Text = "Si";
            this.rdaltasi.UseVisualStyleBackColor = false;
            // 
            // rdaltano
            // 
            this.rdaltano.AutoSize = true;
            this.rdaltano.BackColor = System.Drawing.Color.Transparent;
            this.rdaltano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdaltano.Location = new System.Drawing.Point(244, 163);
            this.rdaltano.Name = "rdaltano";
            this.rdaltano.Size = new System.Drawing.Size(46, 22);
            this.rdaltano.TabIndex = 26;
            this.rdaltano.Text = "No";
            this.rdaltano.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Temporada Alta";
            // 
            // Cotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Giakor.Properties.Resources._104;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdaltano);
            this.Controls.Add(this.rdaltasi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblnoches);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthab);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Salida);
            this.Controls.Add(this.llegada);
            this.Name = "Cotizaciones";
            this.Text = "Cotizaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker llegada;
        private System.Windows.Forms.DateTimePicker Salida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblnoches;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txthab;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdaltasi;
        private System.Windows.Forms.RadioButton rdaltano;
        private System.Windows.Forms.Label label1;
    }
}